using PetShop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop.Infrastructure.Data
{
    public static class FakeDB
    {

        private static List<Pet> pets = new List<Pet>();
        static int id = 1;
        public static List<Pet> InitData()
        {
            var pet1 = new Pet()
            {
                ID = id++,
                Name = "Willie",
                PreviousOwner = "Alexander",
                Type = "Dog",
                Price = 1000,
                SoldDate = DateTime.Now,
                BirthDate = DateTime.Now,
                Color = "White",

            };

            pets.Add(pet1);

            var pet2 = new Pet()
            {
                ID = id++,
                Name = "Remus",
                PreviousOwner = "Ute",
                Type = "Cat",
                Price = 100,
                SoldDate = DateTime.Now,
                BirthDate = DateTime.Now,
                Color = "Gray",
            };

            pets.Add(pet2);

            var pet3 = new Pet()
            {
                ID = id++,
                Name = "Bonny",
                PreviousOwner = "Charlotte",
                Type = "Dog",
                Price = 500,
                SoldDate = DateTime.Now,
                BirthDate = DateTime.Now,
                Color = "Blonde"
            };
            pets.Add(pet3);

            var pet4 = new Pet()
            {
                ID = id++,
                Name = "Chichi",
                PreviousOwner = "Nicole",
                Type = "Bird",
                Price = 50,
                SoldDate = DateTime.Now,
                BirthDate = DateTime.Now,
                Color = "Green"
            };
            pets.Add(pet4);

            var pet5 = new Pet()
            {
                ID = id++,
                Name = "Pete",
                PreviousOwner = "Friderikke",
                Type = "Dog",
                Price =2000,
                SoldDate = DateTime.Now,
                BirthDate = DateTime.Now,
                Color = "Black"
            };
            pets.Add(pet5);

            var pet6 = new Pet()
            {
                ID = id++,
                Name = "Greg",
                PreviousOwner = "Kasper",
                Type = "Cat",
                Price = 150,
                SoldDate = DateTime.Now,
                BirthDate = DateTime.Now,
                Color = "White"
            };
            pets.Add(pet6);

            return pets;

        }

        public static int getID()
        {
            return id;
        }
    }
}
