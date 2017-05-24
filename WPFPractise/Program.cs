using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WPFPractise
{
    class Program : Application
    {
        [STAThread()]

        static void Main()
        {
            Program app = new Program();
            app.MainWindow = new window1();
            app.MainWindow.ShowDialog();
        }
    }
}
