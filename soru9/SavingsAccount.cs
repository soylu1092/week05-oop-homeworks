using System;

namespace soru9;

public class SavingsAccount : Account
{
    public SavingsAccount(int accountNumber, decimal balance, bool paraCek) : base(accountNumber, balance)
    {
        ParaCek = paraCek;
    }
    public bool ParaCek { get; set; }

    public override string HesapHareketleri()
    {
        return $"{base.HesapHareketleri()}===>Para cekilsin mi?{ParaCek}";
    }
}
