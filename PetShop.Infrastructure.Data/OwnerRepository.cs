﻿using PetShop.Core.DomainService;
using PetShop.Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace PetShop.Infrastructure.Data
{
    public class OwnerRepository : IOwnerRepository
    {
        public Owner Create(Owner owner)
        {
            owner.Id = FakeDB.owner_id++;
            FakeDB.owners.Add(owner);
            return owner;
        }

        public Owner Delete(int id)
        {
            Owner owner = GetOwnerById(id);
            if (owner != null)
            {
                FakeDB.owners.Remove(owner);
                return owner;
            }
            return null;
        }

        public Owner Edit(Owner ownerEdit)
        {
            Owner owner = GetOwnerById(ownerEdit.Id);
            if (owner != null)
            {
                owner.name = ownerEdit.name;
                owner.Pets = ownerEdit.Pets;
                
                return owner;
            }
            return null;
        }

        public Owner GetOwnerById(int id)
        {
            foreach (var owner in FakeDB.owners)
            {
                if (owner.Id == id)
                {
                    return owner;
                }

            }
            return null;
        }

        public List<Owner> ReadOwners(string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                List<Owner> filteredList = new List<Owner>();

                foreach (var Owner in FakeDB.owners)
                {
                    if (Owner.name.ToLower() == name.ToLower())
                    {
                        filteredList.Add(Owner);
                    }

                }


                return filteredList;

            }
            else
            {
                return FakeDB.owners;
            }


            
        }
    }
}
