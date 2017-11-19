using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainPage.Models;

namespace MainPage.ViewModel
{
    public class ParisCity
    {
        public ObservableCollection<Appartment> ApartmentList { get; set; }

        public ParisCity()
        {   
            Catalog catalog = new Catalog();
            catalog.AddParisApartment("Marina", "The best Apartment in France", 1200,
                true, true, true, "../Photos/1.jpg");
            ApartmentList = catalog.ParisApartments;

        }


    }
}
