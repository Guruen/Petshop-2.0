using PetShop.Core.DomainService;
using PetShop.Core.Entity;
using System;
using System.Collections.Generic;

namespace PetShop.Core.ApplicationService.Impl
{
    public class PetService : IPetService
    {

        private IPetRepository _petRepository;

        public PetService(IPetRepository petRepository)
        {
            _petRepository = petRepository;
        }

        public Pet NewPet(string name, string type, DateTime birthdate, string color, string previousowner, double price)
        {
            Pet newPet = new Pet();
            
            newPet.Name = name;
            newPet.Type = type;
            newPet.Birthdate = birthdate;
            newPet.Color = color;
            newPet.PreviousOwner = previousowner;
            newPet.Price = price;
            
            return newPet;
        }


        public Pet CreatePet(Pet pet)
        {
            return _petRepository.Create(pet);
        }

        public Pet DeletePet(int id)
        {
            return _petRepository.Delete(id);
        }

        public Pet EditPet(Pet petEdit)
        {
            return _petRepository.Edit(petEdit);
        }

        public List<Pet> GetPets(string name)
        {
            _petRepository.ReadPets(name).Sort((x, y) => x.Id.CompareTo(y.Id));
            return _petRepository.ReadPets(name);
        }

        // move to filtered return
        //public List<Pet> GetPetsSortedByPrice()
        //{
        //    _petRepository.ReadPets().Sort((x, y) => x.Price.CompareTo(y.Price));
        //    return _petRepository.ReadPets();

        //}

        public List<Pet> FindPetsByType(string searchString)
        {
            return _petRepository.FindPetsByType(searchString);
        }


        public Pet GetPetById(int id)
        {
            return _petRepository.GetPetById(id);
        }
    }
}
