using Fußball_Lib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Fußball_WPF
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Player> _obsPlayer;
        public MainWindow()
        {
            InitializeComponent();
            _obsPlayer = new ObservableCollection<Player>();

            // Zugriff auf WCF
            string htp = $"";
          
        }

        private void btnPlay01_Click(object sender, RoutedEventArgs e)
        {
            labPla11.Content = "sers";
        }
    }
}
