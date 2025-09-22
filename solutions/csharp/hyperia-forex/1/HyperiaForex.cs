global using System;

public struct CurrencyAmount
{
    public decimal Amount { get; init; }
    public string Currency { get; init; }

    public CurrencyAmount(decimal amount, string currency)
    {
        Amount = amount;
        Currency = currency;
    }


    public static bool operator ==(CurrencyAmount left, CurrencyAmount right) => left.Currency == right.Currency ? left.Amount == right.Amount : throw new ArgumentException();
    public static bool operator !=(CurrencyAmount left, CurrencyAmount right) => left.Currency == right.Currency ? left.Amount != right.Amount : throw new ArgumentException();

    public static bool operator >(CurrencyAmount left, CurrencyAmount right) => left.Currency == right.Currency ? left.Amount > right.Amount : throw new ArgumentException();
    public static bool operator <(CurrencyAmount left, CurrencyAmount right) => left.Currency == right.Currency ? left.Amount < right.Amount : throw new ArgumentException();

    public static CurrencyAmount operator +(CurrencyAmount left, CurrencyAmount right) => left.Currency == right.Currency ? new(left.Amount + right.Amount, left.Currency) : throw new ArgumentException();
    public static CurrencyAmount operator -(CurrencyAmount left, CurrencyAmount right) => left.Currency == right.Currency ? new(left.Amount - right.Amount, left.Currency) : throw new ArgumentException();

    public static CurrencyAmount operator *(CurrencyAmount left, CurrencyAmount right) => left.Currency == right.Currency ? new(left.Amount * right.Amount, left.Currency) : throw new ArgumentException();
    public static CurrencyAmount operator /(CurrencyAmount left, CurrencyAmount right) => left.Currency == right.Currency ? new(left.Amount / right.Amount, left.Currency) : throw new ArgumentException();

    public static explicit operator Double(CurrencyAmount currencyAmount) => (double)currencyAmount.Amount;
    public static implicit operator Decimal(CurrencyAmount currencyAmount) => currencyAmount.Amount;
}
