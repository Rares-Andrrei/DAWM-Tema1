using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public static class DbContext
    {
        public static List<Recipie> _recipies = new List<Recipie>
        {
            new Recipie
            {
                Id = 1,
                Name = "Donuts",
                Type = Enums.RecipieType.Breakfast,
                Ingredients = new List<string>
                {
                    "cocoa powder", "milk", "sugar", "flour", "active dry yeast", "salt", "eggs", "oil"
                }
            },
            new Recipie
            {
                Id = 2,
                Name = "Microwave Baked Potato",
                Type = Enums.RecipieType.Lunch,
                Ingredients = new List<string>
                {
                    "potato", "olive oil", "salt", "butter"
                }
            },
            new Recipie
            {
                Id = 3,
                Name = "Mapo Tofu",
                Type = Enums.RecipieType.Dinner,
                Ingredients = new List<string>
                {
                    "pound ground pork", "minced fresh ginger", "minced garlic", "cornstarch", "chili crisp", "Pixian chili bean paste", "green onion"
                }
            },
            new Recipie
            {
                Id = 4,
                Name = "Whoopie Pies",
                Type = Enums.RecipieType.Breakfast,
                Ingredients = new List<string>
                {
                    "flour", "Dutch-process cocoa powder", "baking powder", "baking soda", "kosher salt", "vegetable oil", "unsalted butter",
                    "packed dark brown sugar", "eggs", "buttermilk"
                }
            }
        };
    }
}
