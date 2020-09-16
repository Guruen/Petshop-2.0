using PetShop.Core.DomainService;
using PetShop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop.Infrastructure.Data
{
    public class OwnerRepository : IOwnerRepository
    {
        public Owner Create(Owner owner)
        {
            owner.Id = FakeDB.owner_id++;
            FakeDB.owners.Add(owner);
            return owner;
        }

        public Owner Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Owner Edit(Owner ownerEdit)
        {
            throw new NotImplementedException();
        }

        public Owner GetOwnerById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Owner> ReadOwners()
        {
            return FakeDB.owners;
        }
    }
}
