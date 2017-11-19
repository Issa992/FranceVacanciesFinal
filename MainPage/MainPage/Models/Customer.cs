using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainPage.Models
{
    class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MailAdress { get; set; }
        public double MoneySpent { get; set; }
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
        public Customer() { }
        public void UpDate(string firstname, string lastname, string mail)
        {
            FirstName = firstname;
            LastName = lastname;
            MailAdress = mail;
        }
    }
}
