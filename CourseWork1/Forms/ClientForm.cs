using CourseWork1.DTOs;
using System;
using System.Windows.Forms;

namespace CourseWork1.Forms
{
    public partial class ClientForm : Form
    {
        public event EventHandler<ClientDTO> ClientSubmitted;
        public ClientForm(ClientDTO client = null)
        {
            InitializeComponent();
            Text = client == null ? "Добавить клиента" : "Редактировать клиента";
            if (client != null)
            {
                FillFormFields(client);
            }
        }
    }
}
