using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainPage.Models;

namespace MainPage.ViewModel
{
    class LondonCity
    {
        private ObservableCollection<Appartment> ApartmentList;

        public LondonCity()
        {
            Catalog catalog = new Catalog();
            catalog.AddLondonApartment("Eye", "The best Apartment in London", 2200,
                true, true, false, "../assets/Photos/interior_flat_house_creative_white_11104_3840x2400.jpg");
            ApartmentList = catalog.LondonApartments;

        }
    }
}
