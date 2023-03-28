using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    public class RecipieRepository
    {
        public List<Recipie> GetAll()
        {
            var results = DbContext._recipies;
            return results;
        }
        public Recipie GetById(int recipieId)
        {
            var result = DbContext._recipies
                .Where(e => e.Id == recipieId)
                .FirstOrDefault();
            return result;
        }
        public bool DeleteRecipie(int id)
        {
            var recipie = DbContext._recipies.FirstOrDefault(r => r.Id == id);
            if (recipie != null)
            {
                DbContext._recipies.Remove(recipie);
                return true;
            }
            return false;
        }
        public bool CreateRecipie(Recipie recipie)
        {
            var recipieExists = DbContext._recipies.FirstOrDefault(r => r.Id == recipie.Id);
            if (recipieExists != null)
            {
                return false;
            }
            DbContext._recipies.Add(recipie);
            return true;
        }
    }
}
