using Newtonsoft.Json;
using SealBank.Models.Users;
using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace SealBank.DataSavers
{
    public static class UserSaver
    {
        public static void SaveUsers(string path, List<UserBase> users)
        {
            var json = JsonConvert.SerializeObject(users, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(path, json);
        }
    }
}