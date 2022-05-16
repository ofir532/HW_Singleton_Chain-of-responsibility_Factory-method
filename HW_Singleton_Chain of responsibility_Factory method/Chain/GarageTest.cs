using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Singleton_Chain_of_responsibility_Factory_method.Chain
{
    internal abstract class GarageTest
    {
        protected GarageTest nextCheck;
        public bool isFixed;
        public void NextCheck(GarageTest next)
        {
            nextCheck = next;
        }
        public abstract void HandleCar(Car car);

    }
}
