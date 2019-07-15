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

namespace MergersAcquisitions
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

        private void M_A_Click(object sender, RoutedEventArgs e)
        {
            MergerAnalysis MergerAnalysisObject = new MergerAnalysis();
            MergerAnalysisObject.Show();
        }

        private void Raising_Capital_Example_for_an_Acquisition_Click(object sender, RoutedEventArgs e)
        {
            RaisingCapital RaisingCapitalObject = new RaisingCapital();
            RaisingCapitalObject.Show();
        }

        private void FormA_Click(object sender, RoutedEventArgs e)
        {
            FormingACorporation FormingACorporationObject = new FormingACorporation();
            FormingACorporationObject.Show();
        }

        private void RichTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
         }
    }
}
