using System;

namespace soru7;

public class FoodProduct : Product
{
    public FoodProduct(string name, int price, int stockQuantity, DateTime expirationDate) : base(name, price, stockQuantity)
    {
        ExpirationDate = expirationDate;
    }
    public DateTime ExpirationDate { get; set; }
    public override void MakeSound()
    {
        System.Console.WriteLine($"Ürün adi:{Name} Ürün fiyati:{Price}TL Ürün son kullanma tarihi:{ExpirationDate} Ürün stok sayisi:{StockQuantity}");
    }
    public override string UpdateStock()
    {
        return $"Stoklar güncellendi.";
    }
}
