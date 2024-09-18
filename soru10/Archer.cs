using System;

namespace soru10;

public class Archer : Character
{
    public Archer(string name, int health, string goldenArrow) : base(name, health)
    {
        GoldenArrow = goldenArrow;
    }
    public string GoldenArrow { get; set; }


    public override string KarakterStats()
    {
        return $"{base.KarakterStats()}====>{GoldenArrow}";
    }
}
