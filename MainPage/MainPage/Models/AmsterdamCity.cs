using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace MainPage.Models
{
    class AmsterdamCity
    {
        public ObservableCollection<Appartment> AmsterdamApartments;

        public void AddApartment()
        {
            AmsterdamApartments.Add(new Appartment());
        }
        public void RemoveApartment(string name)
        {
            Appartment apartment = AmsterdamApartments.First(x => x.Name == name);
            AmsterdamApartments.Remove(apartment);
        }
    }
}
