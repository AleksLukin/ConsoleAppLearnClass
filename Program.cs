using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLearnClass
{
    class Address
    {
        public string Name="";
        public string Surname="";
        public string Country="";
        public string Region="";
        public string City = "";
        public string Street = "";
        public int NumberBuilding=0;
        public int NumberFlat=0;
        static void Main(string[] args)
        {
            Address adrOne = new Address
            {
                Name = "Piter",
                Surname = "Shilton",
                Country = "England",
                Region = "Big London",
                City = "London",
                Street = "Trafalgare Square",
                NumberBuilding = 2,
                NumberFlat = 3
            };
            Address adrTwo = new Address
            {
                Name = "Paolo",
                Surname = "Maldini",
                Country = "Italy",
                Region = "Lombardia",
                City = "Milano",
                Street = "Porta-Nuova",
                NumberBuilding = 12,
                NumberFlat = 13
            };
            Address adrThree = new Address
            {
                Name = "Aleksey",
                Surname = "Lukin",
                Country = "Russia",
                Region = "Moscow",
                City = "Moscow",
                Street = "Lesnaya Street",
                NumberBuilding = 6,
                NumberFlat = 8
            };
            Console.Write("Введите фамилию: ");
            string surName=Console.ReadLine();

            if (surName == "Shilton")
            {
                Console.WriteLine(adrOne.Name);
                Console.WriteLine(adrOne.Surname);
                Console.WriteLine(adrOne.Country);
                Console.WriteLine(adrOne.Region);
                Console.WriteLine(adrOne.City);
                Console.WriteLine(adrOne.Street);
                Console.WriteLine(adrOne.NumberBuilding);
                Console.WriteLine(adrOne.NumberFlat);
            }
            if (surName == "Maldini")
            {
                Console.WriteLine(adrTwo.Name);
                Console.WriteLine(adrTwo.Surname);
                Console.WriteLine(adrTwo.Country);
                Console.WriteLine(adrTwo.Region);
                Console.WriteLine(adrTwo.City);
                Console.WriteLine(adrTwo.Street);
                Console.WriteLine(adrTwo.NumberBuilding);
                Console.WriteLine(adrTwo.NumberFlat);
            }
            if (surName == "Lukin")
            {
                Console.WriteLine(adrThree.Name);
                Console.WriteLine(adrThree.Surname);
                Console.WriteLine(adrThree.Country);
                Console.WriteLine(adrThree.Region);
                Console.WriteLine(adrThree.City);
                Console.WriteLine(adrThree.Street);
                Console.WriteLine(adrThree.NumberBuilding);
                Console.WriteLine(adrThree.NumberFlat);
            }
            else
            {
                Console.WriteLine("Такой фамилии нет!");
            }
            Console.ReadKey();

        }
    }
}
