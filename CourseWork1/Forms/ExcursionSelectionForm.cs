using CourseWork1.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork1.Forms
{
    public partial class ExcursionSelectionForm : Form
    {
        public List<ExcursionDTO> SelectedExcursions { get; private set; } = new List<ExcursionDTO>();

        public ExcursionSelectionForm(List<ExcursionDTO> availableExcursions)
        {
            InitializeComponent();
            ConfigureDataGridView();

            foreach (var excursion in availableExcursions)
            {
                int index = ExcursionsDataGridView.Rows.Add();
                ExcursionsDataGridView.Rows[index].Cells["IdColumn"].Value = excursion.Id;
                ExcursionsDataGridView.Rows[index].Cells["NameColumn"].Value = excursion.Name;
                ExcursionsDataGridView.Rows[index].Tag = excursion;
            }
        }

        private void ConfigureDataGridView()
        {
            ExcursionsDataGridView.Columns.Clear();

            var selectColumn = new DataGridViewCheckBoxColumn
            {
                Name = "SelectColumn",
                HeaderText = "Выбрать",
                Width = 55,
            };
            ExcursionsDataGridView.Columns.Add(selectColumn);

            var idColumn = new DataGridViewTextBoxColumn
            {
                Name = "IdColumn",
                HeaderText = "ID",
                ReadOnly = true,
            };
            ExcursionsDataGridView.Columns.Add(idColumn);

            var nameColumn = new DataGridViewTextBoxColumn
            {
                Name = "NameColumn",
                HeaderText = "Название экскурсии",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                ReadOnly = true,
            };
            ExcursionsDataGridView.Columns.Add(nameColumn);
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            SelectedExcursions.Clear();

            foreach (DataGridViewRow row in ExcursionsDataGridView.Rows)
            {
                var isSelected = row.Cells["SelectColumn"] as DataGridViewCheckBoxCell;
                if (isSelected != null && Convert.ToBoolean(isSelected.Value) == true)
                {
                    SelectedExcursions.Add(row.Tag as ExcursionDTO);
                }
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        #region Designer-generated code

        private DataGridView ExcursionsDataGridView;
        private Button ConfirmButton;
        private Button CancelButton;

        private void InitializeComponent()
        {
            this.ExcursionsDataGridView = new System.Windows.Forms.DataGridView();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ExcursionsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ExcursionsDataGridView
            // 
            this.ExcursionsDataGridView.AllowUserToAddRows = false;
            this.ExcursionsDataGridView.AllowUserToDeleteRows = false;
            this.ExcursionsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExcursionsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.ExcursionsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.ExcursionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExcursionsDataGridView.Location = new System.Drawing.Point(10, 10);
            this.ExcursionsDataGridView.Name = "ExcursionsDataGridView";
            this.ExcursionsDataGridView.RowHeadersVisible = false;
            this.ExcursionsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ExcursionsDataGridView.Size = new System.Drawing.Size(480, 260);
            this.ExcursionsDataGridView.TabIndex = 0;
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ConfirmButton.Location = new System.Drawing.Point(357, 276);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(64, 26);
            this.ConfirmButton.TabIndex = 1;
            this.ConfirmButton.Text = "ОК";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.Location = new System.Drawing.Point(426, 276);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(64, 26);
            this.CancelButton.TabIndex = 2;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ExcursionSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 313);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.ExcursionsDataGridView);
            this.Name = "ExcursionSelectionForm";
            this.Text = "Выбор экскурсий";
            ((System.ComponentModel.ISupportInitialize)(this.ExcursionsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}

