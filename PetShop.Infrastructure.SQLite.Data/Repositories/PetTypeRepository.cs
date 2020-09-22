using PetShop.Core.DomainService;
using PetShop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PetShop.Infrastructure.SQLite.Data.Repositories
{
    public class PetTypeRepository : IPetTypeRepository
    {
        readonly PetShopContext _ctx;

        public PetTypeRepository(PetShopContext ctx)
        {
            _ctx = ctx;
        }

        public PetType Create(PetType petType)
        {
            var type = _ctx.PetTypes.Add(petType).Entity;
            _ctx.SaveChanges();
            return type;
        }

        public PetType Delete(int id)
        {
            throw new NotImplementedException();
        }

        public PetType Edit(PetType petTypeEdit)
        {
            throw new NotImplementedException();
        }

        public PetType GetPetTypeById(int id)
        {
            return _ctx.PetTypes.FirstOrDefault(t => t.Id == id);
        }

        public IEnumerable<PetType> readPetTypes()
        {
            return _ctx.PetTypes;
        }
    }
}
