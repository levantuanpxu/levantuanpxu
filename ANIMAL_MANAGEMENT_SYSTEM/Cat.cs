using System;
using System.Collections.Generic;
using System.Text;

namespace ANIMAL_MANAGEMENT_SYSTEM
{
    public class Cat : ITerrestrialAnimal
    {
        public int ID { set; get; }
        public string Name { set; get; }
        public int Age { set; get; }
        public void Move()
        {
            Console.WriteLine("Run");
        }
        public override string ToString()
        {
            return "ID :" + ID + " Name : " + Name + " Age : " + Age;
        }
    }
}
