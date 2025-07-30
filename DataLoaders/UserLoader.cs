using SealBank.Constants;
using SealBank.Models;
using SealBank.Models.Users;
using System.Text.Json;

namespace SealBank.DataLoaders
{
    public static class UserLoader
    {
        public static List<UserBase> LoadUsers(string path)
        {
            var result = new List<UserBase>();
            var json = File.ReadAllText(path);
            using var doc = JsonDocument.Parse(json);

            foreach (var element in doc.RootElement.EnumerateArray())
            {
                if (!element.TryGetProperty("UserType", out var typeProp))
                    continue;

                var userType = (UserType)typeProp.GetInt32();

                UserBase? user = userType switch
                {
                    UserType.User => JsonSerializer.Deserialize<User>(element.GetRawText()),
                    UserType.PremiumUser => JsonSerializer.Deserialize<PremiumUser>(element.GetRawText()),
                    UserType.BusinessUser => JsonSerializer.Deserialize<BusinessUser>(element.GetRawText()),
                    _ => null
                };

                if (user != null)
                    result.Add(user);
            }

            return result;
        }
    }
}
