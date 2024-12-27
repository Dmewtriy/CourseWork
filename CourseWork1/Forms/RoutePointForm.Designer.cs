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
    partial class RoutePointForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.DurationTextBox = new System.Windows.Forms.TextBox();
            this.DurationLabel = new System.Windows.Forms.Label();
            this.HotelNameTextBox = new System.Windows.Forms.TextBox();
            this.HotelNameLabel = new System.Windows.Forms.Label();
            this.HotelClassTextBox = new System.Windows.Forms.TextBox();
            this.HotelClassLabel = new System.Windows.Forms.Label();
            this.ExcursionsLabel = new System.Windows.Forms.Label();
            this.ExcursionsDataGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.AddExcursionButton = new System.Windows.Forms.Button();
            this.RemoveExcursionButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ExcursionsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(45, 62);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(72, 17);
            this.NameLabel.TabIndex = 5;
            this.NameLabel.Text = "Название";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(227, 61);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(200, 20);
            this.NameTextBox.TabIndex = 4;
            // 
            // DurationTextBox
            // 
            this.DurationTextBox.Location = new System.Drawing.Point(227, 104);
            this.DurationTextBox.Name = "DurationTextBox";
            this.DurationTextBox.Size = new System.Drawing.Size(200, 20);
            this.DurationTextBox.TabIndex = 4;
            // 
            // DurationLabel
            // 
            this.DurationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DurationLabel.Location = new System.Drawing.Point(34, 95);
            this.DurationLabel.Name = "DurationLabel";
            this.DurationLabel.Size = new System.Drawing.Size(187, 39);
            this.DurationLabel.TabIndex = 5;
            this.DurationLabel.Text = "Длительность пребывания (в днях)";
            // 
            // HotelNameTextBox
            // 
            this.HotelNameTextBox.Location = new System.Drawing.Point(227, 151);
            this.HotelNameTextBox.Name = "HotelNameTextBox";
            this.HotelNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.HotelNameTextBox.TabIndex = 4;
            // 
            // HotelNameLabel
            // 
            this.HotelNameLabel.AutoSize = true;
            this.HotelNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HotelNameLabel.Location = new System.Drawing.Point(45, 152);
            this.HotelNameLabel.Name = "HotelNameLabel";
            this.HotelNameLabel.Size = new System.Drawing.Size(115, 17);
            this.HotelNameLabel.TabIndex = 5;
            this.HotelNameLabel.Text = "Название отеля";
            // 
            // HotelClassTextBox
            // 
            this.HotelClassTextBox.Location = new System.Drawing.Point(227, 210);
            this.HotelClassTextBox.Name = "HotelClassTextBox";
            this.HotelClassTextBox.Size = new System.Drawing.Size(200, 20);
            this.HotelClassTextBox.TabIndex = 4;
            // 
            // HotelClassLabel
            // 
            this.HotelClassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HotelClassLabel.Location = new System.Drawing.Point(45, 201);
            this.HotelClassLabel.Name = "HotelClassLabel";
            this.HotelClassLabel.Size = new System.Drawing.Size(154, 41);
            this.HotelClassLabel.TabIndex = 5;
            this.HotelClassLabel.Text = "Класс отеля (количество звёзд)";
            // 
            // ExcursionsLabel
            // 
            this.ExcursionsLabel.AutoSize = true;
            this.ExcursionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExcursionsLabel.Location = new System.Drawing.Point(489, 20);
            this.ExcursionsLabel.Name = "ExcursionsLabel";
            this.ExcursionsLabel.Size = new System.Drawing.Size(125, 17);
            this.ExcursionsLabel.TabIndex = 5;
            this.ExcursionsLabel.Text = "Список экскурсий";
            // 
            // ExcursionsDataGridView
            // 
            this.ExcursionsDataGridView.AllowUserToAddRows = false;
            this.ExcursionsDataGridView.AllowUserToDeleteRows = false;
            this.ExcursionsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.ExcursionsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ExcursionsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ExcursionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExcursionsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ExName});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ExcursionsDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.ExcursionsDataGridView.Location = new System.Drawing.Point(492, 62);
            this.ExcursionsDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.ExcursionsDataGridView.MultiSelect = false;
            this.ExcursionsDataGridView.Name = "ExcursionsDataGridView";
            this.ExcursionsDataGridView.ReadOnly = true;
            this.ExcursionsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ExcursionsDataGridView.Size = new System.Drawing.Size(415, 185);
            this.ExcursionsDataGridView.TabIndex = 6;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Id.Width = 25;
            // 
            // ExName
            // 
            this.ExName.HeaderText = "Название";
            this.ExName.Name = "ExName";
            this.ExName.ReadOnly = true;
            this.ExName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ExName.Width = 78;
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelButton.Location = new System.Drawing.Point(369, 372);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(96, 37);
            this.CancelButton.TabIndex = 7;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButtonClick);
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveButton.Location = new System.Drawing.Point(227, 372);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(96, 37);
            this.SaveButton.TabIndex = 8;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButtonClick);
            // 
            // AddExcursionButton
            // 
            this.AddExcursionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddExcursionButton.Location = new System.Drawing.Point(493, 277);
            this.AddExcursionButton.Name = "AddExcursionButton";
            this.AddExcursionButton.Size = new System.Drawing.Size(96, 37);
            this.AddExcursionButton.TabIndex = 8;
            this.AddExcursionButton.Text = "Добавить";
            this.AddExcursionButton.UseVisualStyleBackColor = true;
            this.AddExcursionButton.Click += new System.EventHandler(this.AddExcursionButtonClick);
            // 
            // RemoveExcursionButton
            // 
            this.RemoveExcursionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RemoveExcursionButton.Location = new System.Drawing.Point(635, 277);
            this.RemoveExcursionButton.Name = "RemoveExcursionButton";
            this.RemoveExcursionButton.Size = new System.Drawing.Size(96, 37);
            this.RemoveExcursionButton.TabIndex = 7;
            this.RemoveExcursionButton.Text = "Убрать";
            this.RemoveExcursionButton.UseVisualStyleBackColor = true;
            this.RemoveExcursionButton.Click += new System.EventHandler(this.RemoveExcursionButtonClick);
            // 
            // RoutePointForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 450);
            this.Controls.Add(this.RemoveExcursionButton);
            this.Controls.Add(this.AddExcursionButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ExcursionsDataGridView);
            this.Controls.Add(this.DurationLabel);
            this.Controls.Add(this.HotelClassLabel);
            this.Controls.Add(this.HotelNameLabel);
            this.Controls.Add(this.ExcursionsLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.DurationTextBox);
            this.Controls.Add(this.HotelClassTextBox);
            this.Controls.Add(this.HotelNameTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Name = "RoutePointForm";
            this.Text = "RoutePointForm";
            ((System.ComponentModel.ISupportInitialize)(this.ExcursionsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private void FillFormFields(RoutePointDTO point)
        {
            id = point.Id;
            NameTextBox.Text = point.Name;
            HotelNameTextBox.Text = point.HotelName;
            DurationTextBox.Text = point.StayDuration.ToString();
            HotelClassTextBox.Text = point.HotelClass.ToString();
            foreach(ExcursionDTO ex in point.Excursions)
            {
                int index = ExcursionsDataGridView.Rows.Add();
                ExcursionsDataGridView.Rows[index].Cells["Id"].Value = ex.Id;
                ExcursionsDataGridView.Rows[index].Cells["ExName"].Value = ex.Name;
                ExcursionsDataGridView.Rows[index].Tag = ex;
            }
        }

        private void AddExcursionButtonClick(object sender, EventArgs e)
        {
            List<ExcursionDTO> availableExcursions = LoadAvailableExcursions();

            using (var selectionForm = new ExcursionSelectionForm(availableExcursions))
            {
                if (selectionForm.ShowDialog() == DialogResult.OK)
                {
                    foreach (var excursion in selectionForm.SelectedExcursions)
                    {
                        if (!IsExcursionAlreadyAdded(excursion))
                        {
                            int index = ExcursionsDataGridView.Rows.Add();
                            ExcursionsDataGridView.Rows[index].Cells["Id"].Value = excursion.Id;
                            ExcursionsDataGridView.Rows[index].Cells["ExName"].Value = excursion.Name;
                            ExcursionsDataGridView.Rows[index].Tag = excursion;
                        }
                    }
                }
            }
        }

        private bool IsExcursionAlreadyAdded(ExcursionDTO excursion)
        {
            foreach (DataGridViewRow row in ExcursionsDataGridView.Rows)
            {
                if ((row.Tag as ExcursionDTO)?.Id == excursion.Id)
                {
                    return true;
                }
            }
            return false;
        }

        private List<ExcursionDTO> LoadAvailableExcursions()
        {
            IRepository<IExcursion> repo = new ExcursionJsonRepository("..\\..\\..\\data\\excursions");
            IExcursionService service = new ExcursionService(repo);
            var Excursions = service.GetAllExcursions();
            var ExcursionsDTO = new List<ExcursionDTO>();
            foreach (var Excursion in Excursions)
            {
                ExcursionsDTO.Add(ExcursionMapper.ToDTO(Excursion));
            }
            return ExcursionsDTO;
        }

        private void RemoveExcursionButtonClick(object sender, EventArgs e)
        {
            if(ExcursionsDataGridView.SelectedRows.Count > 0) 
            {
                DataGridViewRow row = ExcursionsDataGridView.SelectedRows[0];
                ExcursionsDataGridView.Rows.Remove(row);
            }
        }

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox DurationTextBox;
        private System.Windows.Forms.Label DurationLabel;
        private System.Windows.Forms.TextBox HotelNameTextBox;
        private System.Windows.Forms.Label HotelNameLabel;
        private System.Windows.Forms.TextBox HotelClassTextBox;
        private System.Windows.Forms.Label HotelClassLabel;
        private System.Windows.Forms.Label ExcursionsLabel;
        private System.Windows.Forms.DataGridView ExcursionsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExName;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button AddExcursionButton;
        private System.Windows.Forms.Button RemoveExcursionButton;
        private long id;
    }
}