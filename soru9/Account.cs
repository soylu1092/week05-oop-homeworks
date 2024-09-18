using System;

namespace soru9;

public class Account
{
    public Account(int accountNumber, decimal balance)
    {
        AccountNumber = accountNumber;
        Balance = balance;
    }

    public int AccountNumber { get; set; }
public decimal Balance { get; set; }


public virtual string HesapHareketleri()
{
    return $"Hesap Numarasi:{AccountNumber} ve Bakiye:{Balance}";
}
}
