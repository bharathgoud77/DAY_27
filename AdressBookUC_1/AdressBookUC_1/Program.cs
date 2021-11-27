using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adressbook
{
    class Program
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public Double PhoneNumber { get; set; }
        public string Email { get; set; }
        public void displayContact()
        {
            Console.WriteLine("FirstName ; " + this.FirstName + "LastName:" + LastName + "Adress:" + Address +

                "City:" + City + "State:" + State + "ZipCode:" + ZipCode + "PhoneNumber:" + PhoneNumber);


        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Name , Last name ,Adress,City,State,Zip Code,Phone NUmber,Email\n");
            Program objprogram = new Program()
            {
                FirstName = Console.ReadLine(),
                LastName = Console.ReadLine(),
                Address = Console.ReadLine(),
                City = Console.ReadLine(),
                State = Console.ReadLine(),
                ZipCode = Convert.ToInt32(Console.ReadLine()),
                PhoneNumber = Convert.ToDouble(Console.ReadLine()),

                Email = Console.ReadLine()
            };
            objprogram.displayContact();
            Console.ReadKey();
        }
    }
}
