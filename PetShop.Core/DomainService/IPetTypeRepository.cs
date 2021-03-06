﻿using PetShop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop.Core.DomainService
{
    public interface IPetTypeRepository
    {
        IEnumerable<PetType> readPetTypes();
        PetType Create(PetType petType);
        PetType Edit(PetType petTypeEdit);
        PetType Delete(int id);
        PetType GetPetTypeById(int id);

    }
}
