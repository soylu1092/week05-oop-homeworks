using System;

namespace soru7;

public class Product
{
    public Product(string name, int price, int stockQuantity)
    {
        Name = name;
        Price = price;
        StockQuantity = stockQuantity;
    }

    public string Name { get; set; }
public int Price { get; set; }
public int StockQuantity { get; set; }


public virtual void MakeSound()
{
    System.Console.WriteLine("Ürün Stok Sayisi");
}
public virtual string UpdateStock(){
    return $"Ürünler yenilendi!";
}

}
