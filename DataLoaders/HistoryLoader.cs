using SealBank.Models.Transactions;
using System.Text.Json;
using SealBank.Constants;

namespace SealBank.DataLoaders
{
    public static class HistoryLoader
    {
        public static List<TransactionBase> LoadHistory(string path)
        {
            var result = new List<TransactionBase>();

            var json = File.ReadAllText(path);

            using JsonDocument doc = JsonDocument.Parse(json);
            foreach (var element in doc.RootElement.EnumerateArray())
            {
                if (!element.TryGetProperty("Type", out var typeProp))
                    continue;

                var typeValue = (TransactionType)typeProp.GetInt32();

                TransactionBase? transaction = typeValue switch
                {
                    TransactionType.Transfer => JsonSerializer.Deserialize<TransferTransaction>(element.GetRawText()),
                    TransactionType.Bonus => JsonSerializer.Deserialize<BonusTransaction>(element.GetRawText()),
                    TransactionType.Deposit => JsonSerializer.Deserialize<DepositTransaction>(element.GetRawText()),
                    TransactionType.Withdrawal => JsonSerializer.Deserialize<WithdrawalTransaction>(element.GetRawText()),
                    TransactionType.Payment => JsonSerializer.Deserialize<PaymentTransaction>(element.GetRawText()),
                    _ => null
                };

                if (transaction != null)
                    result.Add(transaction);
            }

            return result;
        }
    }
}
