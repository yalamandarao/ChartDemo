using System.Collections.Generic;
using Xamarin.Forms;
using Microcharts;
using Microcharts.Forms;

using Entry = Microcharts.Entry;
using SkiaSharp;

namespace ChartDemo
{
    public partial class ChartDemoPage : ContentPage
    {
        List<Entry> entries = new List<Entry>
        {
            new Entry(200)
            {
                Color = SKColor.Parse("#00CED1"),
                Label = "March",
                ValueLabel = "200",
            },
            new Entry(400)
            {
                Color = SKColor.Parse("#266489"),
                Label = "January",
                ValueLabel = "400",
            },
            new Entry(-100)
            {
                Color = SKColor.Parse("#90D585"),
                Label = "March",
                ValueLabel = "-100",
            },
            new Entry(670)
            {
                Color = SKColor.Parse("#68B9C0"),
                Label = "March",
                ValueLabel = "670",
            }
        };
        public ChartDemoPage()
        {
            InitializeComponent();
          
            chartView1.Chart = new BarChart { Entries = entries };
            chartView2.Chart = new RadarChart { Entries = entries };
            chartView3.Chart = new PieChart { Entries = entries };
            chartView4.Chart = new RadialGaugeChart { Entries = entries };

           
        }
    }
}
