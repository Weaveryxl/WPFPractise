using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace WPFPractise
{
    class window1 : Window
    {
        private Button button1;

        public window1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Width = 285;
            this.Height = 250;
            this.Left = this.Top = 100;
            this.Title = "Code-Only Window";

            DockPanel panel = new DockPanel();

            button1 = new Button();
            button1.Content = "Hit me!!";
            button1.Margin = new Thickness(30);

            button1.Click += button1_Click;

            IAddChild container = panel;
            container.AddChild(button1);

            container = this;
            container.AddChild(panel);
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            button1.Content = "Thank you";
        }
    }
}
