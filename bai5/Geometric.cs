using System;

namespace bai5
{
    public abstract class Geometric
    {
        public String name{get; set;}
        protected Geometric(String _name)
        {
            name=_name;
        }
        public abstract double GetArea();
        public abstract double GetPerimeter();
            }
}