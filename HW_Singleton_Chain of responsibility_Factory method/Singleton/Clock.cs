using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Singleton_Chain_of_responsibility_Factory_method
{
    internal class Clock
    {
        private string dateTime;
        private static Clock instance;
        private static readonly object key = new object();
        private Clock()
        {
            dateTime = DateTime.Now.ToString("HHmmss");
        }
        public static Clock GetTime()
        {
            if (instance == null)
            {
                lock (key)
                {
                    if (instance == null)
                    {
                        instance = new Clock();
                    }
                }

            }
            else
                Console.WriteLine("Already created");

            return instance;
        }
        public override string ToString()
        {

            return dateTime;
        }

    }
}
