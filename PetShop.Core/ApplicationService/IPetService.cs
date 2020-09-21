using PetShop.Core.Entity;
using System;
using System.Collections.Generic;

namespace PetShop.Core.ApplicationService
{
    public interface IPetService
    {

        //New Pet
        public Pet NewPet(string name, string type, DateTime birthdate, string color, string previousowner, double price);

        //Create //POST
        public Pet CreatePet(Pet pet);

        //Read //GET
        public List<Pet> GetPets(string name);

        //public List<Pet> GetPetsSortedByPrice();
        
        public List<Pet> FindPetsByType(string searchString);
        public Pet GetPetById(int id);

        //Update //PUT
        public Pet EditPet(Pet petEdit);

        //Delete //DELETE
        public Pet DeletePet(int id);




    }
}
