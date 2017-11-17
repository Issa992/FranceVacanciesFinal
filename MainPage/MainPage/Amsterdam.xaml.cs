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
    public sealed partial class Amsterdam : Page
    {
        public Amsterdam()
        {
            this.InitializeComponent();
        }

        private void HyperlinkButton_Click1(Object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Button_Click(Object sender, RoutedEventArgs e)
        {
            WebBrowser.Source = new Uri("ms-appx-web:///HTMLPage.html");

            WebBrowser.Navigate(new Uri("https://wego.here.com/search/Amsterdam%2520hotels?map=52.36713,4.89911,13,normal&x=ep"));
        }

        private void AppBarButton_Click(object sender, RoutedEventArgs e)
        {
            NavigatToAmsterdamFlat();

        }
        private void NavigatToAmsterdamFlat()
        {

            ConnectedAnimationService.GetForCurrentView().PrepareToAnimate("image", DestinationImageAm);
            Frame.Navigate(typeof(AmsterdamFlat));
        }

        private void DestinationImageAm_SelectionChangedAm(object sender, SelectionChangedEventArgs e)
        {
            NavigatToAmsterdamFlat();


        }
    }
}
