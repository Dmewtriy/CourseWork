using CourseWork1.DTOs;
using CourseWork1.Interfaces;
using CourseWork1.Mappers;
using CourseWork1.Repositories;
using CourseWork1.Services.classes;
using CourseWork1.Services.interfaces;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CourseWork1.Forms
{
    partial class RouteForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DurationLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.DurationTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.CountryTextBox = new System.Windows.Forms.TextBox();
            this.CountryLabel = new System.Windows.Forms.Label();
            this.RemovePointButton = new System.Windows.Forms.Button();
            this.AddPointButton = new System.Windows.Forms.Button();
            this.PointsLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.PointsDataGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PointName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HotelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HotelClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.PointsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DurationLabel
            // 
            this.DurationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DurationLabel.Location = new System.Drawing.Point(27, 124);
            this.DurationLabel.Name = "DurationLabel";
            this.DurationLabel.Size = new System.Drawing.Size(117, 20);
            this.DurationLabel.TabIndex = 8;
            this.DurationLabel.Text = "Длительность";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(38, 82);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(72, 17);
            this.NameLabel.TabIndex = 9;
            this.NameLabel.Text = "Название";
            // 
            // DurationTextBox
            // 
            this.DurationTextBox.Location = new System.Drawing.Point(173, 123);
            this.DurationTextBox.Name = "DurationTextBox";
            this.DurationTextBox.Size = new System.Drawing.Size(200, 20);
            this.DurationTextBox.TabIndex = 6;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(173, 81);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(200, 20);
            this.NameTextBox.TabIndex = 7;
            // 
            // CountryTextBox
            // 
            this.CountryTextBox.Location = new System.Drawing.Point(173, 165);
            this.CountryTextBox.Name = "CountryTextBox";
            this.CountryTextBox.Size = new System.Drawing.Size(200, 20);
            this.CountryTextBox.TabIndex = 6;
            // 
            // CountryLabel
            // 
            this.CountryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountryLabel.Location = new System.Drawing.Point(27, 166);
            this.CountryLabel.Name = "CountryLabel";
            this.CountryLabel.Size = new System.Drawing.Size(117, 20);
            this.CountryLabel.TabIndex = 8;
            this.CountryLabel.Text = "Страна";
            // 
            // RemovePointButton
            // 
            this.RemovePointButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RemovePointButton.Location = new System.Drawing.Point(603, 277);
            this.RemovePointButton.Name = "RemovePointButton";
            this.RemovePointButton.Size = new System.Drawing.Size(96, 37);
            this.RemovePointButton.TabIndex = 12;
            this.RemovePointButton.Text = "Убрать";
            this.RemovePointButton.UseVisualStyleBackColor = true;
            this.RemovePointButton.Click += new System.EventHandler(this.RemovePointButtonClick);
            // 
            // AddPointButton
            // 
            this.AddPointButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddPointButton.Location = new System.Drawing.Point(461, 277);
            this.AddPointButton.Name = "AddPointButton";
            this.AddPointButton.Size = new System.Drawing.Size(96, 37);
            this.AddPointButton.TabIndex = 13;
            this.AddPointButton.Text = "Добавить";
            this.AddPointButton.UseVisualStyleBackColor = true;
            this.AddPointButton.Click += new System.EventHandler(this.AddPointButtonClick);
            // 
            // PointsLabel
            // 
            this.PointsLabel.AutoSize = true;
            this.PointsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PointsLabel.Location = new System.Drawing.Point(457, 8);
            this.PointsLabel.Name = "PointsLabel";
            this.PointsLabel.Size = new System.Drawing.Size(111, 17);
            this.PointsLabel.TabIndex = 10;
            this.PointsLabel.Text = "Список пунктов";
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelButton.Location = new System.Drawing.Point(319, 361);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(96, 37);
            this.CancelButton.TabIndex = 14;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButtonClick);
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveButton.Location = new System.Drawing.Point(177, 361);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(96, 37);
            this.SaveButton.TabIndex = 15;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButtonClick);
            // 
            // PointsDataGridView
            // 
            this.PointsDataGridView.AllowUserToAddRows = false;
            this.PointsDataGridView.AllowUserToDeleteRows = false;
            this.PointsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.PointsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PointsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.PointsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PointsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.PointName,
            this.Duration,
            this.HotelName,
            this.HotelClass});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PointsDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.PointsDataGridView.Location = new System.Drawing.Point(461, 29);
            this.PointsDataGridView.Margin = new System.Windows.Forms.Padding(5);
            this.PointsDataGridView.MultiSelect = false;
            this.PointsDataGridView.Name = "PointsDataGridView";
            this.PointsDataGridView.ReadOnly = true;
            this.PointsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PointsDataGridView.Size = new System.Drawing.Size(757, 228);
            this.PointsDataGridView.TabIndex = 16;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 44;
            // 
            // PointName
            // 
            this.PointName.HeaderText = "Название";
            this.PointName.Name = "PointName";
            this.PointName.ReadOnly = true;
            this.PointName.Width = 97;
            // 
            // Duration
            // 
            this.Duration.HeaderText = "Длительность пребывания";
            this.Duration.Name = "Duration";
            this.Duration.ReadOnly = true;
            this.Duration.Width = 193;
            // 
            // HotelName
            // 
            this.HotelName.HeaderText = "Название отеля";
            this.HotelName.Name = "HotelName";
            this.HotelName.ReadOnly = true;
            this.HotelName.Width = 128;
            // 
            // HotelClass
            // 
            this.HotelClass.HeaderText = "Класс отеля";
            this.HotelClass.Name = "HotelClass";
            this.HotelClass.ReadOnly = true;
            this.HotelClass.Width = 106;
            // 
            // RouteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 450);
            this.Controls.Add(this.PointsDataGridView);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.RemovePointButton);
            this.Controls.Add(this.AddPointButton);
            this.Controls.Add(this.PointsLabel);
            this.Controls.Add(this.CountryLabel);
            this.Controls.Add(this.DurationLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.CountryTextBox);
            this.Controls.Add(this.DurationTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Name = "RouteForm";
            this.Text = "RouteForm";
            ((System.ComponentModel.ISupportInitialize)(this.PointsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private void RemovePointButtonClick(object sender, EventArgs e)
        {
            if (PointsDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow row = PointsDataGridView.SelectedRows[0];
                PointsDataGridView.Rows.Remove(row);
            }
        }

        private void AddPointButtonClick(object sender, EventArgs e)
        {
            List<RoutePointDTO> availablePoints = LoadAvailablePoints();

            using (var selectionForm = new RoutePointsSelectionForm(availablePoints))
            {
                if (selectionForm.ShowDialog() == DialogResult.OK)
                {
                    foreach (var point in selectionForm.SelectedPoints)
                    {
                        if (!IsPointAlreadyAdded(point))
                        {
                            int index = PointsDataGridView.Rows.Add();
                            PointsDataGridView.Rows[index].Cells["Id"].Value = point.Id;
                            PointsDataGridView.Rows[index].Cells["PointName"].Value = point.Name;
                            PointsDataGridView.Rows[index].Cells["Duration"].Value = point.StayDuration;
                            PointsDataGridView.Rows[index].Cells["HotelName"].Value = point.HotelName;
                            PointsDataGridView.Rows[index].Cells["HotelClass"].Value = point.HotelClass;
                            PointsDataGridView.Rows[index].Tag = point;
                        }
                    }
                }
            }
        }

        private bool IsPointAlreadyAdded(RoutePointDTO point)
        {
            foreach (DataGridViewRow row in PointsDataGridView.Rows)
            {
                if ((row.Tag as RoutePointDTO)?.Id == point.Id)
                {
                    return true;
                }
            }
            return false;
        }

        private List<RoutePointDTO> LoadAvailablePoints()
        {
            IRepository<IRoutePoint> repo = new RoutePointJsonRepository("..\\..\\..\\data\\routePoints");
            IRoutePointService service = new RoutePointService(repo);
            var points = service.GetAllRoutePoints();
            var pointsDTO = new List<RoutePointDTO>();
            foreach (var point in points)
            {
                pointsDTO.Add(RoutePointMapper.ToDTO(point));
            }
            return pointsDTO;
        }

        private void SaveButtonClick(object sender, EventArgs e)
        {
            int.TryParse(DurationTextBox.Text, out int duration);
            RouteDTO route = new RouteDTO()
            {
                Id = id,
                Name = NameTextBox.Text,
                Country = CountryTextBox.Text,
                Duration = duration,
                Points = new List<RoutePointDTO>()
            };
            foreach(DataGridViewRow row in PointsDataGridView.Rows)
            {
                route.Points.Add(row.Tag as RoutePointDTO);
            }
            RouteSubmitted?.Invoke(sender, route);
        }

        private void CancelButtonClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void FillFormFields(RouteDTO route)
        {
            id = route.Id;
            NameTextBox.Text = route.Name;
            CountryTextBox.Text = route.Country;
            DurationTextBox.Text = route.Duration.ToString();
            foreach (RoutePointDTO point in route.Points)
            {
                int index = PointsDataGridView.Rows.Add();
                PointsDataGridView.Rows[index].Cells["Id"].Value = point.Id;
                PointsDataGridView.Rows[index].Cells["PointName"].Value = point.Name;
                PointsDataGridView.Rows[index].Cells["Duration"].Value = point.StayDuration;
                PointsDataGridView.Rows[index].Cells["HotelName"].Value = point.HotelName;
                PointsDataGridView.Rows[index].Cells["HotelClass"].Value = point.HotelClass;
                PointsDataGridView.Rows[index].Tag = point;
            }
        }

        private System.Windows.Forms.Label DurationLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox DurationTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox CountryTextBox;
        private System.Windows.Forms.Label CountryLabel;
        private System.Windows.Forms.Button RemovePointButton;
        private System.Windows.Forms.Button AddPointButton;
        private System.Windows.Forms.Label PointsLabel;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.DataGridView PointsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn PointName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn HotelName;
        private System.Windows.Forms.DataGridViewTextBoxColumn HotelClass;
        private long id;
    }
}