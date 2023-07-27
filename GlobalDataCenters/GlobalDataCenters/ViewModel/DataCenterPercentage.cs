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
                new CloudDataCenter()
        {
            Cloud = "Microsoft",
            SoutheastAsia = new double[] { 31, 26.27 },
            NorthAmerica = new double[] { 37, 31.36 },
            Europe = new double[] { 32, 27.12 },
            Others = new double[] { 18, 15.25 }
        },
        new CloudDataCenter()
        {
            Cloud = "Amazon",
            SoutheastAsia = new double[] { 21, 27.63 },
            NorthAmerica = new double[] { 25, 32.89 },
            Europe = new double[] { 18, 23.68 },
            Others = new double[] { 12, 15.79 }
        },
        new CloudDataCenter()
        {
            Cloud = "Google",
            SoutheastAsia = new double[] { 24, 32.88 },
            NorthAmerica = new double[] { 25, 34.25 },
            Europe = new double[] { 18, 24.66 },
            Others = new double[] { 6, 8.21 }
        },
        new CloudDataCenter()
        {
            Cloud = "Alibaba",
            SoutheastAsia = new double[] { 49, 81.66 },
            NorthAmerica = new double[] { 4, 6.67 },
            Europe = new double[] { 4, 6.67 },
            Others = new double[] { 3, 5 }
        },
        new CloudDataCenter()
        {
            Cloud = "IBM",
            SoutheastAsia = new double[] { 8, 13.33 },
            NorthAmerica = new double[] { 28, 46.67 },
            Europe = new double[] { 18, 30 },
            Others = new double[] { 6, 10 }
        },
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
