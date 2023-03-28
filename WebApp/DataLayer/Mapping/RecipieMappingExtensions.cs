using DataLayer.DTos;
using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Mapping
{
    public static class RecipieMappingExtensions
    {
        public static RecipieDto ToRecipieDto(this Recipie recipie)
        {
            if (recipie == null)
            {
                return null;
            }
            var result = new RecipieDto();
            result.Id = recipie.Id;
            result.Ingredients = recipie.Ingredients;
            result.Name = recipie.Name;
            result.Type = recipie.Type;
            return result;           
        }
    }
}
