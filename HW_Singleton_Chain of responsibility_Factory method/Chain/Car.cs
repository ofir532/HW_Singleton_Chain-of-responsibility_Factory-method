using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Singleton_Chain_of_responsibility_Factory_method.Chain
{
    internal class Car
    {
        public CarBrand Brand { get; set; }
        public bool isNeedRepair;
        public Car(CarBrand Brand, bool isNeedRepair)
        {
            this.Brand = Brand;
            this.isNeedRepair = isNeedRepair;
        }

    }
}
