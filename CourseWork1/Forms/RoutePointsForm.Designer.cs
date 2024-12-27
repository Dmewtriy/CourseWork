using CourseWork1.DTOs;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CourseWork1.Forms
{
    partial class RoutePointsForm
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
            this.PointsDataGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PointName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HotelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HotelClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExcursionsLabel = new System.Windows.Forms.Label();
            this.ExcursionsDataGridView = new System.Windows.Forms.DataGridView();
            this.ExId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SearchButton = new System.Windows.Forms.Button();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.ButtonAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PointsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExcursionsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PointsDataGridView
            // 
            this.PointsDataGridView.AllowUserToAddRows = false;
            this.PointsDataGridView.AllowUserToDeleteRows = false;
            this.PointsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.PointsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.PointsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PointsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.PointName,
            this.Duration,
            this.HotelName,
            this.HotelClass});
            this.PointsDataGridView.Location = new System.Drawing.Point(14, 32);
            this.PointsDataGridView.Margin = new System.Windows.Forms.Padding(5);
            this.PointsDataGridView.MultiSelect = false;
            this.PointsDataGridView.Name = "PointsDataGridView";
            this.PointsDataGridView.ReadOnly = true;
            this.PointsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PointsDataGridView.Size = new System.Drawing.Size(757, 228);
            this.PointsDataGridView.TabIndex = 2;
            this.PointsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PointsDataGridView_SelectionChanged);
            this.PointsDataGridView.Resize += new System.EventHandler(this.MoveExcursions);
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
            // ExcursionsLabel
            // 
            this.ExcursionsLabel.AutoSize = true;
            this.ExcursionsLabel.Location = new System.Drawing.Point(814, 13);
            this.ExcursionsLabel.Name = "ExcursionsLabel";
            this.ExcursionsLabel.Size = new System.Drawing.Size(76, 17);
            this.ExcursionsLabel.TabIndex = 3;
            this.ExcursionsLabel.Text = "Экскурсии";
            // 
            // ExcursionsDataGridView
            // 
            this.ExcursionsDataGridView.AllowUserToAddRows = false;
            this.ExcursionsDataGridView.AllowUserToDeleteRows = false;
            this.ExcursionsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.ExcursionsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.ExcursionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExcursionsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ExId,
            this.ExName});
            this.ExcursionsDataGridView.Location = new System.Drawing.Point(817, 34);
            this.ExcursionsDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.ExcursionsDataGridView.MultiSelect = false;
            this.ExcursionsDataGridView.Name = "ExcursionsDataGridView";
            this.ExcursionsDataGridView.ReadOnly = true;
            this.ExcursionsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ExcursionsDataGridView.Size = new System.Drawing.Size(487, 185);
            this.ExcursionsDataGridView.TabIndex = 7;
            // 
            // ExId
            // 
            this.ExId.HeaderText = "Id";
            this.ExId.Name = "ExId";
            this.ExId.ReadOnly = true;
            this.ExId.Width = 44;
            // 
            // ExName
            // 
            this.ExName.HeaderText = "Название";
            this.ExName.Name = "ExName";
            this.ExName.ReadOnly = true;
            this.ExName.Width = 97;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(675, 497);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(4);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(187, 28);
            this.SearchButton.TabIndex = 15;
            this.SearchButton.Text = "Поиск по id";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.ButtonSearchClick);
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(675, 464);
            this.IdTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(185, 23);
            this.IdTextBox.TabIndex = 14;
            this.IdTextBox.Text = "Введите id для поиска";
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(430, 464);
            this.RefreshButton.Margin = new System.Windows.Forms.Padding(4);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(131, 63);
            this.RefreshButton.TabIndex = 10;
            this.RefreshButton.Text = "Обновить список";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.ButtonRefreshClick);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(291, 464);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(131, 63);
            this.DeleteButton.TabIndex = 11;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.ButtonDeleteClick);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(153, 464);
            this.EditButton.Margin = new System.Windows.Forms.Padding(4);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(131, 63);
            this.EditButton.TabIndex = 12;
            this.EditButton.Text = "Редактировать";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.ButtonEditClick);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(14, 464);
            this.ButtonAdd.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(131, 63);
            this.ButtonAdd.TabIndex = 13;
            this.ButtonAdd.Text = "Добавить";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAddClick);
            // 
            // RoutePointsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 554);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.ExcursionsDataGridView);
            this.Controls.Add(this.ExcursionsLabel);
            this.Controls.Add(this.PointsDataGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RoutePointsForm";
            this.Text = "Пункты маршрутов";
            ((System.ComponentModel.ISupportInitialize)(this.PointsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExcursionsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private void PointsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if(PointsDataGridView.SelectedRows.Count > 0) 
            {
                var selectedRow = PointsDataGridView.SelectedRows[0];
                RoutePointDTO point = (RoutePointDTO)selectedRow.Tag;
                RoutePointSelected?.Invoke(this, point);
            }
            else
            {
                ShowExcursions(new List<ExcursionDTO>());
            }
        }
        private void MoveExcursions(object sender, EventArgs e)
        {
            ExcursionsDataGridView.Left = PointsDataGridView.Right + 15;
        }

        private void ButtonAddClick(object sender, EventArgs e)
        {
            RoutePointForm form = new RoutePointForm();
            form.RoutePointSubmitted += (s, point) =>
            {
                try
                {
                    RoutePointAdded?.Invoke(s, point);
                    form.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            };
            form.ShowDialog();
            PointsDataGridView_SelectionChanged(sender, e);
        }

        private void ButtonEditClick(object sender, EventArgs e)
        {
            if(PointsDataGridView.SelectedRows.Count > 0)
            {
                var selectedRow = PointsDataGridView.SelectedRows[0];
                RoutePointDTO pointDTO = (RoutePointDTO)selectedRow.Tag;
                RoutePointForm form = new RoutePointForm(pointDTO);
                form.RoutePointSubmitted += (s, point) =>
                {
                    try
                    {
                        RoutePointUpdated?.Invoke(s, point);
                        form.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                };
                form.ShowDialog();
            }
        }

        private void ButtonDeleteClick(object sender, EventArgs e)
        {
            if (PointsDataGridView.SelectedRows.Count > 0)
            {
                RoutePointDTO point = PointsDataGridView.SelectedRows[0].Tag as RoutePointDTO;
                RoutePointDeleted?.Invoke(this, point);
            }
        }

        private void ButtonRefreshClick(object sender, EventArgs e)
        {
            LoadPoints(sender, e);
        }

        private void ButtonSearchClick(object sender, EventArgs e)
        {
            long.TryParse(IdTextBox.Text, out long id);
            RoutePointSearchRequested?.Invoke(sender, id);
            PointsDataGridView_SelectionChanged(sender, e);
        }


        private System.Windows.Forms.DataGridView PointsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn PointName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn HotelName;
        private System.Windows.Forms.DataGridViewTextBoxColumn HotelClass;
        private System.Windows.Forms.Label ExcursionsLabel;
        private System.Windows.Forms.DataGridView ExcursionsDataGridView;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button ButtonAdd;
        private DataGridViewTextBoxColumn ExId;
        private DataGridViewTextBoxColumn ExName;
    }
}