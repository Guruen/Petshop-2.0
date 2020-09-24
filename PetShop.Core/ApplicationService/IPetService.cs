using PetShop.Core.Entity;
using System;
using System.Collections.Generic;

namespace PetShop.Core.ApplicationService
{
    public interface IPetService
    {

        //New Pet
        public Pet NewPet(string name, PetType type, DateTime birthdate, string color, Owner owner, double price);

        //Create //POST
        public Pet CreatePet(Pet pet);

        //Read //GET
        public List<Pet> GetPets();

        //public List<Pet> GetPetsSortedByPrice();
        
        public Pet GetPetById(int id);

        //Update //PUT
        public Pet EditPet(Pet petEdit);

        //Delete //DELETE
        public Pet DeletePet(int id);




    }
}
