using System.Collections.Generic;
using PetShop.Core.Entity;


namespace PetShop.Core.ApplicationService
{
    public interface IOwnerService
    {
        //New Owner
        public Owner NewOwner(string name, string petsowned);

        //Create //POST
        public Owner CreateOwner(Owner owner);

        //Read //GET
        public List<Owner> GetOwners(string name);
        public Owner GetOwnerById(int id);

        //Update //PUT
        public Owner EditOwner(Owner ownerEdit);

        //Delete //DELETE
        public Owner DeleteOwner(int id);

    }
}
