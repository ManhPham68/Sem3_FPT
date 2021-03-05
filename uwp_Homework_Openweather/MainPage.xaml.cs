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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace uwp_Homework_Openweather
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }
       

        [Obsolete]
        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                var position = await LocationManager.GetPosition(); //gọi từ api
                var lat = position.Coordinate.Latitude;
                var lot = position.Coordinate.Longitude;
                WeatherProxy2.Root myWeather = await WeatherProxy2.GetWeather(lat, lot);


                string icon = String.Format("ms-appx:///Assets/Weather/{0}.png", myWeather.weather[0].icon);
               ResultImage.Source = new BitmapImage(new Uri(icon, UriKind.Absolute));

                
               TempTextBlock.Text = ((int)myWeather.main.temp).ToString();
                Icon.Text = "°";
                Icon2.Text = "C";
                //
                //DescriptionTextBlock.Text = myWeather.weather[0].description;
                  LocationTextBlock.Text = myWeather.name;
                var Hour = DateTime.Now.Hour;
                var Minute = DateTime.Now.Minute;
                
                Time1TextBlock.Text = "CURRENT WEATHER";
                TimeTextBlock.Text=Hour.ToString() + ":" + Minute.ToString();
                
            }
            catch
            {
              //  LocationTextBlock.Text = "Không lấy được vị trí";
            }
        }
    }
}
