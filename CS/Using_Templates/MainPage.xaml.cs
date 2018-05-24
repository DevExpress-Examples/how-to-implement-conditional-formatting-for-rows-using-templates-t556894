using System;
using System.Collections.Generic;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media;

namespace Using_Templates {
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            grid.ItemsSource = new ProductList();
        }
    }

    public class RowHandleToBackgroundConverter : IValueConverter {
        public Brush EvenRowBackground { get; set; }
        public Brush OddRowBackground { get; set; }
        public object Convert(object value, Type targetType, object parameter, string language) {
            if (((int)value % 2) == 0)
                return OddRowBackground;
            else
                return EvenRowBackground;
        }
        public object ConvertBack(object value, Type targetType, object parameter, string language) {
            throw new NotImplementedException();
        }
    }
}
