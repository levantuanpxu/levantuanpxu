namespace bai5._1
{
    public class Rectangle : Shape
    {
        public int lenght {get; set;}
        public int withd {get;set;}

        public override double Area()
        {
            return 0;
        }
        public Rectangle(string name, int _lenght,int _withd):base(name)
        {
           lenght=_lenght;
           withd=_withd;
        }
        public override void GetInfo()
        {
            base.GetInfo();
            System.Console.WriteLine($"");
        }
    }
}