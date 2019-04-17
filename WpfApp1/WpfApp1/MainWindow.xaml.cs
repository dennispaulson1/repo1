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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        int huzasokSzama = 0;
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ShowNewCardButton_Click(object sender, RoutedEventArgs e)
        {
            // System.Diagnostics.Debug.WriteLine("Megnyomták a gombot");

            huzasokSzama++;

            if (huzasokSzama == 2)
            {
                PartiallyButton.IsEnabled = true;
                YesButton.IsEnabled = true;
                NoButton.IsEnabled = true;
            }

            // Kell egy 6 lapos kártya csomag

            var kartyak = new FontAwesome.WPF.FontAwesomeIcon[6];
            kartyak[0] = FontAwesome.WPF.FontAwesomeIcon.Car;
            kartyak[1] = FontAwesome.WPF.FontAwesomeIcon.SnowflakeOutline;
            kartyak[2] = FontAwesome.WPF.FontAwesomeIcon.Briefcase;
            kartyak[3] = FontAwesome.WPF.FontAwesomeIcon.Book;
            kartyak[4] = FontAwesome.WPF.FontAwesomeIcon.Male;
            kartyak[5] = FontAwesome.WPF.FontAwesomeIcon.Female;

            // Dobunk egy dobókockával

            var dobokocka = new Random();
            var dobas = dobokocka.Next(0, 5);


            // amelyik kártyát kijelöli a kocka, megjelenítjük a jobboldali kártyahelyen
            CardPlaceRight.Icon = kartyak[dobas];

            
        }
    }
}
