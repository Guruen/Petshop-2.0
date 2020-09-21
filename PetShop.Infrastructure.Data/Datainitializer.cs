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
            
            Pet p = new Pet();
            p.Id = FakeDB.pet_id++;
            p.Name = "P1";
            p.Type = "Fish";
            p.Birthdate = DateTime.Now.AddDays(-10);
            p.SoldDate = DateTime.Now;
            p.Color = "Green";
            p.PreviousOwner = "";
            p.Price = 27.5;
            FakeDB.pets.Add(p);

            Pet p1 = new Pet();
            p1.Id = FakeDB.pet_id++;
            p1.Name = "P2";
            p1.Type = "Baboon";
            p1.Birthdate = DateTime.Now.AddDays(-20);
            p1.SoldDate = DateTime.Now;
            p1.Color = "Brown";
            p1.PreviousOwner = "";
            p1.Price = 7.5;
            FakeDB.pets.Add(p1);


            Owner o = new Owner();
            o.Id = FakeDB.owner_id++;
            o.name = "Bob Bobson";
            o.petsowned = "1, 2";
            FakeDB.owners.Add(o);

            Owner o1 = new Owner();
            o1.Id = FakeDB.owner_id++;
            o1.name = "John Johnson";
            o1.petsowned = "1, 2";
            FakeDB.owners.Add(o1);

            PetType pT = new PetType();
            pT.Id = FakeDB.type_id++;
            pT.name = "Fish";
            FakeDB.petTypes.Add(pT);

            PetType pT1 = new PetType();
            pT1.Id = FakeDB.type_id++;
            pT1.name = "Whale";
            FakeDB.petTypes.Add(pT1);

            PetType pT2 = new PetType();
            pT2.Id = FakeDB.type_id++;
            pT2.name = "Baboon";
            FakeDB.petTypes.Add(pT2);

        }

    }
}
