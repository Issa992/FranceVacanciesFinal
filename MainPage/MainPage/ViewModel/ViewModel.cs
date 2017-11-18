using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using MainPage.Annotations;
using MainPage.Models;

namespace MainPage.ViewModel
{
    class ViewModel : INotifyPropertyChanged
    {
        // This event fires when the model's data changes. The View will consume the event
        public event PropertyChangedEventHandler PropertyChanged;
        // The View's "Add Item" Button will bind to this property
        public RelayCommand AddItemCommand { get; set; }
        public RelayCommand RemoveItemCommand { get; set; }
        public RelayCommand RemoveAllItemCommand { get; set; }
        // The View's ListView will bind to this property
        private ObservableCollection<Appartment> _listData;
        public ObservableCollection<Appartment> ListData
        {
            get { return _listData; }
            set { _listData = value; OnPropertyChanged(); }
        }
        public ViewModel()
        {
      
            Catalog catalog = new Catalog();
            _listData= catalog.ParisApartments;
            AddItemCommand = new RelayCommand(DoAddItem);
            RemoveItemCommand = new RelayCommand(DoRemoveItem);
        
         
        }
        public void DoAddItem(object item)
        {
           
            _listData.Add((Appartment)item);
        }
        public void DoRemoveItem(object item)
        {
       

            if (_listData.Contains(item))
            {
                _listData.Remove((Appartment)item);
            }


        }
       



        [NotifyPropertyChangedInvocator]
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}

