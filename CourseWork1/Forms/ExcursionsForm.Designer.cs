using CourseWork1.DTOs;
using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CourseWork1.Forms
{
    partial class ExcursionsForm
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
            this.ExcursionsDataGridView = new System.Windows.Forms.DataGridView();
            this.SearchButton = new System.Windows.Forms.Button();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ExcursionDescription = new System.Windows.Forms.TextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ExcursionsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ExcursionsDataGridView
            // 
            this.ExcursionsDataGridView.AllowUserToAddRows = false;
            this.ExcursionsDataGridView.AllowUserToDeleteRows = false;
            this.ExcursionsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.ExcursionsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.ExcursionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExcursionsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ExName});
            this.ExcursionsDataGridView.Location = new System.Drawing.Point(16, 15);
            this.ExcursionsDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.ExcursionsDataGridView.MultiSelect = false;
            this.ExcursionsDataGridView.Name = "ExcursionsDataGridView";
            this.ExcursionsDataGridView.ReadOnly = true;
            this.ExcursionsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ExcursionsDataGridView.Size = new System.Drawing.Size(579, 185);
            this.ExcursionsDataGridView.TabIndex = 1;
            this.ExcursionsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ExcursionsDataGridView_SelectionChanged);
            this.ExcursionsDataGridView.Resize += new System.EventHandler(this.MoveDescription);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(673, 460);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(4);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(187, 28);
            this.SearchButton.TabIndex = 9;
            this.SearchButton.Text = "Поиск по id";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButtonClick);
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(673, 427);
            this.IdTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(185, 23);
            this.IdTextBox.TabIndex = 8;
            this.IdTextBox.Text = "Введите id для поиска";
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(428, 427);
            this.RefreshButton.Margin = new System.Windows.Forms.Padding(4);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(131, 63);
            this.RefreshButton.TabIndex = 4;
            this.RefreshButton.Text = "Обновить список";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButtonClick);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(289, 427);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(131, 63);
            this.DeleteButton.TabIndex = 5;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.ButtonDeleteClick);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(151, 427);
            this.EditButton.Margin = new System.Windows.Forms.Padding(4);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(131, 63);
            this.EditButton.TabIndex = 6;
            this.EditButton.Text = "Редактировать";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.ButtonEditClick);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(12, 427);
            this.ButtonAdd.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(131, 63);
            this.ButtonAdd.TabIndex = 7;
            this.ButtonAdd.Text = "Добавить";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAddClick);
            // 
            // ExcursionDescription
            // 
            this.ExcursionDescription.Location = new System.Drawing.Point(696, 42);
            this.ExcursionDescription.MaximumSize = new System.Drawing.Size(329, 360);
            this.ExcursionDescription.Multiline = true;
            this.ExcursionDescription.Name = "ExcursionDescription";
            this.ExcursionDescription.ReadOnly = true;
            this.ExcursionDescription.Size = new System.Drawing.Size(329, 360);
            this.ExcursionDescription.TabIndex = 10;
            this.ExcursionDescription.TextChanged += new System.EventHandler(this.ExcursionDescription_TextChanged);
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(693, 15);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(144, 17);
            this.DescriptionLabel.TabIndex = 11;
            this.DescriptionLabel.Text = "Описание экскурсии";
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
            // ExcursionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.ExcursionDescription);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.ExcursionsDataGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ExcursionsForm";
            this.Text = "Экскурсии";
            ((System.ComponentModel.ISupportInitialize)(this.ExcursionsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private void ButtonAddClick(object sender, EventArgs e)
        {
            ExcursionForm form = new ExcursionForm();
            form.ExcursionSubmitted += (s, excursion) =>
            {
                try
                {
                    ExcursionAdded?.Invoke(s, excursion);
                    form.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            };
            form.ShowDialog();
            ExcursionsDataGridView_SelectionChanged(sender, e);
        }

        private void ButtonEditClick(object sender, EventArgs e)
        {
            if (ExcursionsDataGridView.SelectedRows.Count > 0)
            {
                var selectedRow = ExcursionsDataGridView.SelectedRows[0];
                ExcursionDTO exDTO = selectedRow.Tag as ExcursionDTO;
                ExcursionForm form = new ExcursionForm(exDTO);
                form.ExcursionSubmitted += (s, ex) =>
                {
                    try
                    {
                        ExcursionUpdated?.Invoke(this, ex);
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
            if (ExcursionsDataGridView.SelectedRows.Count > 0)
            {
                ExcursionDTO cRDTO = ExcursionsDataGridView.SelectedRows[0].Tag as ExcursionDTO;
                ExcursionDeleted?.Invoke(this, cRDTO);
            }
        }

        private void RefreshButtonClick(object sender, EventArgs e)
        {
            LoadExcursions(sender, e);
        }

        private void SearchButtonClick(object sender, EventArgs e)
        {
            long.TryParse(IdTextBox.Text, out long id);
            ExcursionSearchRequested?.Invoke(sender, id);
            ExcursionsDataGridView_SelectionChanged(sender, e);
        }

        private void ExcursionsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (ExcursionsDataGridView.SelectedRows.Count > 0)
            {
                var selectedRow = ExcursionsDataGridView.SelectedRows[0];
                ExcursionDTO Excursion = (ExcursionDTO)selectedRow.Tag;
                ExcursionSelected?.Invoke(this, Excursion);
            }
            else
            {
                ShowExcursionDescription("");
            }
        }

        private void MoveDescription(object sender, EventArgs e)
        {
            ExcursionDescription.Left = ExcursionsDataGridView.Right + 15;
        }

        private void ExcursionDescription_TextChanged(object sender, EventArgs e)
        {
            Size size = TextRenderer.MeasureText(ExcursionDescription.Text, ExcursionDescription.Font, new Size(ExcursionDescription.Width, int.MaxValue), 
                TextFormatFlags.WordBreak);
            ExcursionDescription.Width = 320;
            ExcursionDescription.Height = size.Height + 5;
        }

        private System.Windows.Forms.DataGridView ExcursionsDataGridView;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.TextBox ExcursionDescription;
        private Label DescriptionLabel;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn ExName;
    }
}