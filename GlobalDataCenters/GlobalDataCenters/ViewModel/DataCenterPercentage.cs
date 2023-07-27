using ABI.Windows.Foundation;
using Microsoft.UI.Xaml.Media;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;

namespace GlobalDataCenters
{
    public class DataCenterPercentage
    {
        public ObservableCollection<CloudDataCenter> CloudData { get; set; }
        public List<Brush> CustomBrushes { get; set; }

        public DataCenterPercentage()
        {
            CloudData = new ObservableCollection<CloudDataCenter>()
             {
             new CloudDataCenter() { Cloud = "Microsoft", SoutheastAsia = 31,SoutheastAsiaPercentage=26.27, NorthAmerica = 37,NorthAmericaPercentage=31.36, Europe = 32,EuropePercentage=27.12, Others = 18,OthersPercentage=15.25},
             new CloudDataCenter() { Cloud = "Amazon", SoutheastAsia = 21,SoutheastAsiaPercentage=27.63, NorthAmerica = 25, NorthAmericaPercentage=32.89,Europe = 18,EuropePercentage= 23.68, Others = 12,OthersPercentage=15.79 },
             new CloudDataCenter() { Cloud = "Google", SoutheastAsia = 24,SoutheastAsiaPercentage=32.88, NorthAmerica = 25,NorthAmericaPercentage=34.25, Europe = 18, EuropePercentage=24.66,Others = 6,OthersPercentage=8.21 },
             new CloudDataCenter() { Cloud = "Alibaba", SoutheastAsia = 49,SoutheastAsiaPercentage=81.66, NorthAmerica = 4,NorthAmericaPercentage=6.67, Europe = 4,EuropePercentage= 6.67, Others = 3,OthersPercentage=5 },
             new CloudDataCenter() { Cloud = "IBM", SoutheastAsia = 8,SoutheastAsiaPercentage=13.33, NorthAmerica = 28,NorthAmericaPercentage= 46.67, Europe = 18,EuropePercentage=30, Others = 6 ,OthersPercentage=10},
              };

            CustomBrushes = new List<Brush>()
            {
                 new SolidColorBrush(Color.FromArgb(0xFF, 0x00, 0x81, 0xFF)),
                 new SolidColorBrush(Color.FromArgb(0xFF, 0x8C, 0xDB, 0x07)),
                 new SolidColorBrush(Color.FromArgb(0xFF, 0xAF, 0x00, 0xFB)),
                 new SolidColorBrush(Color.FromArgb(0xFF, 0xFF, 0xC5, 0x1E)),
            };
        }
    }
}
