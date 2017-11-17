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
        double MoneySpent;
        public void UpDate(double moneyspent)
        {
            MoneySpent = +moneyspent;
        }
    }
}
