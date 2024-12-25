using CourseWork1.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
