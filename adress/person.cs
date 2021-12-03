using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adress
{
    public class person
    {
        public static object AddressBook { get; private set; }

        public static void Main(string[]args)
        {
            Hashtable AdressBook = new Hashtable();

            while (true)
            {
                Console.WriteLine("\n#############Adress Book###########");
                Console.WriteLine("\t1:Add number to Adress book");
                Console.WriteLine("\t2:Get number to Adress book");
                Console.WriteLine("\t3:Exit");
                Console.WriteLine("\n#################################");
                Console.WriteLine("\n\nEnter choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        {
                            Console.WriteLine("Enter your name : ");
                            string  name = Console.ReadLine();

                            Console.WriteLine("Enter your phone number : ");
                             long number = Convert.ToInt64(Console.ReadLine());

                            AdressBook.Add(name, number);
                        }
                            break;
                    case 2:
                        {
                            long number = 0;
                            string name;

                            Console.Write("Enter your name : ");
                            name = Console.ReadLine();

                            if (AdressBook[name] == null)
                            {
                                Console.WriteLine("Given name is not found in phonebook");
                            }
                            else
                            {
                                number = Convert.ToInt64(AdressBook[name]);
                                Console.WriteLine("Name: " + name + ", phone number: " + number);
                            }
                        }
                          break;
                    case 3:
                        {
                            goto OUT;
                        }
                           break;
                    default:
                        {
                            Console.WriteLine("\nYou have entered wrong choice");
                        }
                        break;
                }
            }

          OUT:
                 Console.WriteLine("\nThankyou for using Adressbook");
        }
    }
}