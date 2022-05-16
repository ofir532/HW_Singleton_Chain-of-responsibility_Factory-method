using System;

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

        }
    }
}
