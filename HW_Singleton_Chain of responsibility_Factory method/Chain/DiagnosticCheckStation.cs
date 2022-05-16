using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Singleton_Chain_of_responsibility_Factory_method.Chain
{
    internal class DiagnosticCheckStation : GarageTest
    {
        public override void HandleCar(Car car)
        {
            Random random = new Random();
            int test = random.Next(1, 11);
            if (test >= 6)
            {
                Console.WriteLine($"The test end for {car.Brand} without finding the problem. The car has no problem!");
                car.isNeedRepair = false;
                if (nextCheck != null)
                    nextCheck.HandleCar(car);
                else
                    Console.WriteLine("The tretment is over");

            }
            else
            {
                Console.WriteLine($"{car.Brand}: We found the problem and we fixed it");
                car.isNeedRepair = false;

            }

        }
    }
}
