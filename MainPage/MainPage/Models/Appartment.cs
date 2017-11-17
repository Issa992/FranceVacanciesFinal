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
        public string OptionalImagePath1;
        public string OptionalImagePath2;
        public string OptionalImagePath3;
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
        #region constructor
        public Appartment(string name, string description, double price, bool smoking,
            bool animals, bool kids, string image)
        {
            Name = name; Description = description; PricePerNight = price;
            SmokingAllowed = smoking; AnimalAllowed = animals; ImagePath = image;
        }
        public Appartment(string name, string description, double price, bool smoking,
            bool animals, bool kids, string image, string image1)
        {
            Name = name; Description = description; PricePerNight = price;
            SmokingAllowed = smoking; AnimalAllowed = animals; ImagePath = image;
            OptionalImagePath1 = image1; OptionalImagePath2 = null; OptionalImagePath3 = null;

        }
        public Appartment(string name, string description, double price, bool smoking,
            bool animals, bool kids, string image, string image1, string image2)
        {
            Name = name; Description = description; PricePerNight = price;
            SmokingAllowed = smoking; AnimalAllowed = animals; ImagePath = image;
            OptionalImagePath1 = image1; OptionalImagePath2 = image2; OptionalImagePath3 = null;

        }
        public Appartment(string name, string description, double price, bool smoking,
            bool animals, bool kids, string image, string image1, string image2, string image3)
        {
            Name = name; Description = description; PricePerNight = price;
            SmokingAllowed = smoking; AnimalAllowed = animals; ImagePath = image;
            OptionalImagePath1 = image1; OptionalImagePath2 = image2; OptionalImagePath3 = image3;
        }
#endregion
        public void UpDate(string name, string description, double price, bool smoking,
            bool animals, bool kids, string image)
        {
            Name = name; Description = description; PricePerNight = price;
            SmokingAllowed = smoking; AnimalAllowed = animals; ImagePath = image;
            
        }
    }
}
