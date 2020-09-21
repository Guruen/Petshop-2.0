using PetShop.Core.Entity;
using System.Collections.Generic;

namespace PetShop.Core.DomainService
{
    public interface IPetRepository
    {
        List<Pet> ReadPets(string name);
        Pet Create(Pet pet);
        Pet Edit(Pet petEdit);
        Pet Delete(int id);
        Pet GetPetById(int id);
        List<Pet> FindPetsByType(string searchString);
    }
}
