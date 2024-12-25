using CourseWork1.DTOs;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CourseWork1.Forms
{
    partial class ClientForm
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
        private TextBox txtFirstName;
        private Label lblFirstName;
        private TextBox txtLastName;
        private Label lblLastName;
        private TextBox txtPatronymic;
        private Label lblPatronymic;
        private DateTimePicker dtpBirthDate;
        private Label lblBirthDate;
        private TextBox txtPassportSeries;
        private Label lblPassportSeries;
        private TextBox txtPassportNumber;
        private Label lblPassportNumber;
        private DateTimePicker dtpPassportIssuedDate;
        private Label lblPassportIssuedDate;
        private TextBox txtPassportIssuedBy;
        private Label lblPassportIssuedBy;
        private Button btnAddPhoto;
        private Button btnSave;
        private Button btnCancel;
        private PictureBox pictureBox;
        private long id;
        private void InitializeComponent()
        {
            Width = 650;
            Height = 500;

            this.txtFirstName = new TextBox() { Top = 60, Left = 130, Width = 200 };
            this.lblFirstName = new Label() { Top = 60, Left = 20, Text = "Имя:" };

            this.txtLastName = new TextBox() { Top = 20, Left = 130, Width = 200 };
            this.lblLastName = new Label() { Top = 20, Left = 20, Text = "Фамилия:" };

            this.txtPatronymic = new TextBox() { Top = 100, Left = 130, Width = 200 };
            this.lblPatronymic = new Label() { Top = 100, Left = 20, Text = "Отчество:" };

            this.dtpBirthDate = new DateTimePicker() { Top = 140, Left = 130, Width = 200 };
            this.lblBirthDate = new Label() { Top = 140, Left = 20, Text = "Дата рождения:" };

            this.txtPassportSeries = new TextBox() { Top = 180, Left = 130, Width = 200 };
            this.lblPassportSeries = new Label() { Top = 180, Left = 20, Text = "Серия паспорта:" };

            this.txtPassportNumber = new TextBox() { Top = 220, Left = 130, Width = 200 };
            this.lblPassportNumber = new Label() { Top = 220, Left = 20, Text = "Номер паспорта:" };

            this.dtpPassportIssuedDate = new DateTimePicker() { Top = 260, Left = 130, Width = 200 };
            this.lblPassportIssuedDate = new Label() { Top = 260, Left = 20, Text = "Дата выдачи паспорта:" };

            this.txtPassportIssuedBy = new TextBox() { Top = 300, Left = 130, Width = 200 };
            this.lblPassportIssuedBy = new Label() { Top = 300, Left = 20, Text = "Кем выдан:" };

            this.btnAddPhoto = new Button() { Top = 260, Left = 375, Text = "Добавить фото", Width = 200 };
            this.btnAddPhoto.Click += BtnAddPhoto_Click;

            this.btnSave = new Button() { Top = 360, Left = 130, Text = "Сохранить", Width = 90 };
            this.btnSave.Click += BtnSave_Click;

            this.btnCancel = new Button() { Top = 360, Left = 240, Text = "Отменить", Width = 90 };
            this.btnCancel.Click += BtnCancel_Click;

            this.pictureBox = new PictureBox() 
            { 
                Top = 40, Left = 400, Width = 150, Height = 200, BorderStyle = BorderStyle.FixedSingle,
                SizeMode = PictureBoxSizeMode.StretchImage
            };


            this.Controls.Add(txtLastName);
            this.Controls.Add(lblLastName);
            this.Controls.Add(txtFirstName);
            this.Controls.Add(lblFirstName);
            this.Controls.Add(txtPatronymic);
            this.Controls.Add(lblPatronymic);
            this.Controls.Add(dtpBirthDate);
            this.Controls.Add(lblBirthDate);
            this.Controls.Add(txtPassportSeries);
            this.Controls.Add(lblPassportSeries);
            this.Controls.Add(txtPassportNumber);
            this.Controls.Add(lblPassportNumber);
            this.Controls.Add(dtpPassportIssuedDate);
            this.Controls.Add(lblPassportIssuedDate);
            this.Controls.Add(txtPassportIssuedBy);
            this.Controls.Add(lblPassportIssuedBy);
            this.Controls.Add(btnAddPhoto);
            this.Controls.Add(btnSave);
            this.Controls.Add(btnCancel);
            this.Controls.Add(pictureBox);

        }

        private void FillFormFields(ClientDTO client)
        {
            id = client.Id;
            txtFirstName.Text = client.FirstName;
            txtLastName.Text = client.LastName;
            txtPatronymic.Text = client.Patronymic;
            dtpBirthDate.Value = client.DateOfBirth;
            txtPassportSeries.Text = client.PassportData.Series;
            txtPassportNumber.Text = client.PassportData.Number;
            dtpPassportIssuedDate.Value = client.PassportData.IssuedDate;
            txtPassportIssuedBy.Text = client.PassportData.IssuedBy;
            pictureBox.ImageLocation = client.PathToPhoto;
        }

        private void BtnAddPhoto_Click(object sender, EventArgs e)
        {
            // Открытие диалога выбора файла изображения
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox.ImageLocation = openFileDialog.FileName;
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            ClientDTO client = new ClientDTO
            {
                Id = id,
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Patronymic = txtPatronymic.Text,
                DateOfBirth = dtpBirthDate.Value,
                PassportData = new PassportDTO()
                { Series = txtPassportSeries.Text, 
                    Number = txtPassportNumber.Text, 
                    IssuedDate = dtpPassportIssuedDate.Value, 
                    IssuedBy = txtPassportIssuedBy.Text },
                PathToPhoto = pictureBox.ImageLocation
            };

            ClientSubmitted?.Invoke(this, client);
        }

    }
}