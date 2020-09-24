using System;

namespace bai5._1
{
    public abstract class Shape
    {
        public String name{get; set;}
        public Shape(string name)
        {
        }
        public virtual void GetInfo()
        {
            System.Console.WriteLine("Tên hình là : {0}",name);
        }
        public abstract double Area();
    }
}