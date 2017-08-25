using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WheaterObserverPattern.interfaces
{
    public interface IObserver
    {
        void update(float temperature, float humidity, float pressure);
    }
}
