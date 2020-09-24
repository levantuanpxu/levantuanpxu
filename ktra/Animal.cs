using System;

namespace ktra
{
    public abstract  class Animal 
    {
       public String Name{get;set;}
       public int Age{get;set;}
       public String Description {get;set;}
        public Animal()
        {}
        
        public Animal(String _name, int _age , String _des)
        { 
            Name=_name;
            Age=_age;
            Description=_des;
        }
        public virtual  void ViewInfo()
        { 
            System.Console.WriteLine($"Ten la : {Name}  Tuoi la: {Age}  Mo ta : {Description}");
        }
        public abstract double  Speak();       
    }
    
}