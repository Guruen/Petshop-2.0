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
            foreach (var owner in FakeDB.owners)
            {
                if (owner.Id == id)
                {
                    return owner;
                }

            }
            return null;
        }

        public List<Owner> ReadOwners()
        {
            return FakeDB.owners;
        }
    }
}
