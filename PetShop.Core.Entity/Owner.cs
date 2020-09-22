using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop.Core.Entity
{
    public class Owner
    {
        public int Id { get; set; }

        public string name { get; set; }
        
        public List<Pet> Pets { get; set; }
    }
}
