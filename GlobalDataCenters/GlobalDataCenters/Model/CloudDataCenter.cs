using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Networking;

namespace GlobalDataCenters
{
    public class CloudDataCenter
    {
        public string Cloud { get; set; }
        public double SoutheastAsia { get; set; }
        public double NorthAmerica { get; set; }
        public double Europe { get; set; }
        public double Others { get; set; }

        // For Data Labels
        private double Total => SoutheastAsia + NorthAmerica + Europe + Others;
        public string SoutheastAsiaValue => $"{SoutheastAsia} ({((SoutheastAsia / Total) * 100):F0}%)";
        public string NorthAmericaValue => $"{NorthAmerica} ({((NorthAmerica / Total) * 100):F0}%)";
        public string EuropeValue => $"{Europe} ({((Europe / Total) * 100):F0}%)";
        public string OthersValue => $"{Others} ({((Others / Total) * 100):F0}%)";
    }
}
