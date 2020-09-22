using PetShop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop.Infrastructure.Data
{
    public class Datainitializer
    {

        public static void InitData()
        {

            var pT = new PetType()
            {
                Id = FakeDB.type_id++,
                name = "Fish"
            };
            FakeDB.petTypes.Add(pT);

            var pT2 = new PetType()
            {
                Id = FakeDB.type_id++,
                name = "Bird"
            };
            FakeDB.petTypes.Add(pT2);

            var p = new Pet()
            {
                Id = FakeDB.pet_id++,
                Name = "John",
                PetType = new PetType() { Id = 1 },
                Birthdate = DateTime.Now.AddDays(-10),
                SoldDate = DateTime.Now,
                Color = "Green",
                Owner = new Owner() { Id = 1 },
                Price = 27.5
            };
            FakeDB.pets.Add(p);

            var p2 = new Pet()
            {
                Id = FakeDB.pet_id++,
                Name = "Jane",
                PetType = new PetType() { Id = 2 },
                Birthdate = DateTime.Now.AddDays(-10),
                SoldDate = DateTime.Now,
                Color = "Green",
                Owner = new Owner() { Id = 1 },
                Price = 88
            };
            FakeDB.pets.Add(p2);

            var o = new Owner()
            {
                Id = FakeDB.owner_id++,
                name = "Bob Bobson"
            };
            FakeDB.owners.Add(o);



        }

    }
}
