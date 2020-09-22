using PetShop.Core.DomainService;
using PetShop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop.Infrastructure.SQLite.Data.Repositories
{
    public class PetRepository : IPetRepository
    {
        public Pet Create(Pet pet)
        {
            throw new NotImplementedException();
        }

        public Pet Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Pet Edit(Pet petEdit)
        {
            throw new NotImplementedException();
        }

        public List<Pet> FindPetsByType(string searchString)
        {
            throw new NotImplementedException();
        }

        public Pet GetPetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Pet> ReadPets(string name)
        {
            throw new NotImplementedException();
        }
    }
}
