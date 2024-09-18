using System;

namespace soru2;

public class Motorcycle : Vehicle
{
    public Motorcycle(string marka, string model, int yil, bool hasSideCar) : base(marka, model, yil)
    {
        HasSideCar = hasSideCar;
    }
    public bool HasSideCar { get; set; }

    public override string AracBilgileri()
    {
        return $"{base.AracBilgileri()} ve yan sepet varmi?:{HasSideCar}";
    }
}
