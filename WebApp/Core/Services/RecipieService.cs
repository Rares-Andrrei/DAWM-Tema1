using Core.DTos;
using DataLayer.Entities;
using DataLayer.Repositories;
using DataLayer.Utilities;
using DataLayer.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.DTos;

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
        public bool DeleteRecipie(int id)
        {
            return _recipieRepository.DeleteRecipie(id);
        }
        public bool CreateRecipie(RecipieCreateDto recipie)
        {
            Recipie r = new Recipie();
            r.Name = recipie.Name;
            r.Id = recipie.Id;
            try
            {
                r.Type = RecipieTypeUtil.StringToEnum(recipie.Type);
            }
            catch(ArgumentException arg) { return false; }
            r.Ingredients = recipie.Ingredients;
            return _recipieRepository.CreateRecipie(r);
        }
        public RecipieDto GetById(int recipieId)
        {
            var recipie = _recipieRepository.GetById(recipieId);
            var result = recipie.ToRecipieDto();
            return result;
        }
    }
}
