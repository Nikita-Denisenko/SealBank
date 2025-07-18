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
        private static readonly Dictionary<SpendingCategory, int> CategoryBonuses = new()
        {
            {SpendingCategory.Recreations,  4},
            {SpendingCategory.Restaurants, 3},
            {SpendingCategory.Transport,  8},
            {SpendingCategory.Education,  6},
            {SpendingCategory.Sport,  5},
            {SpendingCategory.Culture,  5},
            {SpendingCategory.Travellings,  3},
            {SpendingCategory.PetSupplies,  5},
            {SpendingCategory.ClothesAndShoes,  4},
            {SpendingCategory.HospitalsAndPharmacies,  7},
            {SpendingCategory.BeautySalons,  4},
        };  

        private const int MinWasteForBonus = 100;

        public static int CalculateBonus(int bonusPercent, decimal wastedMoneyAmount)
        {
            var bonus = wastedMoneyAmount / 100 * bonusPercent;
            return (int)Math.Floor(bonus);
        }

        public static int GetCategoryBonusPercent(SpendingCategory category)
        {
            if (!CategoryBonuses.TryGetValue(category, out var bonus))
                throw new ArgumentException($"Категории {category} не найдено!");

            return bonus;
        }

        public static int? GetSealsQuantity(decimal wastedMoneyAmount, SpendingCategory category, IBonusReceivable user)
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
