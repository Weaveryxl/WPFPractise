using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFPractice2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// MainWindow.xaml logic for interaction
        /// </summary>

        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, RoutedEventArgs e)
        {
            this.scrollViewer1.LineUp();
            //this.scrollViewer1.PageUp();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            this.scrollViewer1.LineDown();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            this.scrollViewer1.ScrollToEnd();
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            this.scrollViewer1.ScrollToHome();
        }
    }
}
