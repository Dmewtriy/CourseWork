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
    public partial class RoutesForm : Form, IRoutesView
    {
        public RoutesForm()
        {
            InitializeComponent();
            Load += LoadRoutes;
        }

        public event EventHandler<RouteDTO> RouteAdded;
        public event EventHandler<RouteDTO> RouteUpdated;
        public event EventHandler<RouteDTO> RouteDeleted;
        public event EventHandler LoadRoutesRequested;
        public event EventHandler<long> RouteSearchRequested;
        public event EventHandler<RouteDTO> RouteSelected;

        public void ShowErrorMessage(string message)
        {
            MessageBox.Show(message);
        }

        public void UpdateRoutesList(IEnumerable<RouteDTO> Routes)
        {
            RoutesDataGridView.Rows.Clear();
            foreach (RouteDTO route in Routes)
            {
                int index = RoutesDataGridView.Rows.Add();
                RoutesDataGridView.Rows[index].Cells["Id"].Value = route.Id;
                RoutesDataGridView.Rows[index].Cells["RouteName"].Value = route.Name;
                RoutesDataGridView.Rows[index].Cells["Duration"].Value = route.Duration;
                RoutesDataGridView.Rows[index].Cells["Country"].Value = route.Country;
                RoutesDataGridView.Rows[index].Tag = route;
            }
            RoutesDataGridView_SelectionChanged(this, EventArgs.Empty);
        }

        public void HighlightRoute(RouteDTO Route)
        {
            foreach (DataGridViewRow row in RoutesDataGridView.Rows)
            {
                if (long.Parse(row.Cells["Id"].Value.ToString()) == Route.Id)
                {
                    row.Selected = true;
                    RoutesDataGridView_SelectionChanged(this, EventArgs.Empty);
                }
            }
        }

        public void ShowRoutePoints(IEnumerable<RoutePointDTO> points)
        {
            PointsDataGridView.Rows.Clear();
            foreach (RoutePointDTO point in points)
            {
                int index = PointsDataGridView.Rows.Add();
                PointsDataGridView.Rows[index].Cells["PointId"].Value = point.Id;
                PointsDataGridView.Rows[index].Cells["PointName"].Value = point.Name;
                PointsDataGridView.Rows[index].Cells["PointDuration"].Value = point.StayDuration;
                PointsDataGridView.Rows[index].Cells["HotelName"].Value = point.HotelName;
                PointsDataGridView.Rows[index].Cells["HotelClass"].Value = point.HotelClass;
                PointsDataGridView.Rows[index].Tag = point;
            }
        }

        private void LoadRoutes(object sender, EventArgs e)
        {
            LoadRoutesRequested?.Invoke(this, EventArgs.Empty);
        }

    }
}
