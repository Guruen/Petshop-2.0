using PetShop.Core.DomainService;
using PetShop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop.Infrastructure.Data
{
    public class PetTypeRepository : IPetTypeRepository
    {
        public PetType Create(PetType petType)
        {
            petType.Id = FakeDB.type_id++;
            FakeDB.petTypes.Add(petType);
            return petType;
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
            throw new NotImplementedException();
        }

        public List<PetType> readPetTypes()
        {
            return FakeDB.petTypes;
        }
    }
}
