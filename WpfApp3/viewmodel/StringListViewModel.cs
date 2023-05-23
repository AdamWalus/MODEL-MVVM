using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp3.model;

namespace WpfApp3.viewmodel
{
    public class StringListViewModel : INotifyPropertyChanged
    {

        public string _newItem;
        //private ObservableCollection<string> _items;
        private StringListModel _model;
        private string _selectedItem;

        public StringListViewModel(StringListModel model)
        {
            _model = model;
        }
       
        public ObservableCollection<string> Items
        {
            get { return _model.Items; }
            set { _model.Items= value;
                OnPropertyChange(nameof(NewItem));
            }
        }


        public string SelectedItem
        {
            get { return _selectedItem; }
            set { _selectedItem = value;
                OnPropertyChange(nameof(NewItem));
            }
        }
        
        public string NewItem
        {
            get { return _newItem; }
            set { _newItem = value;
                OnPropertyChange(nameof(NewItem));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChange(string propertyName)
        {
            if (PropertyChanged != null)
            {
               PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
