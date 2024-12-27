using CourseWork1.DTOs;
using System;
using System.Windows.Forms;

namespace CourseWork1.Forms
{
    partial class CompanyRepresentativesForm
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
            this.RepresentativesDataGridView = new System.Windows.Forms.DataGridView();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Patronymic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.RepresentativesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // RepresentativesDataGridView
            // 
            this.RepresentativesDataGridView.AllowUserToAddRows = false;
            this.RepresentativesDataGridView.AllowUserToDeleteRows = false;
            this.RepresentativesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.RepresentativesDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.RepresentativesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RepresentativesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.LastName,
            this.FirstName,
            this.Patronymic,
            this.Number,
            this.Email});
            this.RepresentativesDataGridView.Location = new System.Drawing.Point(16, 27);
            this.RepresentativesDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.RepresentativesDataGridView.MultiSelect = false;
            this.RepresentativesDataGridView.Name = "RepresentativesDataGridView";
            this.RepresentativesDataGridView.ReadOnly = true;
            this.RepresentativesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RepresentativesDataGridView.Size = new System.Drawing.Size(883, 185);
            this.RepresentativesDataGridView.TabIndex = 0;
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(51, 454);
            this.ButtonAdd.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(131, 63);
            this.ButtonAdd.TabIndex = 1;
            this.ButtonAdd.Text = "Добавить";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAddClick);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(189, 454);
            this.EditButton.Margin = new System.Windows.Forms.Padding(4);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(131, 63);
            this.EditButton.TabIndex = 1;
            this.EditButton.Text = "Редактировать";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.ButtonEditClick);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(328, 454);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(131, 63);
            this.DeleteButton.TabIndex = 1;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.ButtonDeleteClick);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(467, 454);
            this.RefreshButton.Margin = new System.Windows.Forms.Padding(4);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(131, 63);
            this.RefreshButton.TabIndex = 1;
            this.RefreshButton.Text = "Обновить список";
            this.RefreshButton.UseVisualStyleBackColor = true;
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(712, 454);
            this.IdTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(185, 23);
            this.IdTextBox.TabIndex = 2;
            this.IdTextBox.Text = "Введите id для поиска";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(712, 487);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(4);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(187, 28);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.Text = "Поиск по id";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButtonClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 44;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Фамилия";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            this.LastName.Width = 95;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "Имя";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            this.FirstName.Width = 60;
            // 
            // Patronymic
            // 
            this.Patronymic.HeaderText = "Отчество";
            this.Patronymic.Name = "Patronymic";
            this.Patronymic.ReadOnly = true;
            this.Patronymic.Width = 96;
            // 
            // Number
            // 
            this.Number.HeaderText = "Номер телефона";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.Width = 133;
            // 
            // Email
            // 
            this.Email.HeaderText = "Почта";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 74;
            // 
            // CompanyRepresentativesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 554);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.RepresentativesDataGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CompanyRepresentativesForm";
            this.Text = "Представители компании";
            ((System.ComponentModel.ISupportInitialize)(this.RepresentativesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void ButtonAddClick(object sender, EventArgs e)
        {
            CompanyRepresenativeForm form = new CompanyRepresenativeForm();
            form.RepresentativeSubmitted += (s, cR) =>
            {
                try
                {
                    CompanyRepresentativeAdded?.Invoke(this, cR);
                    form.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            };
            form.ShowDialog();
        }

        private void ButtonEditClick(object sender, EventArgs e)
        {
            if (RepresentativesDataGridView.SelectedRows.Count > 0)
            {
                var selectedRow = RepresentativesDataGridView.SelectedRows[0];
                CompanyRepresentativeDTO cRDTO = selectedRow.Tag as CompanyRepresentativeDTO;
                CompanyRepresenativeForm form = new CompanyRepresenativeForm(cRDTO);
                form.RepresentativeSubmitted += (s, cR) =>
                {
                    try
                    {
                        CompanyRepresentativeUpdated?.Invoke(this, cR);
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
            if (RepresentativesDataGridView.SelectedRows.Count > 0)
            {
                CompanyRepresentativeDTO cRDTO = RepresentativesDataGridView.SelectedRows[0].Tag as CompanyRepresentativeDTO;
                CompanyRepresentativeDeleted?.Invoke(this, cRDTO);
            }
        }


        private void SearchButtonClick(object sender, EventArgs e)
        {
            long id;
            long.TryParse(IdTextBox.Text, out id);
            CompanyRepresentativeSearchRequested?.Invoke(this, id);
        }

        #endregion

        private System.Windows.Forms.DataGridView RepresentativesDataGridView;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Button SearchButton;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn Patronymic;
        private DataGridViewTextBoxColumn Number;
        private DataGridViewTextBoxColumn Email;
    }
}