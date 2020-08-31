using PetShop.Core.ApplicationService;
using PetShop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PetShop.UI
{
    class Printer
    {

        IPetService _petService;

        public Printer(IPetService petService)
        {
            _petService = petService;
        }

        public void topMenu ()
        {
            
            Console.WriteLine("MAIN MENU");
            Console.WriteLine("");
            Console.WriteLine("Select menu item:");
            Console.WriteLine("");
            Console.WriteLine("1: Add new Pet");
            Console.WriteLine("2: Update Pet");
            Console.WriteLine("3: Delete Pet");
            Console.WriteLine("4: Search for Pet (Type)");
            Console.WriteLine("5: List menu ->");
            Console.WriteLine("");
            Console.WriteLine("0: Exit");

            string optionchoosen = Console.ReadLine();
            bool isnumber = int.TryParse(optionchoosen, out int number);

            if (isnumber)
            {
                while (number > 0)
                {
                    switch (number)
                    {
                        case 1:
                            AddPet();
                            break;

                        case 2:
                            UpdatePet();
                            break;

                        case 3:
                            DeletePet();
                            break;

                        case 4:
                            SearchPetType();
                            break;

                        case 5:
                            Console.Clear();
                            listMenu();
                            break;


                        default:
                            Console.WriteLine("");
                            Console.WriteLine("Please select a valid option");
                            Console.WriteLine("Press enter to try again");
                            Console.ReadLine();
                            Console.Clear();
                            topMenu();
                            break;
                    }

                    break;
                }

            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Please input a number");
                Console.WriteLine("Press enter to try again");
                Console.ReadLine();
                Console.Clear();
                topMenu();


            }
        }


        public void listMenu()
        {
         
            Console.WriteLine("LIST MENU");
            Console.WriteLine("");
            Console.WriteLine("Select menu item:");
            Console.WriteLine("");
            Console.WriteLine("1: List all Pets (ID sorting)");
            Console.WriteLine("2: List all Pets (Price Descending)");
            Console.WriteLine("3: List cheapest Pets (5)");
            Console.WriteLine("9: <- Back to Main menu");
            Console.WriteLine("");
            Console.WriteLine("0: Exit");

            string optionchoosen = Console.ReadLine();
            bool isnumber = int.TryParse(optionchoosen, out int number);

            if (isnumber)
            {
                while (number > 0)
                {
                    switch (number)
                    {
                        case 1:
                            ReadAllPets();
                            break;

                        case 2:
                            ListPetsByPrice();
                            break;

                        case 3:
                            List5CheapestPets();
                            break;
                                                    
                        case 9:
                            Console.Clear();
                            topMenu();
                            break;


                        default:
                            Console.WriteLine("");
                            Console.WriteLine("Please select a valid option");
                            Console.WriteLine("Press enter to try again");
                            Console.ReadLine();
                            Console.Clear();
                            listMenu();
                            break;
                    }
                    
                    break;
                }

            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Please input a number");
                Console.WriteLine("Press enter to try again");
                Console.ReadLine();
                Console.Clear();
                listMenu();

            }

        }


        public void AddPet()
        {
            Console.Clear();
            Console.WriteLine("Add new Pet");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Please type in the name of the pet:");
            string petName = Console.ReadLine();
            Console.WriteLine("Please type in what type of pet it is:");
            string petType = Console.ReadLine();
            Console.WriteLine("Please type in the birthdate of the pet (dd/MM/yyyy):");
            string petBirth = Console.ReadLine();
            DateTime c_petBirth = DateTime.Parse(petBirth); //input validation needed
            Console.WriteLine("Please type in the color of the pet:");
            string petColor = Console.ReadLine();
            Console.WriteLine("Please type in the name of the previous owner of the pet (leave blank if no previous owner):");
            string petP_Owner = Console.ReadLine();
            Console.WriteLine("Please type in the price of the pet:");
            string petPrice = Console.ReadLine();
            double c_petPrice = double.Parse(petPrice);

            Pet pet = _petService.NewPet(petName, petType, c_petBirth, petColor, petP_Owner, c_petPrice);
            _petService.CreatePet(pet);

            Console.WriteLine("your pet " + pet.Name + " has been added!");

            backtoMainMenu();

        }

        public void UpdatePet()
        {
            Console.Clear();
            Console.WriteLine("Edit Pet");
            Console.WriteLine("");
            foreach (var pet in _petService.GetPets())
            {
                Console.WriteLine(pet);
            }
            Console.WriteLine("");
            Console.WriteLine("Please type the number of the pet you want to edit:");

            bool isnumber = int.TryParse(Console.ReadLine(), out int number);
            if (isnumber)
            {
                if (number <= _petService.GetPets().Count && number > 0)
                {
                    Pet petEdit = _petService.GetPetById(number);
                    Console.WriteLine("you selected: " + petEdit.Name);
                    Console.WriteLine("");
                    Console.WriteLine("Please type in the name of the pet:");
                    petEdit.Name = Console.ReadLine();
                    Console.WriteLine("Please type in the date the pet was sold (dd/MM/yyyy):");
                    string petSold = Console.ReadLine();
                    petEdit.SoldDate = DateTime.Parse(petSold); //input validation needed
                    Console.WriteLine("Please type in the name of the previous owner of the pet (leave blank if no previous owner):");
                    petEdit.PreviousOwner = Console.ReadLine();
                    Console.WriteLine("Please type in the price of the pet:");
                    string petPrice = Console.ReadLine();
                    petEdit.Price = double.Parse(petPrice);

                    _petService.EditPet(petEdit);

                    
                    Console.WriteLine("the pet was updated!");
                    backtoMainMenu();

                }
                else
                {

                    Console.WriteLine("please select a valid number");
                    Console.WriteLine("Press enter to try again");
                    Console.ReadLine();
                    DeletePet();

                }

            }
            else
            {
                Console.WriteLine("Must be a number");
                Console.WriteLine("Press enter to try again");
                Console.ReadLine();
                DeletePet();
            }

        }

        public void DeletePet()
        {
            Console.Clear();
            Console.WriteLine("Remove Pet");
            Console.WriteLine("");
            foreach (var pet in _petService.GetPets())
            {
                Console.WriteLine(pet);
            }
            Console.WriteLine("");
            Console.WriteLine("Please type the number of the pet you want to remove:");
            Console.WriteLine("");

            bool isnumber = int.TryParse(Console.ReadLine(), out int number);

            if (isnumber)
            {
                if (number <= _petService.GetPets().Count && number > 0)
                {
                    Console.WriteLine("The pet named " + _petService.DeletePet(number) + " has been removed from the list");
                    backtoMainMenu();

                }
                else
                { 

                Console.WriteLine("please select a valid number");
                Console.WriteLine("Press enter to try again");
                Console.ReadLine();
                DeletePet();
                
                }
            
            }
            else
            {
                Console.WriteLine("Must be a number");
                Console.WriteLine("Press enter to try again");
                Console.ReadLine();
                DeletePet();
            }

        }


        public void SearchPetType()
        {
            Console.Clear();
            Console.WriteLine("Search for type of pets");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Please type the type of pet you are searching for:");
            Console.WriteLine("");

            var searchString = Console.ReadLine().ToLower();

            if (_petService.FindPetsByType(searchString).Count <= 0)
            {
                
                Console.WriteLine("No pets found of this type: " + searchString);

            }
            else
            {
                foreach (var pet in _petService.FindPetsByType(searchString))
                {
                    Console.WriteLine(pet);
                }
            }

            backtoMainMenu();

        }


        public void ReadAllPets()
        {
            Console.Clear();
            Console.WriteLine("All pets (ID Sorting)");
            Console.WriteLine("");

            foreach (var pet in _petService.GetPets())
            {
                Console.WriteLine(pet);
            }


            backtoListMenu();

        }


        public void ListPetsByPrice()
        {
            Console.Clear();
            Console.WriteLine("All pets (Price Descending)");
            Console.WriteLine("");

            foreach (var pet in _petService.GetPetsSortedByPrice())
            {
                Console.WriteLine(pet);
            }

            backtoListMenu();

        }

        public void List5CheapestPets()
        {

            Console.Clear();
            Console.WriteLine("5 Cheapest pets");
            Console.WriteLine("");

            foreach (var pet in _petService.GetPetsSortedByPrice().Take(5))
            {
                Console.WriteLine(pet);
            }



            backtoListMenu();

        }


        public void backtoMainMenu()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Press Enter to go back to Main menu");
            Console.ReadLine();
            Console.Clear();
            topMenu();
        }

        public void backtoListMenu()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Press Enter to go back to List menu");
            Console.ReadLine();
            Console.Clear();
            listMenu();
        }
    }
}
