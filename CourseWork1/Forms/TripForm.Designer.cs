using CourseWork1.DTOs;

namespace CourseWork1.Forms
{
    partial class TripForm
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
            this.RouteNameLabel = new System.Windows.Forms.Label();
            this.RepresentativeLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.StartDateLabel = new System.Windows.Forms.Label();
            this.EndDateLabel = new System.Windows.Forms.Label();
            this.TouristNumberLabel = new System.Windows.Forms.Label();
            this.PenaltyLabel = new System.Windows.Forms.Label();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.TouristNumberTextBox = new System.Windows.Forms.TextBox();
            this.PenaltyTextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ClientsDataGridView = new System.Windows.Forms.DataGridView();
            this.ClientId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientPatronymic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientBirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientPassport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemoveClientButton = new System.Windows.Forms.Button();
            this.AddClientButton = new System.Windows.Forms.Button();
            this.RouteNameComboBox = new System.Windows.Forms.ComboBox();
            this.RepresentativeComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // RouteNameLabel
            // 
            this.RouteNameLabel.AutoSize = true;
            this.RouteNameLabel.Location = new System.Drawing.Point(35, 42);
            this.RouteNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RouteNameLabel.Name = "RouteNameLabel";
            this.RouteNameLabel.Size = new System.Drawing.Size(142, 17);
            this.RouteNameLabel.TabIndex = 0;
            this.RouteNameLabel.Text = "Название маршрута";
            // 
            // RepresentativeLabel
            // 
            this.RepresentativeLabel.AutoSize = true;
            this.RepresentativeLabel.Location = new System.Drawing.Point(35, 79);
            this.RepresentativeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RepresentativeLabel.Name = "RepresentativeLabel";
            this.RepresentativeLabel.Size = new System.Drawing.Size(109, 17);
            this.RepresentativeLabel.TabIndex = 0;
            this.RepresentativeLabel.Text = "Представитель";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(35, 121);
            this.PriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(43, 17);
            this.PriceLabel.TabIndex = 0;
            this.PriceLabel.Text = "Цена";
            // 
            // StartDateLabel
            // 
            this.StartDateLabel.AutoSize = true;
            this.StartDateLabel.Location = new System.Drawing.Point(35, 162);
            this.StartDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StartDateLabel.Name = "StartDateLabel";
            this.StartDateLabel.Size = new System.Drawing.Size(94, 17);
            this.StartDateLabel.TabIndex = 0;
            this.StartDateLabel.Text = "Дата начала";
            // 
            // EndDateLabel
            // 
            this.EndDateLabel.AutoSize = true;
            this.EndDateLabel.Location = new System.Drawing.Point(35, 204);
            this.EndDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EndDateLabel.Name = "EndDateLabel";
            this.EndDateLabel.Size = new System.Drawing.Size(117, 17);
            this.EndDateLabel.TabIndex = 0;
            this.EndDateLabel.Text = "Дата окончания";
            // 
            // TouristNumberLabel
            // 
            this.TouristNumberLabel.AutoSize = true;
            this.TouristNumberLabel.Location = new System.Drawing.Point(35, 245);
            this.TouristNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TouristNumberLabel.Name = "TouristNumberLabel";
            this.TouristNumberLabel.Size = new System.Drawing.Size(149, 17);
            this.TouristNumberLabel.TabIndex = 0;
            this.TouristNumberLabel.Text = "Количество туристов";
            // 
            // PenaltyLabel
            // 
            this.PenaltyLabel.AutoSize = true;
            this.PenaltyLabel.Location = new System.Drawing.Point(35, 286);
            this.PenaltyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PenaltyLabel.Name = "PenaltyLabel";
            this.PenaltyLabel.Size = new System.Drawing.Size(78, 17);
            this.PenaltyLabel.TabIndex = 0;
            this.PenaltyLabel.Text = "Неустойка";
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(238, 118);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(171, 23);
            this.PriceTextBox.TabIndex = 1;
            // 
            // TouristNumberTextBox
            // 
            this.TouristNumberTextBox.Location = new System.Drawing.Point(238, 242);
            this.TouristNumberTextBox.Name = "TouristNumberTextBox";
            this.TouristNumberTextBox.Size = new System.Drawing.Size(171, 23);
            this.TouristNumberTextBox.TabIndex = 1;
            // 
            // PenaltyTextBox
            // 
            this.PenaltyTextBox.Location = new System.Drawing.Point(238, 283);
            this.PenaltyTextBox.Name = "PenaltyTextBox";
            this.PenaltyTextBox.Size = new System.Drawing.Size(171, 23);
            this.PenaltyTextBox.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(238, 162);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(171, 23);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(238, 199);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(171, 23);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelButton.Location = new System.Drawing.Point(377, 462);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(96, 37);
            this.CancelButton.TabIndex = 16;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButtonClick);
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveButton.Location = new System.Drawing.Point(235, 462);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(96, 37);
            this.SaveButton.TabIndex = 17;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButtonClick);
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
            this.ClientsDataGridView.Location = new System.Drawing.Point(483, 39);
            this.ClientsDataGridView.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.ClientsDataGridView.MultiSelect = false;
            this.ClientsDataGridView.Name = "ClientsDataGridView";
            this.ClientsDataGridView.ReadOnly = true;
            this.ClientsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ClientsDataGridView.Size = new System.Drawing.Size(979, 281);
            this.ClientsDataGridView.TabIndex = 18;
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
            // RemoveClientButton
            // 
            this.RemoveClientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RemoveClientButton.Location = new System.Drawing.Point(625, 346);
            this.RemoveClientButton.Name = "RemoveClientButton";
            this.RemoveClientButton.Size = new System.Drawing.Size(96, 37);
            this.RemoveClientButton.TabIndex = 19;
            this.RemoveClientButton.Text = "Убрать";
            this.RemoveClientButton.UseVisualStyleBackColor = true;
            this.RemoveClientButton.Click += new System.EventHandler(this.RemoveClientButtonClick);
            // 
            // AddClientButton
            // 
            this.AddClientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddClientButton.Location = new System.Drawing.Point(483, 346);
            this.AddClientButton.Name = "AddClientButton";
            this.AddClientButton.Size = new System.Drawing.Size(96, 37);
            this.AddClientButton.TabIndex = 20;
            this.AddClientButton.Text = "Добавить";
            this.AddClientButton.UseVisualStyleBackColor = true;
            this.AddClientButton.Click += new System.EventHandler(this.AddClientButtonClick);
            // 
            // RouteNameComboBox
            // 
            this.RouteNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RouteNameComboBox.FormattingEnabled = true;
            this.RouteNameComboBox.Location = new System.Drawing.Point(238, 42);
            this.RouteNameComboBox.Name = "RouteNameComboBox";
            this.RouteNameComboBox.Size = new System.Drawing.Size(171, 24);
            this.RouteNameComboBox.TabIndex = 21;
            // 
            // RepresentativeComboBox
            // 
            this.RepresentativeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RepresentativeComboBox.FormattingEnabled = true;
            this.RepresentativeComboBox.Location = new System.Drawing.Point(238, 76);
            this.RepresentativeComboBox.Name = "RepresentativeComboBox";
            this.RepresentativeComboBox.Size = new System.Drawing.Size(171, 24);
            this.RepresentativeComboBox.TabIndex = 21;
            // 
            // TripForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1528, 554);
            this.Controls.Add(this.RepresentativeComboBox);
            this.Controls.Add(this.RouteNameComboBox);
            this.Controls.Add(this.RemoveClientButton);
            this.Controls.Add(this.AddClientButton);
            this.Controls.Add(this.ClientsDataGridView);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.PenaltyTextBox);
            this.Controls.Add(this.TouristNumberTextBox);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.PenaltyLabel);
            this.Controls.Add(this.TouristNumberLabel);
            this.Controls.Add(this.EndDateLabel);
            this.Controls.Add(this.StartDateLabel);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.RepresentativeLabel);
            this.Controls.Add(this.RouteNameLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TripForm";
            this.Text = "TripForm";
            ((System.ComponentModel.ISupportInitialize)(this.ClientsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private void FillFormFields(TripDTO Trip)
        {
            id = Trip.Id;
            PriceTextBox.Text = Trip.Price.ToString();
            TouristNumberTextBox.Text = Trip.TouristNumber.ToString();
            PenaltyTextBox.Text = Trip.Penalty.ToString();
            dateTimePicker1.Value = Trip.StartDate;
            dateTimePicker2.Value = Trip.EndDate;
            RouteNameComboBox.Tag = Trip.RouteName;
            RouteNameComboBox.Text = Trip.RouteName;
            RepresentativeComboBox.Tag = Trip.Representative;
            RepresentativeComboBox.Text = Trip.Representative.GetName();
        }

        private System.Windows.Forms.Label RouteNameLabel;
        private System.Windows.Forms.Label RepresentativeLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label StartDateLabel;
        private System.Windows.Forms.Label EndDateLabel;
        private System.Windows.Forms.Label TouristNumberLabel;
        private System.Windows.Forms.Label PenaltyLabel;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.TextBox TouristNumberTextBox;
        private System.Windows.Forms.TextBox PenaltyTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.DataGridView ClientsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientPatronymic;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientBirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientPassport;
        private System.Windows.Forms.Button RemoveClientButton;
        private System.Windows.Forms.Button AddClientButton;
        private System.Windows.Forms.ComboBox RouteNameComboBox;
        private System.Windows.Forms.ComboBox RepresentativeComboBox;
        private long id;
    }
}