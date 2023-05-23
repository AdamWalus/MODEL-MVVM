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
using System.Windows.Shapes;
using WpfApp3.model;
using WpfApp3.viewmodel;

namespace WpfApp3.view
{
    /// <summary>
    /// Logika interakcji dla klasy appWindow.xaml
    /// </summary>
    public partial class appWindow : Window
    {
        private StringListViewModel _stringListViewModel;
        public appWindow()
        {
            InitializeComponent();



            var model = new StringListModel
            {
                Items = new ObservableCollection<string>
                {
                    "A",
                    "B",
                    "C",
                    "D",
                },

            };
            
            _stringListViewModel = new StringListViewModel(model)
            {
                SelectedItem = "vb"
        };
            DataContext = _stringListViewModel;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _stringListViewModel.Items.Add(_stringListViewModel.NewItem);
        }
    }
}
