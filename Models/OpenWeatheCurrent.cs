using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiMeteoApp.NewFolder1
{
    public class OpenWeatheCurrent
    {
        public int Cod { get; set; }
        public string Name { get; set; }
        public string Message { get; set; }
        public Main Main { get; set; }
        public List<Weather> Weathers { get; set; }
    }

    public class Weather
    {
        public string Icon { get; set; }
    }

    public class Main
    {
        public string Temp { get; set; }
    }

}
