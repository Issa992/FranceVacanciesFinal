using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace MainPage.Models
{
    class Booking
    {
        public Booking(Appartment apartment, Customer customer, int days)
        {
            apartment.Booking(days);
            customer.UpDate(days * apartment.PricePerNight);
            LogFile($"{customer.FirstName} {customer.LastName} rented {apartment.Name}");
        }
        public async void LogFile(string text)
        {
            StorageFolder folder = ApplicationData.Current.LocalFolder;
            StorageFile file = await folder.CreateFileAsync("Logs.txt", CreationCollisionOption.OpenIfExists);
            string time = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss.fff");
            await FileIO.WriteTextAsync(file,$"{time}      {text}\n");
        }
    }
}
