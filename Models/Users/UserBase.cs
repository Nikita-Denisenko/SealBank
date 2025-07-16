using SealBank.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealBank.Models.Users
{
    public abstract class UserBase
        (
            int id,
            string name,
            string gender,
            DateTime birthDay,
            string email,
            string password,
            string phoneNumber,
            UserType userType
        )
    {
        public int Id { get; } = id;
        public string Name { get; } = name;
        public string Email { get; private set; } = email;
        public string Password { get; private set; } = password;
        public string Gender { get; } = gender;
        public DateTime BirthDay { get; } = birthDay;
        public string PhoneNumber { get; private set; } = phoneNumber;
        public decimal Balance { get; private set; } = 0;
        public List<Transaction> History { get; private set; } = [];
        public UserType UserType { get; private set; } = userType;
    }
}
