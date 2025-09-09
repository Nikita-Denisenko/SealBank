using SealBank.Constants;
using SealBank.Interfaces;
using SealBank.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealBank.Logic
{
    public static class BonusService
    {
        private static readonly Dictionary<SpendingCategoryType, int> CategoryBonuses = new()
        {
            {SpendingCategoryType.Recreations,  4},
            {SpendingCategoryType.Restaurants, 3},
            {SpendingCategoryType.Transport,  8},
            {SpendingCategoryType.Education,  6},
            {SpendingCategoryType.Sport,  5},
            {SpendingCategoryType.Culture,  5},
            {SpendingCategoryType.Travellings,  3},
            {SpendingCategoryType.PetSupplies,  5},
            {SpendingCategoryType.ClothesAndShoes,  4},
            {SpendingCategoryType.HospitalsAndPharmacies,  7},
            {SpendingCategoryType.BeautySalons,  4},
        };  

        private const int MinWasteForBonus = 100;

        public static int CalculateBonus(int bonusPercent, decimal wastedMoneyAmount)
        {
            var bonus = wastedMoneyAmount / 100 * bonusPercent;
            return (int)Math.Floor(bonus);
        }

        public static int GetCategoryBonusPercent(SpendingCategoryType category)
        {
            if (!CategoryBonuses.TryGetValue(category, out var bonus))
                throw new ArgumentException($"Категории {category} не найдено!");

            return bonus;
        }

        public static int? GetSealsQuantity(decimal wastedMoneyAmount, SpendingCategoryType category, IBonusReceivable user)
        {
            if (wastedMoneyAmount < MinWasteForBonus) 
                return 0;

            int bonus;
            int bonusPercent;

            if (!user.SpendingCategories.Contains(category))
            {
                bonus = CalculateBonus(user.BasicBonusPercent, wastedMoneyAmount);
                return bonus;
            }

            bonusPercent = GetCategoryBonusPercent(category);
            bonus = CalculateBonus(bonusPercent, wastedMoneyAmount);
            return bonus;
        }
    }
}
