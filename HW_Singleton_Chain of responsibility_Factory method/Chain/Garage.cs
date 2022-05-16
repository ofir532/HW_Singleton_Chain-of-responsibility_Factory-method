using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Singleton_Chain_of_responsibility_Factory_method.Chain
{
    internal abstract class Garage
    {
        public List<Car> cars;
        public Garage()
        {
            cars = new List<Car>();
        }
        public abstract void HandleCar(Car car);


    }
}
