using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pogoda
{
    class PogodaWA
    {
        public class location
        {
            public string name { get; set; }
        }
        public class current
        {
            public double temp_c { get; set; }
            public double wind_mph { get; set; }
            public double pressure_mb { get; set; }
            public class condition
            {
                public string text { get; set; }
            }
        }

        public class rootWA
        {
            public location location { get; set; }
            public List <PogodaWA> weatherWA { get; set; }
            public current current { get; set; }
            public current.condition condition { get; set; }
        }
    }
}
