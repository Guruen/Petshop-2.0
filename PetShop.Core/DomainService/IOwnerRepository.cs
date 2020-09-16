using PetShop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop.Core.DomainService
{
    public interface IOwnerRepository
    {
        List<Owner> ReadOwners();
        Owner Create(Owner owner);
        Owner Edit(Owner ownerEdit);
        Owner Delete(int id);
        Owner GetOwnerById(int id);

    }
}
