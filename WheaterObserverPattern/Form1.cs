using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WheaterObserverPattern
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            WheaterData weatherData = new WheaterData();
            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);

            weatherData.setMeasurements(80, 65, 30.4f);
        }
    }
}
