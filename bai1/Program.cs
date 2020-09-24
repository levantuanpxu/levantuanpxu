using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
         ArrayList arrayLis= new ArrayList();
         arrayLis.Add("tuan");
         arrayLis.Add("khanh");
         arrayLis.Add("ron");
         arrayLis.Add("phuoc");
         arrayLis.Add("toi");
         arrayLis.Add("linh");
         System.Console.WriteLine(arrayLis.Count);

         foreach( var item in arrayLis)
         {
             Console.WriteLine(item);
         }
         
         for(int i=0;i<arrayLis.Count;i++)
         {
           Console.WriteLine(arrayLis[i]);
         }

Console.WriteLine("nhap ten :");
var studen = new ArrayList();

for(int i=0;i<5;i++)
{
   studen.Add(Console.ReadLine()) ;
}
foreach( var item in studen)
         {
             Console.WriteLine(item);
         }

         // Dictionary

      
         Dictionary <int,String> des = new Dictionary<int, string>();
         for(int i=0;i<=6;i++)
         
         {
              Console.WriteLine(" value");
         des.Add(i,Console.ReadLine());
         }

         System.Console.WriteLine(des.ContainsKey(3));
         foreach( var item in des)
         {
             Console.WriteLine(item);
         }

        }
    }
}