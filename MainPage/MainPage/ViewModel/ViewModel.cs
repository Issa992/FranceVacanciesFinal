using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainPage.Models;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;

namespace MainPage.ViewModel
{
    class ViewModel : INotifyPropertyChanged
    {
        #region properties
        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<Customer> CustomersList { get; set; }
        public ObservableCollection<Appartment> ParisAppList { get; set; }
        public ObservableCollection<Appartment> AmsterdamAppList { get; set; }
        public ObservableCollection<Appartment> LondonAppList { get; set; }
        public RelayCommand AddAppartmentCommand;
        public RelayCommand DeleteAppartmentCommand;
        public RelayCommand UpdateAppartmentCommand;
        public Appartment SelectedAppartment
        {
            get => SelectedAppartment;
            set
            {
                SelectedAppartment = value;
                OnPropertyChanged(nameof(SelectedAppartment));
            }
        }
        public Appartment AddNewAppartment;
        public Customer AddNewCustomer;
        #endregion
        //-------------------------
        //--------Constructor------
        //-------------------------
        public ViewModel()
        {
            ParisAppList = new ObservableCollection<Appartment>();
            AmsterdamAppList = new ObservableCollection<Appartment>();
            LondonAppList = new ObservableCollection<Appartment>();
            AddNewAppartment = new Appartment();
            AddNewCustomer = new Customer();
            AddAppartmentCommand = new RelayCommand(AddParisAppartment);
            AddTestables();


        }
        //-------------------------
        //---End-Of-Constructor----
        //-------------------------

        public void AddParisAppartment()
        {
            ParisAppList.Add(AddNewAppartment);
        }
        public void AddAmsterdamAppartment()
        {
            AmsterdamAppList.Add(AddNewAppartment);
        }
        public void AddLondonAppartment()
        {
            LondonAppList.Add(AddNewAppartment);
        }





        #region Miscelenous
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public void AddTestables()
        {
           ParisAppList.Add(new Appartment("owner1", "cottage", 45.50, false, false, true, "default"));
            ParisAppList.Add(new Appartment("owner1", "cottage", 22.5, false, false, true, "default"));
            ParisAppList.Add(new Appartment("owner1", "cottage", 67.85, false, false, true, "default"));
            ParisAppList.Add(new Appartment("owner1", "cottage", 34.50, false, false, true, "default"));
            ParisAppList.Add(new Appartment("nazwa", "opis", 120.5, false, false, true, "default"));

        }

        #endregion
    }
}
