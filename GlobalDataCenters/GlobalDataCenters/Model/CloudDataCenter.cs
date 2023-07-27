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
        public double[] SoutheastAsia { get; set; }
        public double[] NorthAmerica { get; set; }
        public double[] Europe { get; set; }
        public double[] Others { get; set; }

        //For Data Labels
        public string SoutheastAsiaValue => $"{SoutheastAsia[0]} ({SoutheastAsia[1]}%)";
        public string NorthAmericaValue => $"{NorthAmerica[0]} ({NorthAmerica[1]}%)";
        public string EuropeValue => $"{Europe[0]} ({Europe[1]}%)";
        public string OthersValue => $"{Others[0]} ({Others[1]}%)";
    }
}
