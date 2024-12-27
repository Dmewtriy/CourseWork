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
    public partial class ClientsSelectionForm : Form
    {
        public List<ClientDTO> SelectedClients { get; private set; } = new List<ClientDTO>();

        public ClientsSelectionForm(List<ClientDTO> availableRouteClients)
        {
            InitializeComponent();
            ConfigureDataGridView();

            foreach (var client in availableRouteClients)
            {
                int index = ClientsDataGridView.Rows.Add();
                ClientsDataGridView.Rows[index].Cells["idColumn"].Value = client.Id;
                ClientsDataGridView.Rows[index].Cells["LastNameColumn"].Value = client.LastName;
                ClientsDataGridView.Rows[index].Cells["FirstNameColumn"].Value = client.FirstName;
                ClientsDataGridView.Rows[index].Cells["PatronymicColumn"].Value = client.Patronymic;
                ClientsDataGridView.Rows[index].Cells["BirthDateColumn"].Value = client.DateOfBirth.ToShortDateString();
                ClientsDataGridView.Rows[index].Cells["PassportColumn"].Value = client.PassportData.ToString();
                ClientsDataGridView.Rows[index].Tag = client;
            }
        }

        private void ConfigureDataGridView()
        {
            ClientsDataGridView.Columns.Clear();

            var selectColumn = new DataGridViewCheckBoxColumn
            {
                Name = "SelectColumn",
                HeaderText = "Выбрать",
                Width = 55,
            };
            ClientsDataGridView.Columns.Add(selectColumn);

            var idColumn = new DataGridViewTextBoxColumn
            {
                Name = "idColumn",
                HeaderText = "ID",
                ReadOnly = true,
            };
            ClientsDataGridView.Columns.Add(idColumn);

            var LastNameColumn = new DataGridViewTextBoxColumn
            {
                Name = "LastNameColumn",
                HeaderText = "Фамилия",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                ReadOnly = true,
            };
            ClientsDataGridView.Columns.Add(LastNameColumn);

            var FirstNameColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Имя",
                Name = "FirstNameColumn",
                ReadOnly = true
            };
            ClientsDataGridView.Columns.Add(FirstNameColumn);

            var PatronymicColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Отчество",
                Name = "PatronymicColumn",
                ReadOnly = true
            };
            ClientsDataGridView.Columns.Add(PatronymicColumn);

            var BirthDateColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Дата рождения",
                Name = "BirthDateColumn",
                ReadOnly = true
            };
            ClientsDataGridView.Columns.Add(BirthDateColumn);

            var PassportColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Паспорт",
                Name = "PassportColumn",
                ReadOnly = true
            };
            ClientsDataGridView.Columns.Add(PassportColumn);
            ClientsDataGridView.AutoSize = true;
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            SelectedClients.Clear();

            foreach (DataGridViewRow row in ClientsDataGridView.Rows)
            {
                var isSelected = row.Cells["SelectColumn"] as DataGridViewCheckBoxCell;
                if (isSelected != null && Convert.ToBoolean(isSelected.Value) == true)
                {
                    SelectedClients.Add(row.Tag as ClientDTO);
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

        private DataGridView ClientsDataGridView;
        private Button ConfirmButton;
        private Button CancelButton;

        private void InitializeComponent()
        {
            this.ClientsDataGridView = new System.Windows.Forms.DataGridView();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientsDataGridView
            // 
            this.ClientsDataGridView.AllowUserToAddRows = false;
            this.ClientsDataGridView.AllowUserToDeleteRows = false;
            this.ClientsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClientsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.ClientsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.ClientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientsDataGridView.Location = new System.Drawing.Point(13, 12);
            this.ClientsDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.ClientsDataGridView.Name = "ClientsDataGridView";
            this.ClientsDataGridView.RowHeadersVisible = false;
            this.ClientsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ClientsDataGridView.Size = new System.Drawing.Size(836, 320);
            this.ClientsDataGridView.TabIndex = 0;
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ConfirmButton.Location = new System.Drawing.Point(672, 340);
            this.ConfirmButton.Margin = new System.Windows.Forms.Padding(4);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(85, 32);
            this.ConfirmButton.TabIndex = 1;
            this.ConfirmButton.Text = "ОК";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.Location = new System.Drawing.Point(764, 340);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(85, 32);
            this.CancelButton.TabIndex = 2;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ClientsSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(864, 385);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.ClientsDataGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ClientsSelectionForm";
            this.Text = "Выбор пунктов маршрута";
            ((System.ComponentModel.ISupportInitialize)(this.ClientsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
