using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WheaterObserverPattern.interfaces;

namespace WheaterObserverPattern
{
    public class WheaterData : ISubject
    {
        private ArrayList observers;
        private float temperature;
        private float humidity;
        private float pressure;
        private float pressureaaaxczxvx;


        public WheaterData()
        {
            observers = new ArrayList();
        }

        public void notifyObservers()
        {
            foreach (IObserver observer in observers)
            {
                observer.update(temperature, humidity, pressure);
            }
        }

        public void registerObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void removeObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void measurementsChanged()
        {
            notifyObservers();
        }

        public void setMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            measurementsChanged();
        }
    }
}
