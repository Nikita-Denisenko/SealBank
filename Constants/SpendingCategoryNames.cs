using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealBank.Constants
{
    public static class SpendingCategoryNames
    {
        public static readonly Dictionary<SpendingCategory, string> DisplayNames = new()
        {
            { SpendingCategory.Recreations, "Развлечения" },
            { SpendingCategory.Restaurants, "Рестораны" },
            { SpendingCategory.Transport, "Транспорт" },
            { SpendingCategory.Education, "Образование" },
            { SpendingCategory.Sport, "Спорт" },
            { SpendingCategory.Culture, "Культура" },
            { SpendingCategory.Travellings, "Путешествия" },
            { SpendingCategory.PetSupplies, "Зоотовары" },
            { SpendingCategory.ClothesAndShoes, "Одежда и обувь" },
            { SpendingCategory.HospitalsAndPharmacies, "Больницы и аптеки" },
            { SpendingCategory.BeautySalons, "Салоны красоты" }
        };
    }
}
