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

        public Owner CreateOwner(Pet pet)
        {
            throw new NotImplementedException();
        }

        public Owner DeleteOwner(int id)
        {
            throw new NotImplementedException();
        }

        public Owner EditOwner(Owner ownerEdit)
        {
            throw new NotImplementedException();
        }

        public Owner GetOPwnerById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Owner> GetOwners()
        {
            return _ownerRepository.ReadOwners();
        }

        public Owner NewOwner(string name, string petsowned)
        {
            throw new NotImplementedException();
        }
    }
}
