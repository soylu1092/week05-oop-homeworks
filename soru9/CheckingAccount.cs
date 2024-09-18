using System;

namespace soru9;

public class CheckingAccount : Account
{
    public CheckingAccount(int accountNumber, decimal balance, bool writeCheck) : base(accountNumber, balance)
    {
        WriteCheck = writeCheck;
    }
    public bool WriteCheck { get; set; }

    public override string HesapHareketleri()
    {
        return $"{base.HesapHareketleri()} Çek yazilsin mi?:{WriteCheck}";
    }
}
