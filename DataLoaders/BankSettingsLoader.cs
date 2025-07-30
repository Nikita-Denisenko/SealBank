using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SealBank.DataLoaders
{
    public static class BankSettingsLoader
    {
        public static decimal LoadBalance(string path)
        {
            var json = File.ReadAllText(path);
            var data = JsonSerializer.Deserialize<Dictionary<string, decimal>>(json);
            return data != null? data["BankBalance"] : 0;
        }
    }
}
