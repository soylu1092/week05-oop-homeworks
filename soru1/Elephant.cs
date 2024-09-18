using System;

namespace soru1;

public class Elephant : Animal
{
    public Elephant(string name, int age, string species) : base(name, age, species)
    {
    }
    public override void Makesound()
    {
        System.Console.WriteLine($"{Name} boru sesi cikardi!");
    }
}
