using PetShop.Core.DomainService;
using PetShop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop.Infrastructure.Data
{
    public class PetRepository : IPetRepository
    {
        public Pet Create(Pet pet)
        {
            pet.Id = FakeDB.id++;
            FakeDB.pets.Add(pet);
            return pet;
        }

        public Pet Delete(int id)
        {
            Pet pet = GetPetById(id);
            if (pet != null)
            {
                FakeDB.pets.Remove(pet);
                return pet;
            }
            return null;
        }

        public Pet Edit(Pet petEdit)
        {
            Pet pet = GetPetById(petEdit.Id);
            if (pet != null)
            {
                pet.Name = petEdit.Name;
                pet.SoldDate = petEdit.SoldDate;
                pet.Price = petEdit.Price;
                pet.PreviousOwner = petEdit.PreviousOwner;

                return pet;
            }
            return null;
        }

        public Pet GetPetById(int id)
        {
            foreach (var pet in FakeDB.pets)
            {
                if (pet.Id == id)
                {
                    return pet;
                }

            }
            return null;
        }

        public List<Pet> ReadPets()
        {
            return FakeDB.pets;
        }

        public List<Pet> FindPetsByType(string searchString)
        {
            List<Pet> SearchedPets = new List<Pet>();
            foreach (var pet in FakeDB.pets)
            {
                if (pet.Type.ToLower() == searchString)
                {
                    SearchedPets.Add(pet);
                }
            }
            return SearchedPets;
        }


        public void InitData()
        {
            Datainitializer.InitData();
        }

    }
}
