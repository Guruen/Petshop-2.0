using PetShop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop.Core.ApplicationService
{
    public interface IPetTypeService
    {

        //New PetType
        public PetType NewPetType(string name);

        //Create //POST
        public PetType CreatePetType(PetType petType);

        //Read //GET
        public List<PetType> GetPetType();
        public PetType GetPetTypeById(int id);

        //Update //PUT
        public PetType EditPetType(PetType petTypeEdit);

        //Delete //DELETE
        public PetType DeletePetType(int id);
    }
}
