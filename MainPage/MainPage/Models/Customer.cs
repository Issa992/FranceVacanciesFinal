using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainPage.Models
{
    class Customer
    {
        public string FirstName;
        public string LastName;
        public string MailAdress;
        public double MoneySpent;
        public void UpDate(double moneyspent)
        {
            MoneySpent = +moneyspent;
        }
        public Customer(string firstname, string lastname, string mail)
        {
            FirstName = firstname;
            LastName = lastname;
            MailAdress = mail;
        }
        public void UpDate(string firstname, string lastname, string mail)
        {
            FirstName = firstname;
            LastName = lastname;
            MailAdress = mail;
        }
    }
}
