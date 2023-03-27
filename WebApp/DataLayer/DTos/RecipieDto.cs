using DataLayer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.DTos
{
    internal class RecipieDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public RecipieType Type { get; set; }
        private List<string> _ingredients;
        public List<string> Ingredients
        {
            get { return _ingredients; }
            set { _ingredients = value; }
        }
    }
}
