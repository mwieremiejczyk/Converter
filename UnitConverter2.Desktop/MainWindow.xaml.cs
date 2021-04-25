using ConverterDB;
using Konwerter_2._0v;
using LoadDb;
using System;
using System.Windows;
using System.Windows.Controls;
using UnitConverter.Logic;

namespace UnitConverter2.Desktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ConverterComboBox.ItemsSource = new ConverterService().GetConverters();
            FiltrComboBox.ItemsSource = new ConverterService().GetConverters();

        }

        

        private void ConverterComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UnitFromComboBox.ItemsSource = ((IConverter)ConverterComboBox.SelectedItem).Units;
            UnitToComboBox.ItemsSource = ((IConverter)ConverterComboBox.SelectedItem).Units;
        }

        private void ConverterButton_Click(object sender, RoutedEventArgs e)
        {
            string inputText = inputTextBox.Text;
            decimal value = Convert.ToDecimal(inputText);

            decimal result;
            result=((IConverter)ConverterComboBox.SelectedItem).Convert
                (
                value,
                UnitFromComboBox.SelectedItem.ToString(),
                UnitToComboBox.SelectedItem.ToString()
                );
            OutputTextBlock.Text = result.ToString();

            AddNewLog obiekt = new AddNewLog();
            obiekt.InsertLog(((IConverter)ConverterComboBox.SelectedItem).Name, UnitToComboBox.SelectedItem.ToString(), UnitFromComboBox.SelectedItem.ToString(), Convert.ToDouble(value));
                       
        }

        private void LoadDbButton_Click(object sender, RoutedEventArgs e)
        {
            LoadDB newloaddb = new LoadDB();
            DataGridWindow.ItemsSource = newloaddb.LogList;
        }

        private void FilterButton_Click(object sender, RoutedEventArgs e)
        {

            Filters FiltredDB = new Filters(DataFromDatePicker.SelectedDate.Value, DataToDatePicker.SelectedDate.Value, ((IConverter)FiltrComboBox.SelectedItem).Name, (bool)TopCheckBox.IsChecked);
            DataGridWindow.ItemsSource = FiltredDB.LogList;
        }
    }
}
