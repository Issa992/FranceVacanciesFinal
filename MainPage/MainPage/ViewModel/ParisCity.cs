using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainPage.Models;

namespace MainPage.ViewModel
{
    class ParisCity
    {
        private ObservableCollection<Appartment> ApartmentList;

        public ParisCity()
        {   
            Catalog catalog = new Catalog();
            catalog.AddParisApartment("Marina", "The best Apartment in France", 1200,
                true, true, true, "../assets/Photos/1.jpg");
            ApartmentList = catalog.ParisApartments;

        }
        

    }
}
