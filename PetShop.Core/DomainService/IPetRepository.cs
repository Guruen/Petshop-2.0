using PetShop.Core.Entity;
using System.Collections.Generic;

namespace PetShop.Core.DomainService
{
    public interface IPetRepository
    {
        IEnumerable<Pet> ReadPets();
        Pet Create(Pet pet);
        Pet Edit(Pet petEdit);
        Pet Delete(int id);
        Pet GetPetById(int id);
        IEnumerable<Pet> FindPetsByType(string searchString);
    }
}
