using System;

namespace GroseryShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            double tomatoPrice = 4.50;
            double cucumberPrice = 2.80;
            ;
            
            Console.Write("Hello and Welcome to our grocery shop,");
            Console.WriteLine("today we have fresh tomatoes and cucumbers.");
            Console.WriteLine("How many kilos of tomatoes,would you like?\n");
            double tomatoWeight = double.Parse(Console.ReadLine());
            double totalPrice = tomatoPrice * tomatoWeight;
            Console.WriteLine($"You need to pay:{totalPrice:F2}lv");
            Console.WriteLine("Would you like something else?\n");
            string answer = Console.ReadLine();
            while (answer != "no")
            {
                Console.WriteLine("Good,would you like some cucumbers?");
                string answerCucumbers = Console.ReadLine();    
                if (answerCucumbers == "yes")
                {
                    Console.WriteLine("How much cucumbers do you want?");
                    double answerCucmbersWeight = double.Parse(Console.ReadLine());
                    double finalPrice = totalPrice + cucumberPrice * answerCucmbersWeight;
                    Console.WriteLine($"Great,all together you need to pay:{finalPrice:F2}");
                    break;
                    
                }
                else  
                {
                    Console.WriteLine("We do not have any more vegetables ");
                    break;

                }
                answer = Console.ReadLine();
            }
            Console.WriteLine("Thank you for your shoping and see you next week");






        }
    }
}

