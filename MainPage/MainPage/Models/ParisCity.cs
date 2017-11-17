using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace MainPage.Models
{
    class ParisCity
    {
        public ObservableCollection<Appartment> ParisApartments;

        public void AddApartment()
        {
            ParisApartments.Add(new Appartment());
        }
        public void RemoveApartment(string name)
        {
            Appartment apartment = ParisApartments.First(x => x.Name == name);
            ParisApartments.Remove(apartment);
        }
    }
}
