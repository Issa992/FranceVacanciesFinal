using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace MainPage.Models
{
    class Catalog
    {
      
        public ObservableCollection<Customer> CustomersList;
        public ObservableCollection<Appartment> ParisApartments;
        public ObservableCollection<Appartment> LondonApartments;
        public ObservableCollection<Appartment> AmsterdamApartments;

        public void AddCustomer(string firstname, string lastname, string mail)
        {
            CustomersList.Add(new Customer(firstname, lastname, mail));
        }
        public Customer GetCustomerByMail(string mail)
        {
            Customer returnedCust = CustomersList.First(x => x.MailAdress == mail);
            return returnedCust;

        }
        public void AddLondonApartment(string name, string description, double price, bool smoking,
            bool animals, bool kids, string image)
        {
            LondonApartments.Add(new Appartment(name, description, price, smoking, animals, kids, image));
        }
        public void AddParisApartment(string name, string description, double price, bool smoking,
            bool animals, bool kids, string image)
        {
            ParisApartments.Add(new Appartment(name, description, price, smoking, animals, kids, image));
        }
        public void AddAmsterdamApartment(string name, string description, double price, bool smoking,
            bool animals, bool kids, string image)
        {
            AmsterdamApartments.Add(new Appartment(name, description, price, smoking, animals, kids, image)); 
        }
        public Appartment GetParisAppartmentByName(string name)
        {
            Appartment returnedAppartment = ParisApartments.First(x => x.Name == name);
            return returnedAppartment;

        }
        public Appartment GetAmsterdamAppartmentByName(string name)
        {
            Appartment returnedAppartment = AmsterdamApartments.First(x => x.Name == name);
            return returnedAppartment;

        }
        public Appartment GetLondonAppartmentByName(string name)
        {
            Appartment returnedAppartment = LondonApartments.First(x => x.Name == name);
            return returnedAppartment;
        }

    }
}
