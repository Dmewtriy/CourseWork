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
    public partial class RouteForm : Form
    {
        public event EventHandler<RouteDTO> RouteSubmitted;
        public RouteForm(RouteDTO route = null)
        {
            InitializeComponent();
            Text = route == null ? "Добавить маршрут" : "Редактировать маршрут";
            if (route != null )
            {
                FillFormFields(route);
            }
        }
    }
}
