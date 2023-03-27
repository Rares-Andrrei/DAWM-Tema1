using DataLayer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
    public class Recipie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public RecipieType Type { get; set; }
        private List<string> _ingredients;

        public Recipie(int id, string name, RecipieType type, List<string> ingredients)
        {
            Id = id;
            Name = name;
            _ingredients = ingredients;
            Type = type;
        }
        public Recipie()
        {

        }
        public List<string> Ingredients
        {
            get { return _ingredients; }
            set { _ingredients = value; }
        }
    }
}
