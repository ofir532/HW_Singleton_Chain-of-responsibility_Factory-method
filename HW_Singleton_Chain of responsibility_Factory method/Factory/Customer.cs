using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace HW_Singleton_Chain_of_responsibility_Factory_method.Factory
{
    internal class Customer
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }

        public Customer(int id, string fullName, int age, double weight, double height)
        {
            Id = id;
            FullName = fullName;
            Age = age;
            Weight = weight;
            Height = height;
        }
        public override string ToString()
        {
            var type = new JsonSerializerOptions { WriteIndented = true };
            return JsonSerializer.Serialize(this, type);
        }
    }
}
