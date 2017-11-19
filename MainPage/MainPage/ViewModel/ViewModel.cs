using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using MainPage.Annotations;
using MainPage.Models;

namespace MainPage.ViewModel
{
    public sealed class ViewModel : INotifyPropertyChanged
    {
        // This event fires when the model's data changes. The View will consume the event
        public event PropertyChangedEventHandler PropertyChanged;
        // The View's "Add Item" Button will bind to this property
        public RelayCommand AddItemCommand { get; set; }
        public RelayCommand RemoveItemCommand { get; set; }

       
       
        // The View's ListView will bind to this property

       

        public ObservableCollection<Appartment> ListData { get; set; }
      


        public ViewModel()
        {
         
          ListData=new ObservableCollection<Appartment>()
          {
              new Appartment("Name1", "description1", 23, true, true, true, "Photos/ApartamentPhotos/1.jpg"),
              new Appartment("Name2", "description2", 232, true, true, true, "Photos/ApartamentPhotos/interior_flat_house_creative_white_11104_3840x2400.jpg"),
              new Appartment("Name3", "description3", 233, true, true, true, "Photos/ApartamentPhotos/la_house_interior_fireplace_picture_room_seat_luxury_fire_piano_table_31441_3840x2400.jpg"),
              new Appartment("Name4", "description4", 234, true, true, true, "Photos/ApartamentPhotos/paper_vase_sofa_design_interior_fireplace_painting_apartment_room_chair_lamp_plant_style_table_cup_31419_3840x2400.jpg"),
              
              
        };

            //AddItemCommand = new RelayCommand(DoAddItem);
            //RemoveItemCommand = new RelayCommand(DoRemoveItem);
       
          
        }

        //public void DoAddItem()
        //{
        //    ListData.Add();
        //}
        //public void DoRemoveItem(object item)
        //{

        //    ListData.Remove();

        //}

        [NotifyPropertyChangedInvocator]
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
