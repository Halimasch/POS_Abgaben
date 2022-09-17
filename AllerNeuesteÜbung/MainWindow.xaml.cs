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
using AllerNeuesteKonsolenAnwendung;
using AllerNeuesteÜbung;

namespace AllerNeuesteÜbung
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DAL _DAL;
        private ObservableCollection<Lotterie> _Lotto;
        
        public MainWindow()
        {
            InitializeComponent();
            _DAL = new DAL();
            _Lotto = new ObservableCollection<Lotterie>();

            dataGrid1.ItemsSource = _Lotto;
        }

        //  Starte Lotterie
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            _DAL.GenerateNewDOM();
            txtBoxVorname.Background = Brushes.White;

        }
        // Beende Lotterie 
        private void MenuItem_Click2(object sender, RoutedEventArgs e)
        {
            _DAL.SaveDOM();
            txtBoxVorname.Background = Brushes.Black;
        }

        private void btnRegistrierung_Click(object sender, RoutedEventArgs e)
        {
            string vorname = txtBoxVorname.Text;
            string nachname = txtBoxNachname.Text;
            int plz = Convert.ToInt32(txtBoxPLZ.Text);
            string ort = txtBoxOrt.Text;

            _DAL.RegisterPlayer(vorname, nachname, plz, ort);
        }

        private void btnTippsSpeichern_Click(object sender, RoutedEventArgs e)
        {
            List<int> tipps = new List<int>();
           
            int tipp1 = Convert.ToInt32(txtBoxTipp1.Text);
            int tipp2 = Convert.ToInt32(txtBoxTipp2.Text);
            int tipp3 = Convert.ToInt32(txtBoxTipp3.Text);

            tipps.Add(tipp1);
            tipps.Add(tipp2);
            tipps.Add(tipp3);

            //tipps.AddRange(new List<int>
            //{
            //    tipp1, tipp2, tipp3
            //}
            //);

            // Tipps in eine ObservableCollection
            Lotterie l = new Lotterie(tipps);

            _Lotto.Add(l);

            dataGrid1.ItemsSource = _Lotto;
        }

        private void btnNeuerTeilnehmer_Click(object sender, RoutedEventArgs e)
        {
            _DAL.DeleteAllPlayers();

        }

       
    }
}
