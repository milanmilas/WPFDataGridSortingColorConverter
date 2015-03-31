using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
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

namespace GridSortingWithColorConverter
{
    public class SimpleBrushColorConverter : IValueConverter
    {
        public object Convert(object values, Type targetType, object parameter, CultureInfo culture)
        {
            Debug.WriteLine("Simple Converter Called: " + values + " , " + values);
            if ((int)values < 18) return new SolidColorBrush(Color.FromRgb(250, 0, 0));
            if (60 > (int)values && (int)values > 18) return new SolidColorBrush(Color.FromRgb(0, 250, 0));
            return new SolidColorBrush(Color.FromRgb(0, 0, 250));
        }

        public object ConvertBack(object value, Type targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		PeopleViewModel vm = new PeopleViewModel();
		public MainWindow()
		{
			InitializeComponent();

			DataContext = vm;
		}

		private void OnCellMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			Debug.WriteLine("");
			Debug.WriteLine("Age Incremented");
			vm.People.First().Age++;
		}
	}
}
