using System;

namespace soru8;

public class Person
{
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public string Name { get; set; }
public int Age { get; set; }

public virtual void Makesound()
{
    System.Console.WriteLine("Ders Başladi.");
}



}
