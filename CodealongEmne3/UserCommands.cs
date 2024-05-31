using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CodealongEmne3
{
    public static class UserCommands
    {
        public static List<Dyr> Dyreliste = new List<Dyr>();
        private static string GetUserData(string message)
        {
            Console.Write(message);
            var output = Console.ReadLine();

            return output;
        }

        public static Dyr ChoiceMenu()
        {
            Console.WriteLine("1. Dog");
            Console.WriteLine("2. Cat");
            var userInput = GetUserData("What animal do you wanna make: ");
            Console.Clear();
            (string name, string art, int age) = SetPetInfo();

            var output = MakeAnimal(userInput, name, art, age);

            return output;
        }

        private static Dyr MakeAnimal(string choice, string name, string art, int age)
        {
            Dyr output = null;

            switch (choice)
            {
                case "1":
                    output = new Dog(name, art, age);
                    break;
                case "2":
                    output = new Cat(name, art, age);
                    break;
            }
            return output;
        }

        private static (string, string, int) SetPetInfo()
        {
            var navn = GetUserData("What is the name of the pet: ");
            var art = GetUserData("what is the race of the pet: ");
            var check = int.TryParse(GetUserData("what is the age of the pet: "), out int AgeInt);
            (string, string, int) output = (null, null, 0);

            if (check)
            {
                output = (navn, art, AgeInt);
            }
            else
            {
                Console.WriteLine("Not a valid age!");
                SetPetInfo();
            }
            return output;
        }

        public static void ShowAnimal(List<Dyr> list)
        {
            Console.WriteLine("would you like to search or show all?");
            var choice = GetUserData("type 1 for easy and 2 for show all: ");

            switch (choice)
            {
                case "1":
                    //SearchAnimal();
                    break;
                case "2":
                    foreach (var animel in list)
                    {
                        animel.Info();
                    }

                    break;
            }
        }
    }
}
