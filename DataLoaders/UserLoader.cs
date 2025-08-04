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
            var json = File.ReadAllText(path);
            var array = JArray.Parse(json);

            var result = new List<UserBase>();

            foreach (var token in array)
            {
                var userTypeToken = token["UserType"];
                if (userTypeToken == null)
                    continue;

                var userType = (UserType)userTypeToken.ToObject<int>();

                UserBase? user = userType switch
                {
                    UserType.User => token.ToObject<User>(),
                    UserType.PremiumUser => token.ToObject<PremiumUser>(),
                    UserType.BusinessUser => token.ToObject<BusinessUser>(),
                    _ => null
                };

                if (user != null)
                    result.Add(user);
            }

            return result;
        }

    }
}
