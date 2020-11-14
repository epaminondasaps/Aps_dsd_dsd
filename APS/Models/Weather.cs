using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace WeatherApp.Models
{
    class Weather
    {
        public Object getWeatherForcast()
        {
   
            string url = "https://api.openweathermap.org/data/2.5/weather?q=Sao Paulo,br&APPID=69e397237ab04eba6288d7d4cd7f233c&units=metric";
            //synchronous client.
            var client = new WebClient();
            var content = client.DownloadString(url);
            var serializer = new JavaScriptSerializer();
            var jsonContent = serializer.Deserialize<Object>(content);
            return jsonContent;
        }       
    }
}
