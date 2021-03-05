using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Geolocation;

namespace uwp_Homework_Openweather
{
   public class LocationManager
    {
        public static async Task<Geoposition> GetPosition(){
            var trangthai = await Geolocator.RequestAccessAsync();
            if (trangthai != GeolocationAccessStatus.Allowed) throw new Exception();
            var dinhvi = new Geolocator { DesiredAccuracyInMeters = 0 };
            var vitri = await dinhvi.GetGeopositionAsync();
            
            return vitri;
        }
    }
}
