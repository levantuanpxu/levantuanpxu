using System;

namespace Students
{
    public class Student:IStudent
    {
      

        public string FullName { get ; set ; }
        public int ID { get  ;set ; }
        public string Native { get ; set; }
        public string Class { get;  set ; }
        public int Mobile { get ; set ; }
        public string PhoneNo { get ; set; }
        public DateTime DateofBirth { get ; set ; }

        public void Display()
        {
            System.Console.WriteLine($"{FullName} + {ID} + {Class} + {DateofBirth} + {Native} + {PhoneNo} + {Mobile}");
        }
    }
}