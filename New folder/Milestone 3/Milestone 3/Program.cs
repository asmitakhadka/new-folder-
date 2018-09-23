using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone_3
{
    public class client // class for getting the details of customers//
    {
        string askdetail;
        public static void detail()
        {// void method for asking customer details//
            Console.WriteLine("We are going to take your details first, Thank you!");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Please enter your name followed by the capital letter:");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Please enter your address:");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Please enter the type of deliver - takeaway or eat here:");
            Console.ReadLine();
            Console.Clear();
        }
    }
    public class pizza // class for making the order and payments along with size of pizza//
    {
        string Pizzas;
        int size;
        public static void aboutpizza()
        {  // void method for creating a menu to showing a pizzas//
            Console.WriteLine("These are the Menu of pizza that you have to choose:");
            List<string> Pizzas = new List<string>();
            Pizzas.Add("**-----Capricciosa Pizza--------**");
            Pizzas.Add("**--------Pugliese Pizza------**");
            Pizzas.Add("**-------Quatro Stagioni Pizza--------**");
            Pizzas.Add("**-----Pizzetta Pizza-------**");
            Pizzas.Add("**---------Sicilian pizza------**");

            foreach (string Pizza in Pizzas)
            {
                Console.WriteLine(Pizza);
            }
            Console.WriteLine("Please enter your pizza type:"); //asking a pizza type to customer//
            Console.ReadLine();
            Console.Clear(); //clear a console interface and pass it on next console//
        }
        public static void asksize()
        {//method for asking a size of pizza in inches//
            int size;
            Console.WriteLine("Please select the size of pizza: Sizes in between 1 inch and 30 inches:");
            size = int.Parse(Console.ReadLine());

            if (size <= 10)
            {
                Console.WriteLine("Only on $95 for Regular");
            }
            else if (size <= 20)
            {
                Console.WriteLine("Only on $150 for Medium");
            }
            else if (size < 30)
            {
                Console.WriteLine("Only on $310 for Large");
            }
            string pizza;
            Console.WriteLine($"Thank you for choosing the {size} inches size of pizza.");//greeting for choosing a size of pizza//

            Console.WriteLine("Now you could select another pizza:");

            Console.WriteLine("Do you want to make an order for any drink; Please press Enter and see the list of drinks with prices:"); //asking for drinks and show the prices of that//
            Console.ReadLine();

            var drinks = new List<Tuple<string, int>>();// creating list with tuples//
            drinks.Add(Tuple.Create("**---Cocacola---**", 2));
            drinks.Add(Tuple.Create("**---Fanta---**", 2));
            drinks.Add(Tuple.Create("**---Sprite---**", 3));
            drinks.Add(Tuple.Create("**---Coke Zero---**", 2));
            drinks.Add(Tuple.Create("**---7 UP---**", 2));
            drinks.Add(Tuple.Create("**---L & P---**", 2));

            foreach (var drink in drinks)
            {
                Console.WriteLine(drink);
            }
        }
        public static void payment()
        {//asking for confirmed of customers details//
            int payment;
            Console.WriteLine("Have you entered your complete details above? Please enter 1 for Yes and 0 for No.");
            payment = int.Parse(Console.ReadLine());
            if (payment == 1)
            {
                Console.WriteLine("The details have been confirmed - Now you can make a payment for you pizza:");
            }
            else if (payment == 0)
            {
                Console.WriteLine("Sorry! still need some more details for your order:");
            }
            int pay;// once details is confirmed; asking a customer for making a payment of pizza//
            Console.WriteLine("Proceeded for payment of your order - You have to pay here:");
            pay = int.Parse(Console.ReadLine());

            if (pay <= 100)
            {
                Console.WriteLine($"Wait!! take a change of ${pay - 95} for regular size of pizza:");
            }
            else if (pay <= 160)
            {
                Console.WriteLine($"Wait!! take a change of ${pay - 150} for medium size of pizza:");
            }
            else if (pay <= 320)
            {
                Console.WriteLine($"Wait!! take a change of ${pay - 310} for large size of pizza:");
            }
            Console.WriteLine("THANK YOU FOR VISIT US:");// greeting message after finish of payments//

        }
        public static void Main(string[] args) //Main methods with arguments//
        {//recalling the void methods//
           client.detail();
            aboutpizza();
            asksize();
            payment();
            Console.ReadKey();
        }
    }
}

