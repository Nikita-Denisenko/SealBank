using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SealBank.Constants;
using SealBank.Models;
using SealBank.Models.Users;

namespace SealBank.DataLoaders
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using SealBank.Constants;
    using SealBank.Models.Users;
    using System.Collections.Generic;
    using System.IO;

    public static class UserLoader
    {
        public static List<UserBase> LoadUsers(string path)
        {
            var settings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All,
            };

            var json = File.ReadAllText(path);
            var users = JsonConvert.DeserializeObject<List<UserBase>>(json, settings);
            return users ?? new List<UserBase>();
        }
    }
}
