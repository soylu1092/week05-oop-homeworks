using System;

namespace soru2;

public class Vehicle
{
    public Vehicle(string marka, string model, int yil)
    {
        Marka = marka;
        Model = model;
        Yil = yil;
    }

    public string Marka { get; set; }
public string Model { get; set; }
public int Yil { get; set; }

public virtual string AracBilgileri()
{
    return $"Marka:{Marka},Model:{Model},Yil:{Yil}";
}












}
