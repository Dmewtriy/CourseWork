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
    public partial class RoutePointsForm : Form, IRoutePointsView
    {
        public RoutePointsForm()
        {
            InitializeComponent();
            Load += LoadPoints;
        }

        public event EventHandler<RoutePointDTO> RoutePointAdded;
        public event EventHandler<RoutePointDTO> RoutePointUpdated;
        public event EventHandler<RoutePointDTO> RoutePointDeleted;
        public event EventHandler LoadRoutePointsRequested;
        public event EventHandler<long> RoutePointSearchRequested;
        public event EventHandler<RoutePointDTO> RoutePointSelected;


        public void ShowErrorMessage(string message)
        {
            MessageBox.Show(message);
        }

        public void UpdateRoutePointsList(IEnumerable<RoutePointDTO> RoutePoints)
        {
            PointsDataGridView.Rows.Clear();
            foreach (RoutePointDTO routePoint in RoutePoints)
            {
                int index = PointsDataGridView.Rows.Add();
                PointsDataGridView.Rows[index].Cells["Id"].Value = routePoint.Id;
                PointsDataGridView.Rows[index].Cells["PointName"].Value = routePoint.Name;
                PointsDataGridView.Rows[index].Cells["Duration"].Value = routePoint.StayDuration;
                PointsDataGridView.Rows[index].Cells["HotelName"].Value = routePoint.HotelName;
                PointsDataGridView.Rows[index].Cells["HotelClass"].Value = routePoint.HotelClass;
                PointsDataGridView.Rows[index].Tag = routePoint;
            }
            PointsDataGridView_SelectionChanged(this, EventArgs.Empty);
        }

        public void HighlightRoutePoint(RoutePointDTO RoutePoint)
        {
            foreach (DataGridViewRow row in PointsDataGridView.Rows)
            {
                if (long.Parse(row.Cells["Id"].Value.ToString()) == RoutePoint.Id)
                {
                    row.Selected = true;
                    PointsDataGridView_SelectionChanged(this, EventArgs.Empty);
                }
            }
        }

        public void ShowExcursions(IEnumerable<ExcursionDTO> excursions)
        {
            ExcursionsDataGridView.Rows.Clear();
            foreach (ExcursionDTO excursion in excursions)
            {
                int index = ExcursionsDataGridView.Rows.Add();
                ExcursionsDataGridView.Rows[index].Cells["ExId"].Value = excursion.Id;
                ExcursionsDataGridView.Rows[index].Cells["ExName"].Value = excursion.Name;
                ExcursionsDataGridView.Rows[index].Tag = excursion;
            }
        }

        private void LoadPoints(object sender, EventArgs e)
        {
            LoadRoutePointsRequested?.Invoke(this, EventArgs.Empty);
        }

    }
}
