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
        public int NumberBuilding = 0;
        public int NumberFlat = 0;
        static void Main(string[] args)
        {
            Address adr = new Address("Aleksey","Lukin","Russia","Moscow","Moscow","Lesnaya Street",6,11);
            Console.WriteLine(adr.Name);
            Console.WriteLine(adr.Surname);
            Console.WriteLine(adr.Country);
            Console.WriteLine(adr.Region);
            Console.WriteLine(adr.City);
            Console.WriteLine(adr.Street);
            Console.WriteLine(adr.NumberBuilding);
            Console.WriteLine(adr.NumberFlat);
            Console.ReadLine();

        }
        
        // Обратите внимание на ряд особенностей конструктора. 
        //Во-первых, конструктор называется как класс.Раз наш класс называется Adress, значит и конструктор должен
        //называться точно также.
        //И во-вторых, конструктор, в отличие от других методов класса, не возвращает никакого значения (даже типа void). 

        public Address(string Name,string Surname, string Country, string Region, string City, string Street, int numberBuilding, int NumberFlat)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Country = Country; 
            this.Region = Region;
            this.City = City;   
            this.Street = Street;
            this.NumberBuilding=6;
            this.NumberFlat = 11;
        }
    }
}
//Что делает наш конструктор? Он записывает передаваемые в него параметры во внутренние переменные 
//класса.Обратите внимание, что называются они одинаково - NumberFlat и NumberFlat, Name и Name и т.д. Компилятор сначала 
//ищет локальную переменную с таким именем, и, если не находит, то переменную класса. Поэтому NumberFlat (и другие) -
//это передаваемые в конструктор параметры.
//Если же нам надо сослаться на переменную класса (при существовании переменной с таким же именем,
//как и передаваемый в функцию параметр), то мы используем ключевое слово this. 
//Оно всегда указывает на текущий экземпляр нашего класса. Таким образом в строчках
