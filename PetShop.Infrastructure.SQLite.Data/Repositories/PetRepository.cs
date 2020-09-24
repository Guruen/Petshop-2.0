using Microsoft.EntityFrameworkCore;
using PetShop.Core.DomainService;
using PetShop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PetShop.Infrastructure.SQLite.Data.Repositories
{
    public class PetRepository : IPetRepository
    {
        readonly PetShopContext _ctx;

        public PetRepository(PetShopContext ctx)
        {
            _ctx = ctx;
        }

        public Pet Create(Pet pet)
        {
            var p = _ctx.Pets.Add(pet).Entity;
            _ctx.SaveChanges();
            return p;
        }

        public Pet Delete(int id)
        {
            var petRemoved = _ctx.Remove(new Pet { Id = id }).Entity;
            _ctx.SaveChanges();
            return petRemoved;
        }

        public Pet Edit(Pet petEdit)
        {
            throw new NotImplementedException();
        }

        public Pet GetPetById(int id)
        {
            return _ctx.Pets
                .Include(p => p.PetType)
                .Include(p => p.Owner)
                .FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Pet> ReadPets()
        {
            return _ctx.Pets.Include(p => p.PetType);
        }
    }
}
