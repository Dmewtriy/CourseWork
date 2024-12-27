using CourseWork1.Forms;
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
