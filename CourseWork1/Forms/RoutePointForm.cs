using CourseWork1.DTOs;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CourseWork1.Forms
{
    public partial class RoutePointForm : Form
    {
        public event EventHandler<RoutePointDTO> RoutePointSubmitted;
        public RoutePointForm(RoutePointDTO point = null)
        {
            InitializeComponent();
            Text = point == null ? "Добавить пункт маршрута" : "Редактировать пункт маршрута";
            if (point != null)
            {
                FillFormFields(point);
            }
        }

        private void SaveButtonClick(object sender, EventArgs e)
        {
            int.TryParse(DurationTextBox.Text, out int duration);
            int.TryParse(HotelClassTextBox.Text, out int Class);
            RoutePointDTO point = new RoutePointDTO()
            {
                Id = id,
                Name = NameTextBox.Text,
                StayDuration = duration,
                HotelName = HotelNameTextBox.Text,
                HotelClass = Class,
                Excursions = new List<ExcursionDTO>()
            };
            foreach(DataGridViewRow row in ExcursionsDataGridView.Rows)
            {
                point.Excursions.Add(row.Tag as ExcursionDTO);
            }

            RoutePointSubmitted?.Invoke(sender, point);
        }

        private void CancelButtonClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
