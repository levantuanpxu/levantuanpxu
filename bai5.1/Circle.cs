namespace bai5._1
{
    public  class Circle: Shape
    {
        public int radius{get;set;}

        public override double Area()
        {
            return 0;
        }
        public Circle( string name, int _radius):base(name)
        {
radius=_radius;
        }
        public override void  GetInfo()
        {
            base.GetInfo();
        }

    }
}