using Microsoft.EntityFrameworkCore;
using PetShop.Core.DomainService;
using PetShop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PetShop.Infrastructure.SQLite.Data.Repositories
{
    public class OwnerRepository : IOwnerRepository
    {
        readonly PetShopContext _ctx;

        public OwnerRepository(PetShopContext ctx)
        {
            _ctx = ctx;
        }
        public Owner Create(Owner owner)
        {
            var o = _ctx.Owners.Add(owner).Entity;
            _ctx.SaveChanges();
            return o;
        }

        public Owner Delete(int id)
        {
            var ownerRemoved = _ctx.Remove(new Owner { Id = id }).Entity;
            _ctx.SaveChanges();
            return ownerRemoved;
        }

        public Owner Edit(Owner ownerEdit)
        {
            throw new NotImplementedException();
        }

        public Owner GetOwnerById(int id)
        {
            return _ctx.Owners
                .Include(o => o.Pets)
                .ThenInclude(p => p.PetType)
                .FirstOrDefault(o => o.Id == id);
        }

        public IEnumerable<Owner> ReadOwners()
        {
            return _ctx.Owners;
        }
    }
}
