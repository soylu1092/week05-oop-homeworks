using System;

namespace soru7;

public class ElectronicProduct : Product
{
    public ElectronicProduct(string name, int price, int stockQuantity, string garantiYil) : base(name, price, stockQuantity)
    {
        GarantiYil = garantiYil;
    }
    public string GarantiYil { get; set; }


    public override void MakeSound()
    {
        System.Console.WriteLine($"Ürün adi:{Name} Ürün fiyati:{Price}TL Garanti süresi:{GarantiYil} Ürün stok sayisi:{StockQuantity}");
    }
    public override string UpdateStock()
    {
        return $"Stoklar güncellenmedi!!!!";
    }
}
