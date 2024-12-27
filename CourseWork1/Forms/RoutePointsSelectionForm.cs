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
    public partial class RoutePointsSelectionForm : Form
    {
        public List<RoutePointDTO> SelectedPoints { get; private set; } = new List<RoutePointDTO>();

        public RoutePointsSelectionForm(List<RoutePointDTO> availableRoutePoints)
        {
            InitializeComponent();
            ConfigureDataGridView();

            foreach (var RoutePoint in availableRoutePoints)
            {
                int index = RoutePointsDataGridView.Rows.Add();
                RoutePointsDataGridView.Rows[index].Cells["IdColumn"].Value = RoutePoint.Id;
                RoutePointsDataGridView.Rows[index].Cells["NameColumn"].Value = RoutePoint.Name;
                RoutePointsDataGridView.Rows[index].Cells["DurationColumn"].Value = RoutePoint.StayDuration;
                RoutePointsDataGridView.Rows[index].Cells["HotelNameColumn"].Value = RoutePoint.HotelName;
                RoutePointsDataGridView.Rows[index].Cells["HotelClassColumn"].Value = RoutePoint.HotelClass;
                RoutePointsDataGridView.Rows[index].Tag = RoutePoint;
            }
        }

        private void ConfigureDataGridView()
        {
            RoutePointsDataGridView.Columns.Clear();

            var selectColumn = new DataGridViewCheckBoxColumn
            {
                Name = "SelectColumn",
                HeaderText = "Выбрать",
                Width = 55,
            };
            RoutePointsDataGridView.Columns.Add(selectColumn);

            var idColumn = new DataGridViewTextBoxColumn
            {
                Name = "IdColumn",
                HeaderText = "ID",
                ReadOnly = true,
            };
            RoutePointsDataGridView.Columns.Add(idColumn);

            var nameColumn = new DataGridViewTextBoxColumn
            {
                Name = "NameColumn",
                HeaderText = "Название экскурсии",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                ReadOnly = true,
            };
            RoutePointsDataGridView.Columns.Add(nameColumn);

            var durationColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Продолжительность (дней)",
                Name = "DurationColumn",
                ReadOnly = true
            };
            RoutePointsDataGridView.Columns.Add(durationColumn);

            var hotelNameColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Название отеля",
                Name = "HotelNameColumn",
                ReadOnly = true
            };
            RoutePointsDataGridView.Columns.Add(hotelNameColumn);

            var hotelClassColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Класс отеля",
                Name = "HotelClassColumn",
                ReadOnly = true
            };
            RoutePointsDataGridView.Columns.Add(hotelClassColumn);

        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            SelectedPoints.Clear();

            foreach (DataGridViewRow row in RoutePointsDataGridView.Rows)
            {
                var isSelected = row.Cells["SelectColumn"] as DataGridViewCheckBoxCell;
                if (isSelected != null && Convert.ToBoolean(isSelected.Value) == true)
                {
                    SelectedPoints.Add(row.Tag as RoutePointDTO);
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

        private DataGridView RoutePointsDataGridView;
        private Button ConfirmButton;
        private Button CancelButton;

        private void InitializeComponent()
        {
            this.RoutePointsDataGridView = new System.Windows.Forms.DataGridView();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RoutePointsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // RoutePointsDataGridView
            // 
            this.RoutePointsDataGridView.AllowUserToAddRows = false;
            this.RoutePointsDataGridView.AllowUserToDeleteRows = false;
            this.RoutePointsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RoutePointsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.RoutePointsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.RoutePointsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RoutePointsDataGridView.Location = new System.Drawing.Point(13, 12);
            this.RoutePointsDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.RoutePointsDataGridView.Name = "RoutePointsDataGridView";
            this.RoutePointsDataGridView.RowHeadersVisible = false;
            this.RoutePointsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RoutePointsDataGridView.Size = new System.Drawing.Size(836, 320);
            this.RoutePointsDataGridView.TabIndex = 0;
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
            // RoutePointsSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(864, 385);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.RoutePointsDataGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RoutePointsSelectionForm";
            this.Text = "Выбор пунктов маршрута";
            ((System.ComponentModel.ISupportInitialize)(this.RoutePointsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}

