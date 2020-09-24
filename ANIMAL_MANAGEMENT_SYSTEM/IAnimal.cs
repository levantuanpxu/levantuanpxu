using System;
using System.Collections.Generic;
using System.Text;

namespace ANIMAL_MANAGEMENT_SYSTEM
{
    public interface IAnimal
    {
        public int ID { set; get; }
        public string Name { set; get; }
        public int Age { set; get; }
    }
}
