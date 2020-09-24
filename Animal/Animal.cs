using System;

namespace bai2
{
    public class Animal
    {
        public string name{get;set;}
         public string sound{get;set;}
        public Animal() {}
        public Animal(string _name,string _sound)
        {
            name=_name;
            sound=_sound;
        }
        public void GetInfo(){
            System.Console.WriteLine($"{name} co tieng keu la {sound}");
        }
    }
}