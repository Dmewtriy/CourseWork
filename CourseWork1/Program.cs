using CourseWork1.Forms;
using CourseWork1.Interfaces;
using CourseWork1.Presenters.classes;
using CourseWork1.Repositories;
using CourseWork1.Services;
using CourseWork1.Services.classes;
using System;
using System.Windows.Forms;

namespace CourseWork1
{
    internal class Program
    {
        [STAThreadAttribute]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
