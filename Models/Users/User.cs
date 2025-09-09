using SealBank.Constants;
using SealBank.Interfaces;
using SealBank.Models.Transactions;


namespace SealBank.Models.Users
{
    public class User
    (
        Guid id,
        string name,
        string surname,
        string gender,
        DateTime birthDay,
        string email,
        string passwordHash,
        string salt,
        string phoneNumber,
        UserType userType,
        decimal balance,
        List<TransactionBase> history,
        int seals
    )   : UserBase
        (
            id, name, surname, gender, birthDay, 
            email, passwordHash, salt, phoneNumber, userType, balance, history
        ),
        IBonusReceivable
    {
        public List<SpendingCategoryType> SpendingCategories { get; private set; } = [];
        public int BasicBonusPercent { get; } = 1;

        public int Seals { get; private set; } = seals;

        public List<SpendingCategoryType> ChooseCategories()
        {
            return new List<SpendingCategoryType>();
        }

        public void AddSealBonus(int amount)
        {
            Seals += amount;
        }
    }
}
