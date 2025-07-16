using SealBank.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealBank.Logic
{
    public static class BonusService
    {
        private const int MinWasteForBonus = 100;
        private const int UserBonusPercent = 1;
        private const int PremiumUserBonusPercent = 2;

        public static int? CalculateBonus(decimal wastedMoneyAmount, UserType userType)
        {
            if (userType == UserType.BusinessUser) 
                return null;
            
            if (wastedMoneyAmount < MinWasteForBonus) 
                return 0;

            var bonus = wastedMoneyAmount / 100 *
                (
                userType == UserType.PremiumUser 
                ? PremiumUserBonusPercent 
                : UserBonusPercent
                );

            return (int)Math.Floor(bonus);
        }
    }
}
