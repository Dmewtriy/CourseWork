using CourseWork1.DTOs;
using CourseWork1.Views;
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
    public partial class CompanyRepresentativesForm : Form, ICompanyRepresentativesView
    {
        public CompanyRepresentativesForm()
        {
            InitializeComponent();
            Load += LoadCompanyRepresentatives;
        }

        public event EventHandler<CompanyRepresentativeDTO> CompanyRepresentativeAdded;
        public event EventHandler<CompanyRepresentativeDTO> CompanyRepresentativeUpdated;
        public event EventHandler<CompanyRepresentativeDTO> CompanyRepresentativeDeleted;
        public event EventHandler LoadCompanyRepresentativesRequested;
        public event EventHandler<long> CompanyRepresentativeSearchRequested;


        public void ShowErrorMessage(string message)
        {
            MessageBox.Show(message);
        }

        public void UpdateCompanyRepresentativesList(IEnumerable<CompanyRepresentativeDTO> CompanyRepresentatives)
        {
            RepresentativesDataGridView.Rows.Clear();
            foreach (CompanyRepresentativeDTO CompanyRepresentative in CompanyRepresentatives)
            {
                int index = RepresentativesDataGridView.Rows.Add();
                RepresentativesDataGridView.Rows[index].Cells["Id"].Value = CompanyRepresentative.Id;
                RepresentativesDataGridView.Rows[index].Cells["LastName"].Value = CompanyRepresentative.LastName;
                RepresentativesDataGridView.Rows[index].Cells["FirstName"].Value = CompanyRepresentative.FirstName;
                RepresentativesDataGridView.Rows[index].Cells["Patronymic"].Value = CompanyRepresentative.Patronymic;
                RepresentativesDataGridView.Rows[index].Cells["Number"].Value = CompanyRepresentative.Number;
                RepresentativesDataGridView.Rows[index].Cells["Email"].Value = CompanyRepresentative.Email;
                RepresentativesDataGridView.Rows[index].Tag = CompanyRepresentative;
            }
        }

        public void HighlightCompanyRepresentative(CompanyRepresentativeDTO CompanyRepresentative)
        {
            foreach (DataGridViewRow row in RepresentativesDataGridView.Rows)
            {
                if (long.Parse(row.Cells["Id"].Value.ToString()) == CompanyRepresentative.Id)
                {
                    row.Selected = true;
                }
            }
        }

        private void LoadCompanyRepresentatives(object sender, EventArgs e)
        {
            LoadCompanyRepresentativesRequested?.Invoke(this, EventArgs.Empty);
        }
    }
}
