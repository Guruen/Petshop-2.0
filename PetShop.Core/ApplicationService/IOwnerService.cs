﻿using System.Collections.Generic;
using PetShop.Core.Entity;


namespace PetShop.Core.ApplicationService
{
    public interface IOwnerService
    {
        //New Owner
        public Owner NewOwner(string name);

        //Create //POST
        public Owner CreateOwner(Owner owner);

        //Read //GET
        public List<Owner> GetOwners();
        public Owner GetOwnerById(int id);
        public Owner GetOwnerByIdIncludingPets(int id);

        //Update //PUT
        public Owner EditOwner(Owner ownerEdit);

        //Delete //DELETE
        public Owner DeleteOwner(int id);

    }
}
