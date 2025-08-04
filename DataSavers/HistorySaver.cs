using SealBank.Models.Transactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SealBank.DataSavers
{
    public static class HistorySaver
    {
        private static readonly JsonSerializerOptions options = new()
        {
            WriteIndented = true,
            IncludeFields = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        };

        public static void SaveHistory(List<TransactionBase> history, string filePath)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(filePath));
            string json = JsonSerializer.Serialize(history, options);
            File.WriteAllText(filePath, json);
        }
    }
}
