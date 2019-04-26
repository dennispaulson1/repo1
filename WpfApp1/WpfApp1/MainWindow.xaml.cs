using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using FontAwesome.WPF;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        int huzasokSzama = 0;
        FontAwesomeIcon elozoKartya = FontAwesomeIcon.None;

        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void ShowNewCardButton_Click(object sender, RoutedEventArgs e)
        {
            // System.Diagnostics.Debug.WriteLine("Megnyomták a gombot");

            UjKartyaHuzasa();

        }
        /// <summary>
        /// Egy kocka dobása és új kártya húzása a dobás alapján
        /// </summary>
        private void UjKartyaHuzasa()
        {
            huzasokSzama++;

            if (huzasokSzama == 2)
            {
                //PartiallyButton.IsEnabled = true;   később ezt visszatesszük
                YesButton.IsEnabled = true;
                NoButton.IsEnabled = true;
                ShowNewCardButton.IsEnabled = false;
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

            elozoKartya = CardPlaceRight.Icon;

            CardPlaceRight.Icon = kartyak[dobas];

            
        }

        private void PartiallyButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void YesButton_Click(object sender, RoutedEventArgs e)
        {
            YesAnswer();
        }

        private void YesAnswer()
        {
            if (elozoKartya == CardPlaceRight.Icon)
            {
                AvalaszHelyes();
            }
            else
            {
                AvalaszHelytelen();
            }
            UjKartyaHuzasa();
        }

        private void NoButton_Click(object sender, RoutedEventArgs e)
        {
            NoAnswer();

        }

        private void NoAnswer()
        {
            if (elozoKartya == CardPlaceRight.Icon)
            {
                AvalaszHelytelen();
            }
            else
            {
                AvalaszHelyes();
            }
            UjKartyaHuzasa();
        }

        private void AvalaszHelytelen()
        {
            CardPlaceLeft.Icon = FontAwesomeIcon.Times;
            
        }

        private void AvalaszHelyes()
        {
            CardPlaceLeft.Icon = FontAwesomeIcon.Check;
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            Debug.WriteLine(e.Key);
            if (e.Key == Key.Left)
            {
                NoAnswer();
            }

            if (e.Key == Key.Right)
            {
                YesAnswer();
            }

            if (e.Key == Key.Down)
            {

            }
        }
    }
}
