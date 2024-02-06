using Business.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkSpace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Citizen citizen1 = new Citizen();

            SayHi(name: "Gizem");

            //Arrays
            string[] students = new string[3];
            students[0] = "Gizem";
            SayHi(students[0]);

            for (int i = 0; i < students.Length; i++)
            {
                SayHi(students[i]);
            }

            List<string> newCities = new List<string> { "Ankara", "İstanbul", "İzmir" };
            newCities.Add("Kirklareli");

            string[] cities = new[] { "Ankara", "İstanbul", "İzmir" };

            foreach (string city in newCities)
            {
                Console.WriteLine(city);
            }

            Person person1 = new Person();
            person1.Name = "Gizem";

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);

            Console.ReadLine();
        }

        private static void Variables()
        {
            string message = "hello";
            double price = 100000;
            int number = 100;
            bool isAuthenticated = false;


            string name = "Gizem";
            string surname = "Güneş";
            int birthDate = 1996;
            long citizenId = 12345678910;

            Console.WriteLine(message);
            Console.WriteLine(price * 1.18);
        }

        static void SayHi(string name = "Gizem")
        {
            Console.WriteLine("Hi " + name);
        }

    }

    public class Citizen
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int BirthDate { get; set; }
        public long CitizenId { get; set; }
    };
}