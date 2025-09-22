namespace SealBank.Models.Transactions
{
    public class WithdrawalTransaction
    (
        string name,
        DateTime dateTime,
        Guid userId,
        string userName,
        string message,
        decimal moneyAmount
    ) : TransactionBase(name, dateTime, userId, message, userName)

    {
        public decimal MoneyAmount { get; } = moneyAmount;
        public override string Discriminator => "Withdrawal";
    }
}
