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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CourseWork1.Forms
{
    public partial class ExcursionsForm : Form, IExcursionsView
    {
        public ExcursionsForm()
        {
            InitializeComponent();
            Load += LoadExcursions;
        }

        public event EventHandler<ExcursionDTO> ExcursionAdded;
        public event EventHandler<ExcursionDTO> ExcursionUpdated;
        public event EventHandler<ExcursionDTO> ExcursionDeleted;
        public event EventHandler LoadExcursionsRequested;
        public event EventHandler<long> ExcursionSearchRequested;
        public event EventHandler<ExcursionDTO> ExcursionSelected;

        public void HighlightExcursion(ExcursionDTO Excursion)
        {
            foreach (DataGridViewRow row in ExcursionsDataGridView.Rows)
            {
                if (long.Parse(row.Cells["Id"].Value.ToString()) == Excursion.Id)
                {
                    row.Selected = true;
                    ExcursionsDataGridView_SelectionChanged(this, EventArgs.Empty);
                }
            }
        }

        public void ShowErrorMessage(string message)
        {
            MessageBox.Show(message);
        }

        public void ShowExcursionDescription(string description)
        {
            ExcursionDescription.Text = description;
        }

        public void UpdateExcursionsList(IEnumerable<ExcursionDTO> Excursions)
        {
            ExcursionsDataGridView.Rows.Clear();
            foreach (ExcursionDTO Excursion in Excursions)
            {
                int index = ExcursionsDataGridView.Rows.Add(Excursion.ToString().Split(' '));
                ExcursionsDataGridView.Rows[index].Tag = Excursion;
            }
            ExcursionsDataGridView_SelectionChanged(this, EventArgs.Empty);
        }

        private void LoadExcursions(object sender, EventArgs e)
        {
            LoadExcursionsRequested?.Invoke(this, EventArgs.Empty);
        }
    }
}
