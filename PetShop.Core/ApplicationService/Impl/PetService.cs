using PetShop.Core.DomainService;
using PetShop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

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

        public List<Pet> GetPets()
        {
            return _petRepository.ReadPets().ToList();
        }

        public Pet GetPetById(int id)
        {
            return _petRepository.GetPetById(id);
        }

    }
}
