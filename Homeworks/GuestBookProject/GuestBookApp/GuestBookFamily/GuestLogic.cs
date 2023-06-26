using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestBookFamily
{
    public static class GuestLogic
    {
        public static void AuthorMessage()
        {
            Console.WriteLine("In this program, you can enter the arriving guests and know how many guests there are.");
            Console.WriteLine("This application was built by Juan Jose Figueroa");
            Console.WriteLine("----------------------------------------------------");

            Console.WriteLine();
        }

        public static void WelcomeMessage() 
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Guest Book Aplication");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("1. Add a new guest.");
            Console.WriteLine("2. View the guest list and the total number of guests");
            Console.WriteLine("3. Exit the program");
        }

        public static int MenuOption()
        {
            int output;
            bool isValidOption;

            do
            {
                Console.Write("Please enter the option you want to choose: ");
                isValidOption = int.TryParse(Console.ReadLine(), out output);
                if (!isValidOption || (output > 3 || output < 1))
                {
                    isValidOption = false;
                    Console.WriteLine("Please enter a valid option.");
                }
            } while (isValidOption == false);
            return output;
        }

        public static string GetFamilyName()
        {
            string output;
            do
            {
                Console.Write("Please enter the last name of the family: ");
                output = Console.ReadLine();
                if (output == string.Empty)
                {
                    Console.Clear();
                    Console.WriteLine("Please enter a valid LastName.");
                }
            } while (output == string.Empty);
            return output;
        }

        public static int GetFamilySize() 
        {
            bool isValidNumber = false;
            int _numberFamily = default;
            while (!isValidNumber)
            {
                Console.Write("Please enter the number of family members: ");
                isValidNumber = int.TryParse(Console.ReadLine(), out _numberFamily);
                if (!isValidNumber || _numberFamily < 0)
                {
                    isValidNumber = false;
                    Console.WriteLine("Please enter a valid number.");
                }
            }
            return _numberFamily;
        }

        public static Family GetGuests()
        {
            string _lastName = GetFamilyName();
            int _numberFamily =  GetFamilySize();
            var newFamily = new Family() { lastName = _lastName, numberFamilyMembers = _numberFamily };
            return newFamily;
        }

        public static List<Family> GetGuestList()
        {
            List<Family> output = new()
            {
                new Family() { lastName = "Figueroa", numberFamilyMembers = 4},
                new Family() { lastName = "Zambrano", numberFamilyMembers = 3},
                new Family() { lastName = "Enriquez", numberFamilyMembers = 6},
                new Family() { lastName = "Pinzon", numberFamilyMembers = 3},
                new Family() { lastName = "Guerrero", numberFamilyMembers = 4},
                new Family() { lastName = "Muñoz", numberFamilyMembers = 5},
            };
            return output;
        }

        public static List<Family> AddGuest(List<Family> GuestList, Family family)
        {
            GuestList.Add(family);
            return GuestList;
        }

        public static int AllGuest(List<Family> guestList)
        {
            int output = 0;
            guestList.ForEach(guest => output += guest.numberFamilyMembers);
            return output;
        }

        public static void PrintGuestList(List<Family> guestList)
        {
            Console.WriteLine("Guest List");
            Console.WriteLine("LastName - Number of Family members");
            int count = 1;
            foreach (Family family in guestList)
            {
                Console.WriteLine($"{count++}. {family.lastName} - {family.numberFamilyMembers}");
            }
            Console.WriteLine("---------------------------------------");
            Console.WriteLine($"At the moment, there are {AllGuest(guestList)} number of people at the party.");
        }



    }
}
