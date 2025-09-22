namespace SealBank.Interfaces
{
    public interface ITransferable
    {
        Guid Id { get; }
        string Name { get;}
        decimal Balance { get; }
        void GiveMoney(decimal amount);
        bool WithdrawMoney(decimal amount);
    }
}
