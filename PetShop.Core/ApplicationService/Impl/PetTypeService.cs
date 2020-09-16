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
        public PetType CreatePetType(PetType petType)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public PetType NewPetType(string name)
        {
            throw new NotImplementedException();
        }
    }
}
