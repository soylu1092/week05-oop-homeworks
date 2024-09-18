using System;

namespace soru1;

public class Giraffe : Animal
{
    public Giraffe(string name, int age, string species) : base(name, age, species)
    {
    }
    public override void Makesound()
    {
        System.Console.WriteLine($"{Name} bagirdi!!");
    }
}
