using PetShop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop.Infrastructure.Data
{
    public static class FakeDB
    {
        public static int pet_id = 1;
        public static List<Pet> pets = new List<Pet>();

        public static int owner_id = 1;
        public static List<Owner> owners = new List<Owner>();

        public static int type_id = 1;
        public static List<PetType> petTypes = new List<PetType>();

    }
}
