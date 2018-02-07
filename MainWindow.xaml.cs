/*
 Aiden Jolley Ruhn
 Febuary 6, 2018
 U1_01_AidenJ
 Hello World - My First Program
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace u1_01_AidenJRWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btnClickme_Click(object sender, RoutedEventArgs e)
        {
            lbloutput.Content = "Hey bb <3";

        }

        private void btnClickme_IsMouseDirectlyOverChanged(object sender, DependencyPropertyChangedEventArgs e)
        {

        }

        private void btnClickme_StylusEnter(object sender, StylusEventArgs e)
        {

        }
    }
}
