using System;

namespace soru10;

public class Warrior : Character
{
    public Warrior(string name, int health, string dareDevil) : base(name, health)
    {
        DareDevil = dareDevil;
    }
    public string DareDevil { get; set; }


    public override string KarakterStats()
    {
        return $"{base.KarakterStats()} =======>{DareDevil}";
    }
}
