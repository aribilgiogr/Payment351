namespace Core.Concretes.Enums
{
    public enum PaymentStatus
    {
        Pending = 1,
        Completed = 2,
        Failed = 3,
        Refunded = 4
    }

    public enum TransactionType
    {
        Sale = 1, // Doğrudan satış işlemi (auth+capture)
        Auth = 2, // Provizyon / Bloke işlemleri
        Capture = 3, // Provizyon / Bloke sonrası ödeme alma işlemi
        Void = 4, // Gün sonu yapılmadan önceki iptal
        Refund = 5 // Gün sonu sonrası iade işlemi
    }
}
