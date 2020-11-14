using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
namespace APS.Models
{
    public class IBGE
    {
        public Object getNoticia()
        {
            string url = "https://servicodados.ibge.gov.br/api/v3/noticias/?ate=15/10/2020";
            //synchronous client.
            var client = new WebClient();
            var content = client.DownloadString(url);
            var serializer = new JavaScriptSerializer();
            var jsonContent = serializer.Deserialize<Object>(content);
            return jsonContent;
        }
    }
}