using System;

namespace bai5._2
{
    class Program
    {
        static void Main(string[] args)
        {
          int a ,b;
          int n =0;
          Console.Write("nhap a :") ;
          a= Convert.ToInt32(Console.ReadLine());
          Console.Write("nhap b :");
          b= Convert.ToInt32(Console.ReadLine());

          n= a+b;
          System.Console.WriteLine("KET QUA LA :",n);

        }
    }
}
