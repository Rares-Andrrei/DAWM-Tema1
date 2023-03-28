using DataLayer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Utilities
{
    public static class RecipieTypeUtil
    {
        public static RecipieType StringToEnum(string type)
        {
            switch (type)
            {
                case "Breakfast":
                    return RecipieType.Breakfast;
                case "Dinner":
                    return RecipieType.Dinner;
                case "Dessert":
                    return RecipieType.Dessert;
                case "Lunch":
                    return RecipieType.Lunch;
                case "Snack":
                    return RecipieType.Snack;
                default:
                    throw new ArgumentException();
            }
        }
    }
}
