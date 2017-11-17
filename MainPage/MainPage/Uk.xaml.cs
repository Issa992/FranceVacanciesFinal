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
    public sealed partial class Uk : Page
    {
        public Uk()
        {
            this.InitializeComponent();
        }
        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }


        private void HyperlinkButton_Click1(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WebBrowser.Source = new Uri("ms-appx-web:///HTMLPage.html");

            WebBrowser.Navigate(new Uri("https://wego.here.com/search/london%2520hotels?map=51.4829,-0.08472,12,normal&x=ep"));
        }

        private void AppBarButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void NavigatToLondonFlat()
        {

            ConnectedAnimationService.GetForCurrentView().PrepareToAnimate("image", DestinationImageUk);
            Frame.Navigate(typeof(LondonFlat));
        }

        private void DestinationImagee_SelectionChangedUk(object sender, SelectionChangedEventArgs e)
        {
            NavigatToLondonFlat();
        }
    }
}
