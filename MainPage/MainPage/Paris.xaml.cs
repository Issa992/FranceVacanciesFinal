using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace MainPage
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Paris : Page
    {
        public Paris()
        {
            this.InitializeComponent();
        }

        private void HyperlinkButton_Click1(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WebBrowser.Source = new Uri("ms-appx-web:///HTMLPage.html");

            WebBrowser.Navigate(new Uri("https://wego.here.com/search/paris%2520hotels?map=48.85735,2.34233,16,normal"));
        }




        private void ForegroundElement_OnItemClick(object sender, ItemClickEventArgs e)
        {
            throw new NotImplementedException();
        }



        private void NavigatToParisFlat()
        {

            ConnectedAnimationService.GetForCurrentView().PrepareToAnimate("image", DestinationImage);
            Frame.Navigate(typeof(ParisFlat));
        }









        private void apoop(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DestinationImagee_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            NavigatToParisFlat();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigatToParisFlat();
        }
    }
}
