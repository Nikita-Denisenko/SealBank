using Newtonsoft.Json;
using SealBank.Models.Users;
using System;
using System.Collections.Generic;
using System.IO;

namespace SealBank.DataSavers
{
    public static class UserSaver
    {
        public static void SaveUsers(List<UserBase> users)
        {
            var settings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All,
                Formatting = Formatting.Indented
            };

            string projectRoot = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\"));

            string path = Path.Combine(projectRoot, "Data", "users.json");

            Directory.CreateDirectory(Path.GetDirectoryName(path)!);

            string json = JsonConvert.SerializeObject(users, settings);
            File.WriteAllText(path, json);
        }
    }
}
