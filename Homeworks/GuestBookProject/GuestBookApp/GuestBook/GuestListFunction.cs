using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestBook
{
    public static class GuestListFunction
    {
        public static List<Person> GetGuestList()
        {
            List<Person> output = new()
            {
                new Person() {firstName = "Juan", LastName = "Figueroa"},
                new Person() {firstName = "Marcela", LastName = "Figueroa"},
                new Person() {firstName = "Lidey", LastName = "Figueroa"},
                new Person() {firstName = "Camilo", LastName = "Figueroa"},
                new Person() {firstName = "Jorge", LastName = "Figueroa"},
                new Person() {firstName = "Carmenza", LastName = "Figueroa"},
                new Person() {firstName = "David", LastName = "Enriquez"},
                new Person() {firstName = "Andres", LastName = "Enriquez"},
                new Person() {firstName = "Camila", LastName = "Enriquez"},
                new Person() {firstName = "Sofia", LastName = "Enriquez"},
                new Person() {firstName = "Manuela", LastName = "Smith"},
                new Person() {firstName = "Fernando", LastName = "Smith"},
                new Person() {firstName = "Sara", LastName = "Smith"},
                new Person() {firstName = "Monica", LastName = "Smith"},
                new Person() {firstName = "Frank", LastName = "Jurado"},
                new Person() {firstName = "Vanessa", LastName = "Jurado"},
                new Person() {firstName = "Sofia", LastName = "Jurado"},
                new Person() {firstName = "Flor", LastName = "Jurado"},
                new Person() {firstName = "Nicolas", LastName = "Zambrano"},
                new Person() {firstName = "Monica", LastName = "Zambrano"},
            };
            return output;
        }

        public static List<Person> AddGuest(List<Person> GuestList,Person person)
        {
            GuestList.Add(person);
            return GuestList;
        }

        public static int AllGuest(List<Person> guestList)
        {
            return guestList.Count;     
        }

        public static void PrintGuestList(List<Person> guestList)
        {
            Console.WriteLine("Guest List");
            int count = 1;
            foreach (Person person in guestList)
            {
                Console.WriteLine($"{count++}. { person.LastName } - { person.firstName }");
            }
        }



    }
}
