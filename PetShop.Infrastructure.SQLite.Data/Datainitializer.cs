using PetShop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop.Infrastructure.SQLite.Data
{
    public class Datainitializer
    {
        public static void SeedDB(PetShopContext ctx)
        {
            ctx.Database.EnsureDeleted();
            ctx.Database.EnsureCreated();
            var type1 = ctx.PetTypes.Add(new PetType()
            {
                name = "Fish"
            }).Entity;

            var type2 = ctx.PetTypes.Add(new PetType()
            {
                name = "Baboon"
            }).Entity;

            var owner1 = ctx.Owners.Add(new Owner()
            {
                name = "Bob Bobson"

            }).Entity;

            var owner2 = ctx.Owners.Add(new Owner()
            {
                name = "John Johnson"

            }).Entity;

            var pet1 = ctx.Pets.Add(new Pet()
            {

                Name = "John",
                PetType = type1,
                Birthdate = DateTime.Now.AddDays(-10),
                SoldDate = DateTime.Now,
                Color = "Green",
                Owner = owner1,
                Price = 27.5


            }).Entity;


            ctx.SaveChanges();
        }
    }
}
