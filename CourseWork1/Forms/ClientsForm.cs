using CourseWork1.DTOs;
using CourseWork1.Views;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CourseWork1.Forms
{
    public partial class ClientsForm : Form, IClientView
    {
        public ClientsForm()
        {
            InitializeComponent();
            Load += LoadClients;
        }

        public event EventHandler<ClientDTO> ClientAdded;
        public event EventHandler<ClientDTO> ClientUpdated;
        public event EventHandler<ClientDTO> ClientDeleted;
        public event EventHandler LoadClientsRequested;
        public event EventHandler<long> ClientSearchRequested;
        public event EventHandler<ClientDTO> ClientSelected;


        public void HighlightClient(ClientDTO client)
        {
            foreach(DataGridViewRow row in clientsDataGridView.Rows)
            {
                if (long.Parse(row.Cells["Id"].Value.ToString()) == client.Id)
                {
                    row.Selected = true;
                    ClientsDataGridView_SelectionChanged(this, EventArgs.Empty);
                }
            }
        }

        public void ShowErrorMessage(string message)
        {
            MessageBox.Show(message);
        }

        public void UpdateClientsList(IEnumerable<ClientDTO> clients)
        {
            clientsDataGridView.Rows.Clear();
            foreach (ClientDTO client in clients)
            {
                int index = clientsDataGridView.Rows.Add(client.ToString().Split(' '));
                clientsDataGridView.Rows[index].Tag = client;
            }
            ClientsDataGridView_SelectionChanged(this, EventArgs.Empty);
        }

        public void ShowClientPhoto(string photoPath)
        {
            clientPhotoPictureBox.ImageLocation = photoPath;
        }

        private void LoadClients(object sender, EventArgs e) 
        {
            LoadClientsRequested?.Invoke(this, EventArgs.Empty);
        }

    }
}
