using System;
using HW_Singleton_Chain_of_responsibility_Factory_method.Chain;

namespace HW_Singleton_Chain_of_responsibility_Factory_method
{
    internal class Program
    {

        static void Main(string[] args)
        {
            #region Singleton
            Clock clock = Clock.GetTime();
            Clock clock1 = Clock.GetTime();

            Console.WriteLine(clock);
            Console.WriteLine(clock1);
            #endregion
            #region Chain
            Car c1 = new Car(CarBrand.Toyota, true);
            Car c2 = new Car(CarBrand.Mercedes, true);
            Car c3 = new Car(CarBrand.Skoda, true);
            Garage garage = new Garage();
            garage.cars.Add(c1);
            garage.cars.Add(c2);
            garage.cars.Add(c3);

            GarageTest firstTest = new GeneralCheckStation();
            GarageTest secondTest = new MechanicCheckStation();
            GarageTest thirdTest = new ElectricityCheckStation();
            GarageTest fourthTest = new DiagnosticCheckStation();
            firstTest.NextCheck(secondTest);
            secondTest.NextCheck(thirdTest);
            thirdTest.NextCheck(fourthTest);
            fourthTest.NextCheck(null);
            garage.cars.ForEach(c1 => { if (c1.isNeedRepair == true) firstTest.HandleCar(c1); });


            #endregion
        }
    }
}

