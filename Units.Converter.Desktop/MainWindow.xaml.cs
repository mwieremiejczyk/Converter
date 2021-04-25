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
using Konwerter_2._0v;

namespace Units.Converter.Desktop

{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ComboBox.ItemsSource = new List<string>
            {
                "Temperatura",
                "Długość",
                "Waga",
                "Czas",
            };

            //Przyciski testowe
            Test.Visibility = Visibility.Hidden;
            Test2.Visibility = Visibility.Hidden;
            Test3.Visibility = Visibility.Hidden;
                    

        }

        string unitFromSelected;
        string unitToSelected;
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string inputValue = this.InputTextBox.Text;
            decimal value = decimal.Parse(inputValue);

            IConverter[] Converters = new IConverter[]
             {
                new TemperatureConverter(),
                new LenghtConverter(),
                new WeightConverter(),
                new TimeConverter()
             };

            decimal result = Converters[ComboBox.SelectedIndex].Convert(value, unitFromSelected, unitToSelected);
            result = Math.Round(result * 100) / 100;
            
            OutputTextBlock.Text = result.ToString();

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ComboBox.SelectedItem.Equals("Temperatura"))
            {
                B1.Content = "Celcjusze";
                B1.Name = "C";
                B4.Content = "Celcjusze";
                B4.Name = "C";
                B2.Content = "Farenheity";
                B2.Name = "F";
                B5.Content = "Farenheity";
                B5.Name = "F";
                B3.Content = "Kelwiny";
                B3.Name = "K";
                B6.Content = "Kelwiny";
                B6.Name = "K";
            }

            if (ComboBox.SelectedItem.Equals("Czas"))
            {
                B1.Content = "Sekundy";
                B1.Name = "s";
                B4.Content = "Sekundy";
                B4.Name = "s";
                B2.Content = "Minuty";
                B2.Name = "m";
                B5.Content = "Minuty";
                B5.Name = "m";
                B3.Content = "Godziny";
                B3.Name = "h";
                B6.Content = "Godziny";
                B6.Name = "h";
            }

            if (ComboBox.SelectedItem.Equals("Długość"))
            {
                B1.Content = "Metry";
                B1.Name = "M";
                B4.Content = "Metry";
                B4.Name = "M";
                B2.Content = "Kilometry";
                B2.Name = "Km";
                B5.Content = "Kilometry";
                B5.Name = "Km";
                B3.Content = "Mile";
                B3.Name = "Mile";
                B6.Content = "Mile";
                B6.Name = "Mile";
            }

            if (ComboBox.SelectedItem.Equals("Waga"))
            {
                B1.Content = "Gramy";
                B1.Name = "G";
                B4.Content = "Gramy";
                B4.Name = "G";
                B2.Content = "Kilogramy";
                B2.Name = "Kg";
                B5.Content = "Kilogramy";
                B5.Name = "Kg";
                B3.Content = "Tony";
                B3.Name = "T";
                B6.Content = "Tony";
                B6.Name = "T";
            }
            Test3.Content = ComboBox.SelectedIndex;
        }

       
        bool pressed = false;
        private void B1_Click(object sender, RoutedEventArgs e)
        {
            
            if(pressed==false)
            {
                pressed = true;
                B1.Background = Brushes.Gold;
                unitFromSelected = B1.Name;
                Test.Content = unitFromSelected;

                B4.IsEnabled = false;
                B5.IsEnabled = true;
                B6.IsEnabled = true;
                pressed2 = false;
                pressed3 = false;
                B2.Background = Brushes.LightGray;
                B3.Background = Brushes.LightGray;
            }
            else if(pressed==true)
            {
                pressed = false;
                B1.Background = Brushes.LightGray;

            }
        }

        bool pressed2 = false;
        private void B2_Click(object sender, RoutedEventArgs e)
        {

            if (pressed2 == false)
            {
                pressed2 = true;
                B2.Background = Brushes.Gold;
                unitFromSelected = B2.Name;
                Test.Content = unitFromSelected;

                B5.IsEnabled = false;
                B4.IsEnabled = true;
                B6.IsEnabled = true;
                pressed = false;
                pressed3 = false;
                B3.Background = Brushes.LightGray;
                B1.Background = Brushes.LightGray;
            }
            else if (pressed2 == true)
            {
                pressed2 = false;
                B2.Background = Brushes.LightGray;
            }
        }

        bool pressed3 = false;
        private void B3_Click(object sender, RoutedEventArgs e)
        {

            if (pressed3 == false)
            {
                pressed3 = true;
                B3.Background = Brushes.Gold;
                unitFromSelected = B3.Name;
                Test.Content = unitFromSelected;

                B6.IsEnabled = false;
                B5.IsEnabled = true;
                B4.IsEnabled = true;
                pressed2 = false;                
                pressed = false;
                B2.Background = Brushes.LightGray;
                B1.Background = Brushes.LightGray;
            }
            else if (pressed3 == true)
            {
                pressed3 = false;
                B3.Background = Brushes.LightGray;
            }
        }

        bool pressed4 = false;
        private void B4_Click(object sender, RoutedEventArgs e)
        {
            if (pressed4 == false)
            {
                pressed4 = true;
                B4.Background = Brushes.Gold;
                unitToSelected = B4.Name;
                Test2.Content = unitToSelected;

                pressed5 = false;
                pressed6 = false;
                B5.Background = Brushes.LightGray;
                B6.Background = Brushes.LightGray;

            }
            else if (pressed4 == true)
            {
                pressed4 = false;
                B4.Background = Brushes.LightGray;
            }
        }

        bool pressed5 = false;
        private void B5_Click(object sender, RoutedEventArgs e)
        {
            if (pressed5 == false)
            {
                pressed5 = true;
                B5.Background = Brushes.Gold;
                unitToSelected = B5.Name;
                Test2.Content = unitToSelected;

                pressed4 = false;
                pressed6 = false;
                B4.Background = Brushes.LightGray;
                B6.Background = Brushes.LightGray;
            }
            else if (pressed5 == true)
            {
                pressed5 = false;
                B5.Background = Brushes.LightGray;
            }
        }

        bool pressed6 = false;
        private void B6_Click(object sender, RoutedEventArgs e)
        {
            if (pressed6 == false)
            {
                pressed6 = true;
                B6.Background = Brushes.Gold;
                unitToSelected = B6.Name;
                Test2.Content = unitToSelected;

                pressed5 = false;
                pressed4 = false;
                B5.Background = Brushes.LightGray;
                B4.Background = Brushes.LightGray;
            }
            else if (pressed6 == true)
            {
                pressed6 = false;
                B6.Background = Brushes.LightGray;
            }
        }
    }
}
