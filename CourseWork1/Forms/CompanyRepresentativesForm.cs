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
                int index = RepresentativesDataGridView.Rows.Add(CompanyRepresentative.ToString().Split(' '));
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
