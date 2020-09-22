using PetShop.Core.DomainService;
using PetShop.Core.Entity;
using System;
using System.Collections.Generic;

namespace PetShop.Core.ApplicationService.Impl
{
    public class PetService : IPetService
    {

        readonly IPetRepository _petRepository;
        readonly IPetTypeRepository _petTypeRepository;
        readonly IOwnerRepository _ownerRepository;

        public PetService(IPetRepository petRepository,
            IPetTypeRepository petTypeRepository,
            IOwnerRepository ownerRepository)
        {
            _petRepository = petRepository;
            _petTypeRepository = petTypeRepository;
            _ownerRepository = ownerRepository;
        }

        public Pet NewPet(string name, PetType type, DateTime birthdate, string color, Owner owner, double price)
        {
            Pet newPet = new Pet();
            
            newPet.Name = name;
            newPet.PetType = type;
            newPet.Birthdate = birthdate;
            newPet.Owner = owner;
            newPet.Color = color;
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
            List<Pet> pets = _petRepository.ReadPets(name);
            foreach (var pet in pets)
            {
                pet.PetType = _petTypeRepository.GetPetTypeById(pet.PetType.Id);
                pet.Owner = _ownerRepository.GetOwnerById(pet.Owner.Id);
            }
            return pets;
        }

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
