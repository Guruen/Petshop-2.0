using PetShop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop.Infrastructure.Data
{
    class Datainitializer
    {

        public static void InitData()
        {
            
            Pet p = new Pet();
            p.Id = FakeDB.id++;
            p.Name = "P1";
            p.Type = "Fish";
            p.Birthdate = DateTime.Now.AddDays(-10);
            p.SoldDate = DateTime.Now;
            p.Color = "Green";
            p.PreviousOwner = "";
            p.Price = 27.5;


            Pet p1 = new Pet();
            p1.Id = FakeDB.id++;
            p1.Name = "P2";
            p1.Type = "Baboon";
            p1.Birthdate = DateTime.Now.AddDays(-20);
            p1.SoldDate = DateTime.Now;
            p1.Color = "Brown";
            p1.PreviousOwner = "";
            p1.Price = 7.5;

            FakeDB.pets.Add(p);
            FakeDB.pets.Add(p1);

        }

    }
}
