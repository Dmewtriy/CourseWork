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
    public partial class CompanyRepresenativeForm : Form
    {
        public event EventHandler<CompanyRepresentativeDTO> RepresentativeSubmitted;
        public CompanyRepresenativeForm(CompanyRepresentativeDTO cR = null)
        {
            InitializeComponent();
            Text = cR == null ? "Добавить представителя компании" : "Редактирвоать представиетля компании";
            if (cR != null)
                FillFormFields(cR);
        }

        private void CancelButtonClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void SaveButtonClick(object sender, EventArgs e)
        {
            CompanyRepresentativeDTO cR = new CompanyRepresentativeDTO()
            {
                FirstName = FirstNameTextBox.Text,
                LastName = LastNameTextBox.Text,
                Patronymic = PatronymicTextBox.Text,
                Number = NumberTextBox.Text,
                Email = EmailTextBox.Text,
                Id = id
            };
            RepresentativeSubmitted?.Invoke(this, cR);
        }
    }
}
