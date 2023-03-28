using Core.DTos;
using DataLayer.Entities;
using DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    
    public class RecipieService
    {
        private RecipieRepository _recipieRepository { get; set; }
        public RecipieService(RecipieRepository recipieRepository)
        {
            _recipieRepository = recipieRepository;
        }
        public List<Recipie>GetAll()
        {
            var results = _recipieRepository.GetAll();
            return results;
        }
        public bool EditName(RecipieUpdateDto payload)
        {
            if (payload == null || payload.Name == null)
            {
                return false;
            }
            var result = _recipieRepository.GetById(payload.Id);
            if (result == null)
            {
                return false;
            }
            result.Name = payload.Name;
            return true;
        }
    }
}
