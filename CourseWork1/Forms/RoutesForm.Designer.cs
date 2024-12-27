using CourseWork1.DTOs;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CourseWork1.Forms
{
    partial class RoutesForm
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
            this.RoutesDataGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RouteName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PointsLabel = new System.Windows.Forms.Label();
            this.PointsDataGridView = new System.Windows.Forms.DataGridView();
            this.PointId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PointName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PointDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HotelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HotelClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SearchButton = new System.Windows.Forms.Button();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.ButtonAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RoutesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PointsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // RoutesDataGridView
            // 
            this.RoutesDataGridView.AllowUserToAddRows = false;
            this.RoutesDataGridView.AllowUserToDeleteRows = false;
            this.RoutesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.RoutesDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.RoutesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RoutesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.RouteName,
            this.Duration,
            this.Country});
            this.RoutesDataGridView.Location = new System.Drawing.Point(16, 25);
            this.RoutesDataGridView.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.RoutesDataGridView.MultiSelect = false;
            this.RoutesDataGridView.Name = "RoutesDataGridView";
            this.RoutesDataGridView.ReadOnly = true;
            this.RoutesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RoutesDataGridView.Size = new System.Drawing.Size(527, 281);
            this.RoutesDataGridView.TabIndex = 3;
            this.RoutesDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RoutesDataGridView_SelectionChanged);
            this.RoutesDataGridView.Resize += new System.EventHandler(this.MovePoints);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 44;
            // 
            // RouteName
            // 
            this.RouteName.HeaderText = "Название";
            this.RouteName.Name = "RouteName";
            this.RouteName.ReadOnly = true;
            this.RouteName.Width = 97;
            // 
            // Duration
            // 
            this.Duration.HeaderText = "Длительность";
            this.Duration.Name = "Duration";
            this.Duration.ReadOnly = true;
            this.Duration.Width = 127;
            // 
            // Country
            // 
            this.Country.HeaderText = "Страна";
            this.Country.Name = "Country";
            this.Country.ReadOnly = true;
            this.Country.Width = 81;
            // 
            // PointsLabel
            // 
            this.PointsLabel.AutoSize = true;
            this.PointsLabel.Location = new System.Drawing.Point(579, 4);
            this.PointsLabel.Name = "PointsLabel";
            this.PointsLabel.Size = new System.Drawing.Size(209, 17);
            this.PointsLabel.TabIndex = 8;
            this.PointsLabel.Text = "Пункты выбранного маршрута";
            // 
            // PointsDataGridView
            // 
            this.PointsDataGridView.AllowUserToAddRows = false;
            this.PointsDataGridView.AllowUserToDeleteRows = false;
            this.PointsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.PointsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.PointsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PointsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PointId,
            this.PointName,
            this.PointDuration,
            this.HotelName,
            this.HotelClass});
            this.PointsDataGridView.Location = new System.Drawing.Point(582, 25);
            this.PointsDataGridView.Margin = new System.Windows.Forms.Padding(5);
            this.PointsDataGridView.MultiSelect = false;
            this.PointsDataGridView.Name = "PointsDataGridView";
            this.PointsDataGridView.ReadOnly = true;
            this.PointsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PointsDataGridView.Size = new System.Drawing.Size(757, 281);
            this.PointsDataGridView.TabIndex = 9;
            // 
            // PointId
            // 
            this.PointId.HeaderText = "Id";
            this.PointId.Name = "PointId";
            this.PointId.ReadOnly = true;
            this.PointId.Width = 44;
            // 
            // PointName
            // 
            this.PointName.HeaderText = "Название";
            this.PointName.Name = "PointName";
            this.PointName.ReadOnly = true;
            this.PointName.Width = 97;
            // 
            // PointDuration
            // 
            this.PointDuration.HeaderText = "Длительность пребывания";
            this.PointDuration.Name = "PointDuration";
            this.PointDuration.ReadOnly = true;
            this.PointDuration.Width = 193;
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
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(683, 481);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(4);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(187, 28);
            this.SearchButton.TabIndex = 21;
            this.SearchButton.Text = "Поиск по id";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButtonClick);
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(683, 448);
            this.IdTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(185, 23);
            this.IdTextBox.TabIndex = 20;
            this.IdTextBox.Text = "Введите id для поиска";
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(438, 448);
            this.RefreshButton.Margin = new System.Windows.Forms.Padding(4);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(131, 63);
            this.RefreshButton.TabIndex = 16;
            this.RefreshButton.Text = "Обновить список";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButtonClick);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(299, 448);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(131, 63);
            this.DeleteButton.TabIndex = 17;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButtonClick);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(161, 448);
            this.EditButton.Margin = new System.Windows.Forms.Padding(4);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(131, 63);
            this.EditButton.TabIndex = 18;
            this.EditButton.Text = "Редактировать";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButtonClick);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(22, 448);
            this.ButtonAdd.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(131, 63);
            this.ButtonAdd.TabIndex = 19;
            this.ButtonAdd.Text = "Добавить";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAddClick);
            // 
            // RoutesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 554);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.PointsDataGridView);
            this.Controls.Add(this.PointsLabel);
            this.Controls.Add(this.RoutesDataGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RoutesForm";
            this.Text = "Маршруты";
            ((System.ComponentModel.ISupportInitialize)(this.RoutesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PointsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private void ButtonAddClick(object sender, EventArgs e)
        {
            RouteForm form = new RouteForm();
            form.RouteSubmitted += (s, route) =>
            {
                try
                {
                    RouteAdded?.Invoke(s, route);
                    form.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            };
            form.ShowDialog();
            RoutesDataGridView_SelectionChanged(sender, e);
        }

        private void EditButtonClick(object sender, EventArgs e)
        {
            if (RoutesDataGridView.SelectedRows.Count > 0)
            {
                var selectedRow = RoutesDataGridView.SelectedRows[0];
                RouteDTO routeDTO = selectedRow.Tag as RouteDTO;
                RouteForm form = new RouteForm(routeDTO);
                form.RouteSubmitted += (s, route) =>
                {
                    try
                    {
                        RouteUpdated?.Invoke(this, route);
                        form.Close();
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message);
                    }
                };
                form.ShowDialog();
            }
        }

        private void DeleteButtonClick(object sender, EventArgs e)
        {
            if (RoutesDataGridView.SelectedRows.Count > 0)
            {
                RouteDTO route = RoutesDataGridView.SelectedRows[0].Tag as RouteDTO;
                RouteDeleted?.Invoke(this, route);
            }
        }

        private void RefreshButtonClick(object sender, EventArgs e)
        {
            LoadRoutes(sender, e);
        }

        private void SearchButtonClick(object sender, EventArgs e)
        {
            long.TryParse(IdTextBox.Text, out long id);
            RouteSearchRequested?.Invoke(sender, id);
            RoutesDataGridView_SelectionChanged(sender, e);
        }

        private void RoutesDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (RoutesDataGridView.SelectedRows.Count > 0)
            {
                var selectedRow = RoutesDataGridView.SelectedRows[0];
                RouteDTO route = (RouteDTO)selectedRow.Tag;
                RouteSelected?.Invoke(this, route);
            }
            else
            {
                ShowRoutePoints(new List<RoutePointDTO>());
            }
        }

        private void MovePoints(object sender, EventArgs e)
        {
            PointsDataGridView.Left = RoutesDataGridView.Right + 15;
        }

        private System.Windows.Forms.DataGridView RoutesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn RouteName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn Country;
        private System.Windows.Forms.Label PointsLabel;
        private System.Windows.Forms.DataGridView PointsDataGridView;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button ButtonAdd;
        private DataGridViewTextBoxColumn PointId;
        private DataGridViewTextBoxColumn PointName;
        private DataGridViewTextBoxColumn PointDuration;
        private DataGridViewTextBoxColumn HotelName;
        private DataGridViewTextBoxColumn HotelClass;
    }
}