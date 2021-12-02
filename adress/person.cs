using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adress
{
    public class person
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter the First name:");
            string FirstName = Console.ReadLine();

            Console.WriteLine("enter the Last name:");
            string LastName = Console.ReadLine();

            Console.WriteLine("enter the Email id:");
            string EmailMailId = Console.ReadLine();

            Console.WriteLine("enter the phone number");
            int PhoneNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the adress:");
            string Address = Console.ReadLine();

            Console.WriteLine("enter the city:");
            string city = Console.ReadLine();

            Console.WriteLine("enter the state:");
            string state = Console.ReadLine();

            Console.WriteLine("enter the country:");
            string country = Console.ReadLine();

            Console.WriteLine("enter the Zip code:");
            int ZipCode = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("=========================");

            Console.WriteLine("the address of the person is ");

            Console.WriteLine("Name: " + FirstName + LastName);
            Console.WriteLine("Phone Number: " + PhoneNumber);
            Console.WriteLine("Address : " + Address);
            Console.WriteLine("State : " + state);
            Console.WriteLine("country : " + country);
            Console.WriteLine("zip code : " + ZipCode);
        }
    }
}
        
      