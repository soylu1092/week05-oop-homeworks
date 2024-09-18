using System;

namespace soru10;

public class Mage : Character
{
    public Mage(string name, int health, string spellBlade) : base(name, health)
    {
        SpellBlade = spellBlade;
    }
    public string SpellBlade { get; set; }


    public override string KarakterStats()
    {
        return $"{base.KarakterStats()}=====>{SpellBlade}";
    }
}
