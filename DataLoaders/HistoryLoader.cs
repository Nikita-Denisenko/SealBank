using SealBank.Models.Transactions;
using System.Text.Json;

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
                if (!element.TryGetProperty("Discriminator", out var typeProp))
                    continue;

                string typeValue = typeProp.GetString() ?? "";

                TransactionBase? transaction = typeValue switch
                {
                    "Transfer" => JsonSerializer.Deserialize<TransferTransaction>(element.GetRawText()),
                    "Bonus" => JsonSerializer.Deserialize<BonusTransaction>(element.GetRawText()),
                    "Deposit" => JsonSerializer.Deserialize<DepositTransaction>(element.GetRawText()),
                    "Withdrawal" => JsonSerializer.Deserialize<WithdrawalTransaction>(element.GetRawText()),
                    "Payment" => JsonSerializer.Deserialize<PaymentTransaction>(element.GetRawText()),
                    _ => null
                };

                if (transaction != null)
                    result.Add(transaction);
            }

            return result;
        }
    }
}
