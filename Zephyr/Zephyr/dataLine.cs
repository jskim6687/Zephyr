using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zephyr
{
    class dataLine
    {
        public string id { get; set; }
        public string date { get; set; }
        public string time { get; set; }
        public int rawTemperature { get; set; }
        public int rawPressure { get; set; }
        public int Pressure { get; set; }
        public double altitude { get; set; }
        public double temperature { get; set; }
    }
}
