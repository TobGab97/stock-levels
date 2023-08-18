using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace stock_levels
{
    internal class Grabber
    {
        public class Rootobject
        {
            public Stocks[] stock { get; set; }
        }

        public class Stocks
        {
            public string serial_number { get; set; }
            public int quantity { get; set; }
            public string row { get; set; }
            public int column { get; set; }
            public DateTime added_at { get; set; }

            public const string TodayA = "http://api.nbp.pl/api/exchangerates/tables/a/today?format=json";

            public static List<Stocks> GetDataFromURL(string url)
            {

                string json = Encoding.UTF8.GetString(new WebClient().DownloadData(url));

                return JsonConvert.DeserializeObject<List<Stocks>>(json);
            }

        }

    }
}
