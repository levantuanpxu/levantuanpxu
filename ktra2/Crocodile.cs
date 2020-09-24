using System;
using System.Collections.Generic;
namespace ktra2
{
class Crocodile :ITerrestrialAnimal,IMarineAnimal
{
int id;
string name;
int age;
public int ID
{
set
{
id = value;
}
get
{
return id;
}
}
public string Name
{
set
{
name = value;
}
get
{
return name;
}
}
public int Age
{
set
{
age = value;
}
get
{
return age;
}
}
void ITerrestrialAnimal.Move()
{
Console.WriteLine("Run");
}
void IMarineAnimal.Move()
{
Console.WriteLine("Swim");
}
public override string ToString()
{
Console.WriteLine(GetType());
Console.WriteLine("Id:"+ID);
Console.WriteLine("Name:" +Name);
return"";
}
}
}
