using Microsoft.VisualBasic.FileIO;
using PetShop.Core.Entity;
using System;
using System.Collections.Generic;

namespace PetShop.Core.ApplicationService
{
    public interface IPetService
    {
        public List<Pet> GetPets();
        public Pet NewPet(string name, string type, DateTime birthdate, string color, string previousowner, double price);
        public Pet DeletePet(int id);
        public Pet EditPet(Pet petEdit);
        public Pet CreatePet(Pet pet);
        public List<Pet> GetPetsSortedByPrice();
        public List<Pet> FindPetsByType(string searchString);
        public Pet GetPetById(int id);



    }
}
