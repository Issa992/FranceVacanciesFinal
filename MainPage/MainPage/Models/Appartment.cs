using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainPage.Models
{
    public class Appartment
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double PricePerNight { get; set; }
        public bool SmokingAllowed { get; set; }
        public bool AnimalAllowed { get; set; }
        public bool KidsAllowed { get; set; }
        public bool IsRented { get; set; }
        public string ImagePath { get; set; }
        public string OptionalImagePath1 { get; set; }
        public string OptionalImagePath2 { get; set; }
        public string OptionalImagePath3 { get; set; }
        public int BookingDuration { get; set; }

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

        public Appartment() {}
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
