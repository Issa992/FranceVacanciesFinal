using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace MainPage.Models
{
    class LondonCity
    {
        public ObservableCollection<Appartment> LondonApartments;

        public void AddApartment()
        {
            LondonApartments.Add(new Appartment());
        }
        public void RemoveApartment(string name)
        {
            Appartment apartment = LondonApartments.First(x => x.Name == name);
            LondonApartments.Remove(apartment);
        }
    }
}
