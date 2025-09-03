using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealBank.Constants
{
    public static class SpendingCategoryNames
    {
        public static readonly Dictionary<SpendingCategoryType, string> DisplayNames = new()
        {
            { SpendingCategoryType.Recreations, "Развлечения" },
            { SpendingCategoryType.Restaurants, "Рестораны" },
            { SpendingCategoryType.Transport, "Транспорт" },
            { SpendingCategoryType.Education, "Образование" },
            { SpendingCategoryType.Sport, "Спорт" },
            { SpendingCategoryType.Culture, "Культура" },
            { SpendingCategoryType.Travellings, "Путешествия" },
            { SpendingCategoryType.PetSupplies, "Зоотовары" },
            { SpendingCategoryType.ClothesAndShoes, "Одежда и обувь" },
            { SpendingCategoryType.HospitalsAndPharmacies, "Больницы и аптеки" },
            { SpendingCategoryType.BeautySalons, "Салоны красоты" }
        };
    }
}
