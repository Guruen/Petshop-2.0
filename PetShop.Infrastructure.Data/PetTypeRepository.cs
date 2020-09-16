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
            PetType petType = GetPetTypeById(id);
            if (petType != null)
            {
                FakeDB.petTypes.Remove(petType);
                return petType;
            }
            return null;
        }

        public PetType Edit(PetType petTypeEdit)
        {
            PetType petType = GetPetTypeById(petTypeEdit.Id);
            if (petType != null)
            {
                petType.name = petTypeEdit.name;

                return petType;
            }
            return null;
        }

        public PetType GetPetTypeById(int id)
        {
            foreach (var petType in FakeDB.petTypes)
            {
                if (petType.Id == id)
                {
                    return petType;
                }

            }
            return null;
        }

        public List<PetType> readPetTypes()
        {
            return FakeDB.petTypes;
        }
    }
}
