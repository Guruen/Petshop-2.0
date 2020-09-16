using PetShop.Core.DomainService;
using PetShop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop.Core.ApplicationService.Impl
{
    public class PetTypeService : IPetTypeService
    {
        private IPetTypeRepository _petTypeRepository;

        public PetTypeService(IPetTypeRepository petTypeRepository)
        {
            _petTypeRepository = petTypeRepository;
        }

        public PetType NewPetType(string name)
        {
            PetType petType = new PetType();

            petType.name = name;

            return petType;
        }

        public PetType CreatePetType(PetType petType)
        {
            return _petTypeRepository.Create(petType);
        }

        public PetType DeletePetType(int id)
        {
            throw new NotImplementedException();
        }

        public PetType EditPetType(PetType petTypeEdit)
        {
            throw new NotImplementedException();
        }

        public List<PetType> GetPetType()
        {
            return _petTypeRepository.readPetTypes();
        }

        public PetType GetPetTypeById(int id)
        {
            return _petTypeRepository.GetPetTypeById(id);
        }


    }
}
