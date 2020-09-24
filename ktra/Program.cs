using System;

namespace ktra
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.Name="alo";
            animal.Age=32;
            animal.Description="dep tu nhien";
            animal.ViewInfo();
        }
    }
}
