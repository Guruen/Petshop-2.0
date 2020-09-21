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
            pet.Id = FakeDB.pet_id++;
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
                pet.Type = petEdit.Type;
                pet.Birthdate = petEdit.Birthdate;
                pet.SoldDate = petEdit.SoldDate;
                pet.Color = petEdit.Color;
                pet.PreviousOwner = petEdit.PreviousOwner;
                pet.Price = petEdit.Price;

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

        public List<Pet> ReadPets(string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                List<Pet> filteredList = new List<Pet>();

                foreach (var Pet in FakeDB.pets)
                {
                    if (Pet.Name.ToLower() == name.ToLower())
                    {
                        filteredList.Add(Pet);
                    }

                }

                return filteredList;

            }
            else
            {
                return FakeDB.pets;
            }
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


    }
}
