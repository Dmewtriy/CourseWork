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
    public partial class TripsForm : Form, ITripsView
    {
        public TripsForm()
        {
            InitializeComponent();
            Load += LoadTrips;
        }

        public event EventHandler<TripDTO> TripAdded;
        public event EventHandler<TripDTO> TripUpdated;
        public event EventHandler<TripDTO> TripDeleted;
        public event EventHandler LoadTripsRequested;
        public event EventHandler<long> TripSearchRequested;
        public event EventHandler<TripDTO> TripSelected;
        public event EventHandler<TripDTO> PenaltyPaid;
        public event EventHandler<TripDTO> PenaltyUnpaid;

        public void HighlightTrip(TripDTO Trip)
        {
            foreach (DataGridViewRow row in TripsDataGridView.Rows)
            {
                if (long.Parse(row.Cells["Id"].Value.ToString()) == Trip.Id)
                {
                    row.Selected = true;
                    TripsDataGridView_SelectionChanged(this, EventArgs.Empty);
                }
            }
        }

        public void PenaltyHighlightTrip(TripDTO Trip)
        {
            foreach (DataGridViewRow row in TripsDataGridView.Rows)
            {
                if (long.Parse(row.Cells["Id"].Value.ToString()) == Trip.Id)
                {
                    row.Selected = true;
                    row.DefaultCellStyle.ForeColor = Color.Aquamarine;
                    TripsDataGridView_SelectionChanged(this, EventArgs.Empty);
                }
            }
        }
        public void PenaltyDeHighlightTrip(TripDTO Trip)
        {
            foreach (DataGridViewRow row in TripsDataGridView.Rows)
            {
                if (long.Parse(row.Cells["Id"].Value.ToString()) == Trip.Id)
                {
                    row.Selected = true;
                    row.DefaultCellStyle.ForeColor = Color.White;
                    TripsDataGridView_SelectionChanged(this, EventArgs.Empty);
                }
            }
        }

        public void ShowErrorMessage(string message)
        {
            MessageBox.Show(message);
        }

        public void ShowTourists(IEnumerable<ClientDTO> tourists)
        {
            ClientsDataGridView.Rows.Clear();
            foreach(ClientDTO tourist in tourists)
            {
                int index = ClientsDataGridView.Rows.Add();
                ClientsDataGridView.Rows[index].Cells["ClientId"].Value = tourist.Id;
                ClientsDataGridView.Rows[index].Cells["ClientLastName"].Value = tourist.LastName;
                ClientsDataGridView.Rows[index].Cells["ClientFirstName"].Value = tourist.FirstName;
                ClientsDataGridView.Rows[index].Cells["ClientPatronymic"].Value = tourist.Patronymic;
                ClientsDataGridView.Rows[index].Cells["ClientBirthDate"].Value = tourist.DateOfBirth.ToShortDateString();
                ClientsDataGridView.Rows[index].Cells["ClientPassport"].Value = tourist.PassportData.ToString();
                ClientsDataGridView.Rows[index].Tag = tourist;
            }
        }

        public void UpdateTripsList(IEnumerable<TripDTO> Trips)
        {
            TripsDataGridView.Rows.Clear();
            foreach (var trip in Trips) 
            {
                int index = TripsDataGridView.Rows.Add(trip);
                TripsDataGridView.Rows[index].Cells["Id"].Value = trip.Id;
                TripsDataGridView.Rows[index].Cells["RouteName"].Value = trip.RouteName;
                TripsDataGridView.Rows[index].Cells["Representative"].Value = trip.Representative.GetName();
                TripsDataGridView.Rows[index].Cells["Price"].Value = trip.Price;
                TripsDataGridView.Rows[index].Cells["StartDate"].Value = trip.StartDate.ToShortDateString();
                TripsDataGridView.Rows[index].Cells["EndDate"].Value = trip.EndDate.ToShortDateString();
                TripsDataGridView.Rows[index].Cells["TouristNumber"].Value = trip.TouristNumber;
                TripsDataGridView.Rows[index].Cells["Penalty"].Value = trip.Penalty;
                TripsDataGridView.Rows[index].Tag = trip;
            }
            TripsDataGridView_SelectionChanged(this, EventArgs.Empty);
        }
        private void LoadTrips(object sender, EventArgs e)
        {
            LoadTripsRequested?.Invoke(this, EventArgs.Empty);
        }        
    }
}
