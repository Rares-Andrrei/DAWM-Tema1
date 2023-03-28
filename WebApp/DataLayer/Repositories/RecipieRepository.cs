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
    }
}
