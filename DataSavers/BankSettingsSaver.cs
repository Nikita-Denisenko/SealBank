using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SealBank.DataSavers
{
    public static class BankSettingsSaver
    {
        public static void SaveBalance(decimal balance, string filePath)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(filePath));
            string json = JsonSerializer.Serialize(balance);
            File.WriteAllText(filePath, json);
        }
    }
}
