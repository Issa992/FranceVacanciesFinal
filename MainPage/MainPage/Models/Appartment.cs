using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainPage.Models
{
    class Appartment
    {
        public string Name;
        public string Description;
        public double PricePerNight;
        public bool SmokingAllowed;
        public bool AnimalAllowed;
        public bool KidsAllowed;
        public bool IsRented;
        public string ImagePath;
        public int BookingDuration;

        public void Booking (int days)
        {
            BookingDuration = days;
            IsRented = true;
        }
        public void FreeApartment()
        {
            BookingDuration = 0;
            IsRented = false;
        }

    }
}
