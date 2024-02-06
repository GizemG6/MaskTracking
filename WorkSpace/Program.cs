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

        public class Citizen
        {

            public string Name { get; set; }
            public string Surname { get; set; }
            public int BirthDate { get; set; }
            public long CitizenId { get; set; }

        };
    }
    
}
