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
        public OwnerService(IOwnerRepository ownerRepository)
        {
            _ownerRepository = ownerRepository;
        }

        public Owner NewOwner(string name, string petsowned)
        {
            Owner newOwner = new Owner();
            newOwner.name = name;
            newOwner.petsowned = petsowned;
            
            return newOwner;
        }

        public Owner CreateOwner(Owner owner)
        {
            return _ownerRepository.Create(owner);
        }

        public Owner DeleteOwner(int id)
        {
            throw new NotImplementedException();
        }

        public Owner EditOwner(Owner ownerEdit)
        {
            throw new NotImplementedException();
        }

        public Owner GetOwnerById(int id)
        {
            return _ownerRepository.GetOwnerById(id);
        }

        public List<Owner> GetOwners()
        {
            return _ownerRepository.ReadOwners();
        }


    }
}
