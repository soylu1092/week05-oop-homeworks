using System;

namespace soru1;

public class Lion : Animal
{
    public Lion(string name, int age, string species) : base(name, age, species)
    {
    }
    public override void Makesound()
    {
        System.Console.WriteLine($"{Name} kükredi!");
    }

}
