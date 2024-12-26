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
    public partial class ExcursionForm : Form
    {
        public event EventHandler<ExcursionDTO> ExcursionSubmitted;
        public ExcursionForm(ExcursionDTO excursion = null)
        {
            InitializeComponent();
            Text = excursion == null ? "Добавить экскурсию" : "Редактировать экскурсию";
            if (excursion != null)
            {
                FillFormFields(excursion);
            }
        }

    }
}
