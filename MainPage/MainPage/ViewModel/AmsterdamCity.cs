using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainPage.Models;

namespace MainPage.ViewModel
{
    class AmsterdamCity
    {

        private ObservableCollection<Appartment> ApartmentList;

        public AmsterdamCity()
        {
            Catalog catalog = new Catalog();
            catalog.AddAmsterdamApartment("Random", "The best Apartment in Amsterdam", 1000,
                true, true, true, "../assets/Photos/la_house_interior_fireplace_picture_room_seat_luxury_fire_piano_table_31441_3840x2400.jpg");
            ApartmentList = catalog.AmsterdamApartments;

        }
    }
}
