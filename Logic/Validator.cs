using SealBank.Managers;
using SealBank.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SealBank.Logic
{
    public static class Validator
    {
        public static void IsValidName(string name, out bool IsValid, out string? Message)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                IsValid = false;
                Message = "Не все поля заполнены!";
                return;
            }

            if (!Regex.IsMatch(name, @"^[А-ЯЁ][а-яё]+$"))
            {
                IsValid = false;
                Message = "В имени или фамилии могут использоваться\nтолько символы кириллицы!";
                return;
            }
            
            if (!char.IsUpper(name[0]) || !name.Substring(1, name.Length - 1).All(char.IsLower))
            {
                IsValid = false;
                Message = "Первая буква имени или фамилии должна\n быть заглвной, а остальные буквы - маленькими.";
                return;
            }

            IsValid = true;
            Message = null;
        }

        public static void IsValidPhoneNumber(string phoneNumber, out bool IsValid, out string? Message)
        {
            if (string.IsNullOrWhiteSpace(phoneNumber))
            {
                IsValid = false;
                Message = "Не все поля заполнены!";
                return;
            }

            if (!Regex.IsMatch(phoneNumber, @"^(\+7|8|7)\d{10}$"))
            {
                IsValid = false;
                Message = "Номер телефона должен начинаться с +7, 8 или 7\nи содержать 10 цифр без пробелов и символов.";
                return;
            }
            
            IsValid = true;
            Message = null;
        }

        public static void IsValidEmail(string email, out bool IsValid, out string? Message)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                IsValid = false;
                Message = "Не все поля заполнены!";
                return;
            }

            if (!Regex.IsMatch(email, @"^[\w\.-]+@[\w\.-]+\.\w{2,}$"))
            {
                IsValid = false;
                Message = "Email должен быть в формате example@domain.com";
                return;
            }

            IsValid = true;
            Message = null;
        }

        public static void IsValidPassword(string password, out bool IsValid, out string? Message)
        {
            if (string.IsNullOrWhiteSpace(password))
            {
                IsValid = false;
                Message = "Не все поля заполнены!";
                return;
            }

            if (password.Length < 8)
            {
                IsValid = false;
                Message = "Пароль должен содержать минимум 8 символов!";
                return;
            }

            IsValid = true;
            Message = null;
        }

        public static void IsValidRepeatPassword(string password, string repeatPassword, out bool IsValid, out string? Message)
        {
            if (string.IsNullOrWhiteSpace(repeatPassword))
            {
                IsValid = false;
                Message = "Не все поля заполнены!";
                return;
            }

            if (repeatPassword != password)
            {
                IsValid = false;
                Message = "Пароли не совпадают!";
                return;
            }

            IsValid = true;
            Message = null;
        }

        public static bool EmailExists(string email, List<UserBase> users)
        {
            return users.Any(u => u.Email == email);
        }

        public static bool IsEmailAvailable(string email, List<UserBase> users)
        {
            return !EmailExists(email, users);
        }

        public static UserBase? Login(string email, string password, List<UserBase> bankUsers)
        {
            var userAccount = bankUsers.
                FirstOrDefault(user => user.Email == email);

            if (userAccount is null) return null;

            if (userAccount.Password != password) return null;

            return userAccount;
        }

        public static void IsRegistrationSuccessful
        (
            string name,
            string surname,
            string? gender,
            string phoneNumber,
            string email,
            string password,
            string repeatPassword,
            out bool IsSuccessful,
            out string? Message
        )
        {
            IsValidName(name, out bool isValidName, out string? nameMessage);

            if (!isValidName)
            {
                IsSuccessful = false;
                Message = nameMessage;
                return;
            }

            IsValidName(surname, out bool isValidSurname, out string? surnameMessage);

            if (!isValidSurname)
            {
                IsSuccessful = false;
                Message = surnameMessage;
                return;
            }

            if (gender is null)
            {
                IsSuccessful = false;
                Message = "Пожалуйста, выберите пол.";
                return;
            }

            IsValidPhoneNumber(phoneNumber, out bool isValidPhone, out string? phoneMessage);

            if (!isValidPhone)
            {
                IsSuccessful = false;
                Message = phoneMessage;
                return;
            }

            IsValidEmail(email, out bool isValidEmail, out string? emailMessage);

            if (!isValidEmail) 
            {
                IsSuccessful = false;
                Message = emailMessage;
                return;
            }

            IsValidPassword(password, out bool isValidPassword, out string? passwordMessage);

            if (!isValidPassword)
            {
                IsSuccessful = false;
                Message = passwordMessage;
                return;
            }

            IsValidRepeatPassword(password, repeatPassword, out bool isValidRepeatPassword, out string? repeatPasswordMessage);

            if (!isValidRepeatPassword)
            {
                IsSuccessful = false;
                Message = repeatPasswordMessage;
                return;
            }

            IsSuccessful = true;
            Message = null;
        }
    }
}
