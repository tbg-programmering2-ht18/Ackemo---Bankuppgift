using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Program
    {
        public static List<Customer> customerlist = new List<Customer>();


        static void Main(string[] args)
        {
            int choice = 0;
            //testing so many times
            //While är början till en loop som fortsätter tills villkoret inte stämmer längre, i detta fall så länge switch inte är 4
            while (choice != 7)
            {
                Console.WriteLine("Welcome to my bank!");

                Console.WriteLine("");
                Console.WriteLine("Pick your poison!");
                Console.WriteLine("");
                Console.WriteLine("1 : Add new customer");
                Console.WriteLine("2 : Show all customer");
                Console.WriteLine("3 : Remove a user from bank");
                Console.WriteLine("4 : Check balance");
                Console.WriteLine("5 : Make a deposit");
                Console.WriteLine("6 : Make a withdrawal");
                Console.WriteLine("7 : Shutdown");
                Console.WriteLine("");
                Console.Write("What would you like to do? ");

                // Try "testar" användarens inmatningsdata, och är den av felaktigt format går den över till en catch
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }

                // Catch är fallet som sker ifall tryen inte är rätt.
                catch (Exception e)
                {
                    Console.Clear();
                    //Console.WriteLine("Vet du inte ens hur man skriver en siffra?!?");
                    Console.WriteLine("ERROR " + e.Message);
                    Console.ReadKey();
                    //Console.WriteLine("Man, you're stupid!");
                    //Console.ReadKey();
                    choice = 0;
                    Console.Clear();
                }
                
                //switch är selektoren som läser av ditt val och "skickar" dig till de olika cases som finns
                switch (choice)
                {
                    //Varje case har en egen uppgift, den här låter dig lägga till en användare/customer med funktionen addCustomer
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Add customer");
                        addCustomer();
                        Console.Clear();
                        break;

                    //Den här visar upp alla customers som är registrerad
                    case 2:
                        Console.Clear();
                        foreach (var Customer in customerlist)
                        {
                            Console.WriteLine("User: {0}", Customer.name);
                        }
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    //Den här tar bort en användare/customer med funktionen removeCustomer
                    case 3:
                        Console.Clear();
                        foreach (Customer info in customerlist)
                        {
                            Console.WriteLine(info.customerInfo());
                        }
                        removeCustomer();
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("");
                        Console.WriteLine("Ooops... still under construction");
                        /*foreach (Customer info in customerlist)
                        {
                            Console.WriteLine(info.customerInfo());
                        }*/
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 5:
                        Console.Clear();
                        Console.WriteLine("");
                        Console.WriteLine("Ooops... still under construction");
                        /*foreach (Customer info in customerlist)
                        {
                            Console.WriteLine(info.customerInfo());
                        }
                        addBalance();*/
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 6:
                        Console.Clear();
                        Console.WriteLine("");
                        Console.WriteLine("Ooops... still under construction");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }

            //Här är "case 4", d.v.s. om switch = 4, och då är while loopen inte true och stänger av loopen och hela programet.
            Console.Clear();
            Console.WriteLine("Thank you for visiting my bank! Please return soon!");
            Console.WriteLine("Click any button to turn off program!");
            Console.ReadKey();
        }

        //Här är funktionen som lägger till en användare/customer
        public static void addCustomer()
        {
            Console.WriteLine("");
            Console.Write("Name of customer: ");
            string name = Console.ReadLine();
            Customer customer = new Customer();
            customer.name = name;
            customerlist.Add(customer);
        }

        //Här är funktionen som tar bort en användare
        public static void removeCustomer()
        {
            Console.WriteLine("");
            Console.WriteLine("Write the full name of the customer you'd like to delete!");
            string customerToDelete = Console.ReadLine();
            Customer objectToDelete = null;
            foreach (Customer info in customerlist)
            {
                if (info.name == customerToDelete)
                    objectToDelete = info;
            }
            customerlist.Remove(objectToDelete);
            Console.Clear();
        }

        /*private static void addBalance()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("Write the full name of the customer you'd like to make a deposit!");
            int customerBalanceAdd = int.Parse(Console.ReadLine());
            Customer balanceToAdd = null;
            balanceToAdd = int.Parse(   Console.ReadLine());
            foreach (Customer info in customerlist)
            {
                if (info.balance == customerBalanceAdd)
                    balanceToAdd = info;
            }
            customerlist.Add(balanceToAdd);
            Console.Clear();
        }*/
    }
}