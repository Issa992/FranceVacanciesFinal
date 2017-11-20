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
    class ViewModel : NotifyPropertyChange
    {
        #region properties
        
        public ObservableCollection<Customer> CustomersList { get; set; }
        public ObservableCollection<Appartment> ParisAppList { get; set; }
        public ObservableCollection<Appartment> AmsterdamAppList { get; set; }
        public ObservableCollection<Appartment> LondonAppList { get; set; }
        public RelayCommand ParisAddAppartmentCommand { get; set; }
        public RelayCommand AmsterdamAddAppartmentCommand;
        public RelayCommand LondonAddAppartmentCommand;
        public RelayCommand ParisDeleteAppartmentCommand;
        public RelayCommand AmsterdamDeleteAppartmentCommand;
        public RelayCommand LondonDeleteAppartmentCommand;
        public RelayCommand LondonUpdateAppartmentCommand;
        public RelayCommand AmsterdamUpdateAppartmentCommand;
        public RelayCommand ParisUpdateAppartmentCommand;
        public Appartment SelectedAppartment
        {
            get => _selectedApparment;
            set
            {
                _selectedApparment = value;
                OnPropertyChanged(nameof(SelectedAppartment));
            }
        }
        private Appartment _selectedApparment;
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
            AddTestables();
            AddNewAppartment = new Appartment();
            AddNewCustomer = new Customer();
            
            


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
        
        public void AddTestables()
        {
            ParisAppList.Add(new Appartment("Apartment 1", "This is just short description, that says that this is realy awesome suite", 
                45.50, false, false, true, @"Photos/ApartamentPhotos/la_house_interior_fireplace_picture_room_seat_luxury_fire_piano_table_31441_3840x2400.jpg"));
            ParisAppList.Add(new Appartment("Apartment 2", "This is just short description, that says that this is realy awesome suite", 
                22.5, false, false, true, "Photos/ApartamentPhotos/sofa_design_interior_design_apartment_room_brown_chair_bed_lamps_pillows_style_table_31489_3840x2400.jpg"));
            ParisAppList.Add(new Appartment("Apartment 3", "This is just short description, that says that this is realy awesome suite", 
                67.85, false, false, true, "Photos/ApartamentPhotos/sofa_design_interior_design_apartment_room_brown_chair_bed_pillows_style_fruit_31487_3840x2400.jpg"));
            ParisAppList.Add(new Appartment("Apartment 4", "This is just short description, that says that this is realy awesome suite",
                34.50, false, false, true, "Photos/ApartamentPhotos/sofa_design_interior_design_apartment_room_red_chair_style_31490_3840x2400.jpg"));
            ParisAppList.Add(new Appartment("Apartment 5", "This is just short description, that says that this is realy awesome suite", 
                120.5, false, false, true, "Photos/ApartamentPhotos/room_interior_design_style_design_furniture_modern_69900_3840x2400.jpg"));

        }

        #endregion
    }
}
