using CourseWork1.DTOs;
using System;
using System.Windows.Forms;

namespace CourseWork1.Forms
{
    partial class ClientsForm
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

        private DataGridView clientsDataGridView;
        private Button addButton;
        private Button editButton;
        private Button deleteButton;
        private Button refreshButton;
        private Button searchButton;
        private Panel buttonPanel;
        private TextBox searchTextBox;
        private PictureBox clientPhotoPictureBox;

        private void InitializeComponent()
        {
            this.Text = "Управление клиентами";
            this.Size = new System.Drawing.Size(1200, 600);

            clientsDataGridView = new DataGridView()
            {
                MultiSelect = false,
                ReadOnly = true,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                ColumnCount = 6,
                AllowUserToAddRows = false,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells,
                AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells,
                AutoSize = true,
                Top = 10,
            };


            clientsDataGridView.Columns[0].Name = "Id";
            clientsDataGridView.Columns[1].Name = "Фамилия";
            clientsDataGridView.Columns[2].Name = "Имя";
            clientsDataGridView.Columns[3].Name = "Отчество";
            clientsDataGridView.Columns[4].Name = "Дата рождения";
            clientsDataGridView.Columns[5].Name = "Паспорт";
            clientsDataGridView.CellClick += ClientsDataGridView_SelectionChanged;
            clientsDataGridView.Resize += MovePhoto;

            clientPhotoPictureBox = new PictureBox()
            {
                Top = 10,
                Width = 200,
                Height = 200,
                BorderStyle = BorderStyle.FixedSingle,
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            addButton = new Button()
            {
                Text = "Добавить клиента",
                Dock = DockStyle.Left,
                Width = 120
            };

            editButton = new Button()
            {
                Text = "Редактировать клиента",
                Dock = DockStyle.Left,
                Width = 120
            };

            deleteButton = new Button()
            {
                Text = "Удалить клиента",
                Dock = DockStyle.Left,
                Width = 120
            };

            refreshButton = new Button()
            {
                Text = "Обновить список клиентов",
                Dock = DockStyle.Left,
                Width = 120
            };

            searchButton = new Button()
            {
                Text = "Поиск по id",
                Dock = DockStyle.Right,
                Width = 120
            };

            searchTextBox = new TextBox()
            {
                Dock = DockStyle.Right,
                Width = 200,
                Text = "Напишите id клиента"
            };

            buttonPanel = new Panel()
            {
                Dock = DockStyle.Bottom,
                Height = 50
            };

            buttonPanel.Controls.Add(addButton);
            buttonPanel.Controls.Add(editButton);
            buttonPanel.Controls.Add(deleteButton);
            buttonPanel.Controls.Add(refreshButton);
            buttonPanel.Controls.Add(searchTextBox);
            buttonPanel.Controls.Add(searchButton);

            this.Controls.Add(clientsDataGridView);
            this.Controls.Add(clientPhotoPictureBox);
            this.Controls.Add(buttonPanel);

            addButton.Click += AddClientButtonClick;
            editButton.Click += EditClientButtonClick;
            deleteButton.Click += DeleteClientButtonClick;
            refreshButton.Click += LoadClients;
            searchButton.Click += SearchClientByIdButtonClick;
        }
        private void CustomizeDataGridView()
        {
            foreach (DataGridViewColumn column in clientsDataGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void ClientsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (clientsDataGridView.SelectedRows.Count > 0)
            {
                var selectedRow = clientsDataGridView.SelectedRows[0];
                ClientDTO client = (ClientDTO)selectedRow.Tag;
                ClientSelected?.Invoke(this, client);
            }
        }

        private void MovePhoto(object sender, EventArgs e)
        {
            clientPhotoPictureBox.Left = clientsDataGridView.Right + 15;
        }

        private void AddClientButtonClick(object sender, EventArgs e)
        {
            ClientForm form = new ClientForm();
            form.ClientSubmitted += (s, client) =>
            {
                try
                {
                    ClientAdded?.Invoke(this, client);
                    form.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            };
            form.ShowDialog();
            ClientsDataGridView_SelectionChanged(sender, e);
        }

        private void EditClientButtonClick(object sender, EventArgs e)
        {
            if (clientsDataGridView.SelectedRows.Count > 0)
            {
                var selectedRow = clientsDataGridView.SelectedRows[0];
                ClientDTO client = (ClientDTO)selectedRow.Tag;
                ClientForm form = new ClientForm(client);
                form.ClientSubmitted += (s, cl) =>
                {
                    try
                    {
                        ClientUpdated?.Invoke(this, cl);
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

        private void DeleteClientButtonClick(object sender, EventArgs e)
        {
            if (clientsDataGridView.SelectedRows.Count > 0)
            {
                var selectedRow = clientsDataGridView.SelectedRows[0];
                ClientDTO client = (ClientDTO)selectedRow.Tag;
                ClientDeleted?.Invoke(sender, client);
                ClientsDataGridView_SelectionChanged(sender, e);
            }
        }
        private void SearchClientByIdButtonClick(object sender, EventArgs e)
        {
            long id;
            long.TryParse(searchTextBox.Text, out id);
            ClientSearchRequested?.Invoke(sender, id);
            ClientsDataGridView_SelectionChanged(sender, e);
        }
    }
}
