using System;

namespace soru10;

public class Character
{
    public Character(string name, int health)
    {
        Name = name;
        Health = health;
    }

    public string Name { get; set; }
public int Health { get; set; }


public virtual string KarakterStats()
{
    return $"Adi:{Name} Saglik değeri:{Health}";
}

}
