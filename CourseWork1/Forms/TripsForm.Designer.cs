using CourseWork1.DTOs;
using System.Collections.Generic;
using System.Drawing;
using System;
using System.Windows.Forms;

namespace CourseWork1.Forms
{
    partial class TripsForm
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
            this.TripsDataGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RouteName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Representative = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TouristNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Penalty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientsLabel = new System.Windows.Forms.Label();
            this.ClientsDataGridView = new System.Windows.Forms.DataGridView();
            this.ClientId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientPatronymic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientBirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientPassport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SearchButton = new System.Windows.Forms.Button();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.ButtonAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TripsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TripsDataGridView
            // 
            this.TripsDataGridView.AllowUserToAddRows = false;
            this.TripsDataGridView.AllowUserToDeleteRows = false;
            this.TripsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.TripsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.TripsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TripsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.RouteName,
            this.Representative,
            this.Price,
            this.StartDate,
            this.EndDate,
            this.TouristNumber,
            this.Penalty});
            this.TripsDataGridView.Location = new System.Drawing.Point(16, 15);
            this.TripsDataGridView.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.TripsDataGridView.MultiSelect = false;
            this.TripsDataGridView.Name = "TripsDataGridView";
            this.TripsDataGridView.ReadOnly = true;
            this.TripsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TripsDataGridView.Size = new System.Drawing.Size(982, 281);
            this.TripsDataGridView.TabIndex = 4;
            this.TripsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TripsDataGridView_SelectionChanged);
            this.TripsDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PenaltyPay);
            this.TripsDataGridView.Resize += MoveButtons;
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
            this.RouteName.HeaderText = "Название маршрута";
            this.RouteName.Name = "RouteName";
            this.RouteName.ReadOnly = true;
            this.RouteName.Width = 152;
            // 
            // Representative
            // 
            this.Representative.HeaderText = "Представитель";
            this.Representative.Name = "Representative";
            this.Representative.ReadOnly = true;
            this.Representative.Width = 134;
            // 
            // Price
            // 
            this.Price.HeaderText = "Цена";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 68;
            // 
            // StartDate
            // 
            this.StartDate.HeaderText = "Дата начала";
            this.StartDate.Name = "StartDate";
            this.StartDate.ReadOnly = true;
            this.StartDate.Width = 109;
            // 
            // EndDate
            // 
            this.EndDate.HeaderText = "Дата окончания";
            this.EndDate.Name = "EndDate";
            this.EndDate.ReadOnly = true;
            this.EndDate.Width = 130;
            // 
            // TouristNumber
            // 
            this.TouristNumber.HeaderText = "Количество туристов";
            this.TouristNumber.Name = "TouristNumber";
            this.TouristNumber.ReadOnly = true;
            this.TouristNumber.Width = 159;
            // 
            // Penalty
            // 
            this.Penalty.HeaderText = "Неустойка";
            this.Penalty.Name = "Penalty";
            this.Penalty.ReadOnly = true;
            this.Penalty.Width = 103;
            // 
            // ClientsLabel
            // 
            this.ClientsLabel.AutoSize = true;
            this.ClientsLabel.Location = new System.Drawing.Point(16, 346);
            this.ClientsLabel.Name = "ClientsLabel";
            this.ClientsLabel.Size = new System.Drawing.Size(272, 17);
            this.ClientsLabel.TabIndex = 5;
            this.ClientsLabel.Text = "Список клиентов выбранного маршрута";
            // 
            // ClientsDataGridView
            // 
            this.ClientsDataGridView.AllowUserToAddRows = false;
            this.ClientsDataGridView.AllowUserToDeleteRows = false;
            this.ClientsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.ClientsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.ClientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClientId,
            this.ClientLastName,
            this.ClientFirstName,
            this.ClientPatronymic,
            this.ClientBirthDate,
            this.ClientPassport});
            this.ClientsDataGridView.Location = new System.Drawing.Point(19, 379);
            this.ClientsDataGridView.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.ClientsDataGridView.MultiSelect = false;
            this.ClientsDataGridView.Name = "ClientsDataGridView";
            this.ClientsDataGridView.ReadOnly = true;
            this.ClientsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ClientsDataGridView.Size = new System.Drawing.Size(979, 281);
            this.ClientsDataGridView.TabIndex = 4;
            // 
            // ClientId
            // 
            this.ClientId.HeaderText = "Id";
            this.ClientId.Name = "ClientId";
            this.ClientId.ReadOnly = true;
            this.ClientId.Width = 44;
            // 
            // ClientLastName
            // 
            this.ClientLastName.HeaderText = "Фамилия";
            this.ClientLastName.Name = "ClientLastName";
            this.ClientLastName.ReadOnly = true;
            this.ClientLastName.Width = 95;
            // 
            // ClientFirstName
            // 
            this.ClientFirstName.HeaderText = "Имя";
            this.ClientFirstName.Name = "ClientFirstName";
            this.ClientFirstName.ReadOnly = true;
            this.ClientFirstName.Width = 60;
            // 
            // ClientPatronymic
            // 
            this.ClientPatronymic.HeaderText = "Отчество";
            this.ClientPatronymic.Name = "ClientPatronymic";
            this.ClientPatronymic.ReadOnly = true;
            this.ClientPatronymic.Width = 96;
            // 
            // ClientBirthDate
            // 
            this.ClientBirthDate.HeaderText = "Дата рождения";
            this.ClientBirthDate.Name = "ClientBirthDate";
            this.ClientBirthDate.ReadOnly = true;
            this.ClientBirthDate.Width = 124;
            // 
            // ClientPassport
            // 
            this.ClientPassport.HeaderText = "Паспорт";
            this.ClientPassport.Name = "ClientPassport";
            this.ClientPassport.ReadOnly = true;
            this.ClientPassport.Width = 89;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(1237, 179);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(4);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(187, 28);
            this.SearchButton.TabIndex = 27;
            this.SearchButton.Text = "Поиск по id";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.ButtonSearchClick);
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(1237, 126);
            this.IdTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(185, 23);
            this.IdTextBox.TabIndex = 26;
            this.IdTextBox.Text = "Введите id для поиска";
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(1009, 233);
            this.RefreshButton.Margin = new System.Windows.Forms.Padding(4);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(131, 63);
            this.RefreshButton.TabIndex = 22;
            this.RefreshButton.Text = "Обновить список";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.ButtonRefreshClick);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(1009, 162);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(131, 63);
            this.DeleteButton.TabIndex = 23;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.ButtonDeleteClick);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(1009, 86);
            this.EditButton.Margin = new System.Windows.Forms.Padding(4);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(131, 63);
            this.EditButton.TabIndex = 24;
            this.EditButton.Text = "Редактировать";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.ButtonEditClick);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(1009, 15);
            this.ButtonAdd.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(131, 63);
            this.ButtonAdd.TabIndex = 25;
            this.ButtonAdd.Text = "Добавить";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAddClick);
            // 
            // TripsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1572, 732);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.ClientsLabel);
            this.Controls.Add(this.ClientsDataGridView);
            this.Controls.Add(this.TripsDataGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TripsForm";
            this.Text = "TripsForm";
            ((System.ComponentModel.ISupportInitialize)(this.TripsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private void MoveButtons(object sender, EventArgs e)
        {
            ButtonAdd.Left = TripsDataGridView.Right + 15;
            EditButton.Left = TripsDataGridView.Right + 15;
            DeleteButton.Left = TripsDataGridView.Right + 15;
            RefreshButton.Left = TripsDataGridView.Right + 15;
            SearchButton.Left = TripsDataGridView.Right + 248;
            IdTextBox.Left = TripsDataGridView.Right + 248;
        }

        private void PenaltyPay(object sender, EventArgs e)
        {
            if (TripsDataGridView.SelectedRows.Count > 0)
            {
                var selectedRowIndex = TripsDataGridView.SelectedRows[0].Index;
                if (TripsDataGridView.Rows[selectedRowIndex].DefaultCellStyle.ForeColor == Color.Aquamarine)
                {
                    PenaltyUnpaid?.Invoke(sender, TripsDataGridView.Rows[selectedRowIndex].Tag as TripDTO);
                }
                else
                {
                    PenaltyPaid?.Invoke(sender, TripsDataGridView.Rows[selectedRowIndex].Tag as TripDTO);
                }

            }
        }

        private void TripsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (TripsDataGridView.SelectedRows.Count > 0)
            {
                var selectedRow = TripsDataGridView.SelectedRows[0];
                TripDTO trip = (TripDTO)selectedRow.Tag;
                TripSelected?.Invoke(this, trip);
            }
            else
            {
                ShowTourists(new List<ClientDTO>());
            }
        }

        private void ButtonAddClick(object sender, EventArgs e)
        {
            TripForm form = new TripForm();
            form.TripSubmitted += (s, trip) =>
            {
                try
                {
                    TripAdded?.Invoke(s, trip);
                    form.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            };
            form.ShowDialog();
            TripsDataGridView_SelectionChanged(sender, e);
        }

        private void ButtonEditClick(object sender, EventArgs e)
        {
            if (TripsDataGridView.SelectedRows.Count > 0)
            {
                var selectedRow = TripsDataGridView.SelectedRows[0];
                TripDTO tripDTO = selectedRow.Tag as TripDTO;
                TripForm form = new TripForm(tripDTO);
                form.TripSubmitted += (s, trip) =>
                {
                    try
                    {
                        TripUpdated?.Invoke(this, trip);
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

        private void ButtonDeleteClick(object sender, EventArgs e)
        {
            if (TripsDataGridView.SelectedRows.Count > 0)
            {
                TripDTO trip = TripsDataGridView.SelectedRows[0].Tag as TripDTO;
                TripDeleted?.Invoke(this, trip);
            }
        }

        private void ButtonRefreshClick(object sender, EventArgs e)
        {
            LoadTrips(sender, e);
        }

        private void ButtonSearchClick(object sender, EventArgs e)
        {
            long.TryParse(IdTextBox.Text, out long id);
            TripSearchRequested?.Invoke(sender, id);
            TripsDataGridView_SelectionChanged(sender, e);
        }

        private System.Windows.Forms.DataGridView TripsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn RouteName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Representative;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TouristNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Penalty;
        private System.Windows.Forms.Label ClientsLabel;
        private System.Windows.Forms.DataGridView ClientsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientPatronymic;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientBirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientPassport;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button ButtonAdd;
    }
}