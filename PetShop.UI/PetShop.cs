using PetShop.Core.ApplicationService;
using PetShop.Core.ApplicationService.Impl;
using PetShop.Core.DomainService;
using PetShop.Infrastructure.Data;
using System;

namespace PetShop.UI
{
    class PetShop
    {
        
        static void Main(string[] args)
        {

            
            IPetRepository _petRepository = new PetRepository();
            IPetService _petService = new PetService(_petRepository);

            _petRepository.InitData(); //seed data
            
            var printer = new Printer(_petService);
            printer.topMenu();

        }
    }
}
