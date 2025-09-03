using SealBank.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealBank.Interfaces
{
    public interface IBonusReceivable
    {
        public List<SpendingCategoryType> SpendingCategories { get; }
        public int BasicBonusPercent { get; }
        public int Seals { get; }
        public void AddSealBonus(int amount);
        public List<SpendingCategoryType> ChooseCategories();
    }
}
