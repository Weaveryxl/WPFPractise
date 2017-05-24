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
using System.Windows.Shapes;

namespace WPFPractise
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// MainWindow.xaml logic of interaction
        /// </summary>
        private Button myButton;

        public MainWindow()
        {
            InitializeComponent();
        }

        public MainWindow(string xamlFile)
        {
            //Setup window
            this.Width = this.Height = 285;
            this.Left = this.Top = 100;
            this.Title = "Dynamically Loaded XAML.";

            //Get XAML from external file
            DependencyObject rootElement;
            using (FileStream fs = new FileStream(xamlFile, FileMode.Open))
            {
                rootElement = (DependencyObject)XamlReader.Load(fs);
            }
            this.Content = rootElement;

            myButton = (Button)LogicalTreeHelper.FindLogicalNode(rootElement, "button1");
            myButton.Click += myButton_Click;
        }

        private void myButton_Click(object sender, RoutedEventArgs e)
        {
            myButton.Content = "Thank you.";
        }
    }
}
