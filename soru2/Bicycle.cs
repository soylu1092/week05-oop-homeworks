using System;

namespace soru2;

public class Bicycle : Vehicle
{
    public Bicycle(string marka, string model, int yil, double weight) : base(marka, model, yil)
    {
        Weight = weight;
    }
    public double Weight { get; set; }

    public override string AracBilgileri()
    {
        return $"{base.AracBilgileri()} ve Bisiklet agirliği:{Weight}";
    }
}
