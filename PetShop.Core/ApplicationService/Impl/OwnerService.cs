using PetShop.Core.DomainService;
using PetShop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop.Core.ApplicationService.Impl
{
    public class OwnerService : IOwnerService
    {

        private IOwnerRepository _ownerRepository;
        private IPetRepository _petRepository;
        public OwnerService(IOwnerRepository ownerRepository,
            IPetRepository petRepository)
        {
            _ownerRepository = ownerRepository;
            _petRepository = petRepository;
        }

        public Owner NewOwner(string name)
        {
            Owner newOwner = new Owner();
            newOwner.name = name;
            
            return newOwner;
        }

        public Owner CreateOwner(Owner owner)
        {
            return _ownerRepository.Create(owner);
        }

        public Owner DeleteOwner(int id)
        {
            return _ownerRepository.Delete(id);
        }

        public Owner EditOwner(Owner ownerEdit)
        {
            return _ownerRepository.Edit(ownerEdit);
        }

        public Owner GetOwnerById(int id)
        {
            return _ownerRepository.GetOwnerById(id);
        }

        public List<Owner> GetOwners(string name)
        {
            return _ownerRepository.ReadOwners(name);
        }


    }
}
