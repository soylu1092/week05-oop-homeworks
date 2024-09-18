using System;

namespace soru2;

public class Car : Vehicle
{
    public Car(string marka, string model, int yil, int numberOfDoors) : base(marka, model, yil)
    {
        NumberOfDoors = numberOfDoors;
    }

    public int NumberOfDoors { get; set; }

    public override string AracBilgileri()
    {
        return $"{base.AracBilgileri()} ve Kapi sayisi:{NumberOfDoors}";
    }
}
