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
             new CloudDataCenter() { Cloud = "Microsoft", SoutheastAsia = 31,NorthAmerica = 37,Europe = 32, Others = 18},
             new CloudDataCenter() { Cloud = "Amazon", SoutheastAsia = 21, NorthAmerica = 25,Europe = 18, Others = 12},
             new CloudDataCenter() { Cloud = "Google", SoutheastAsia = 24, NorthAmerica = 25, Europe = 18, Others = 6 },
             new CloudDataCenter() { Cloud = "Alibaba", SoutheastAsia = 49, NorthAmerica = 4, Europe = 4, Others = 3},
             new CloudDataCenter() { Cloud = "IBM", SoutheastAsia = 8, NorthAmerica = 28, Europe = 18, Others = 6 },
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
