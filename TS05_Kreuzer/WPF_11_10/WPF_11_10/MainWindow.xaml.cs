using Konsole_11_10;
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

namespace WPF_11_10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DAL m_DAL;
        private ObservableCollection<Familie> m_obsFamilie;

        public MainWindow()
        {
            InitializeComponent();
            m_obsFamilie = new ObservableCollection<Familie>();
            m_DAL = new DAL();

            lbx1.ItemsSource = m_obsFamilie;
            dgr1.ItemsSource = m_obsFamilie;
        }

        private void btnFamiliennameSpeichern_Click(object sender, RoutedEventArgs e)
        {
            string nachname = tbxFamilienname.Text;
            m_DAL.AddFamilyName(nachname);
        }

        private void btnFamilieSpeichern_Click(object sender, RoutedEventArgs e)
        {
            string nachname = tbxFamilienname.Text;
            string mann = tbxMann.Text;
            string frau = tbxFrau.Text;

            Familie familie = new Familie(nachname, mann, frau);
            m_DAL.AddFammly(nachname, mann, frau);
            m_obsFamilie.Add(familie);
        }

        private void btnXmlSpeichern_Click(object sender, RoutedEventArgs e)
        {
            m_DAL.SpeicherDOM("Familien.xml");
        }
    }
}
