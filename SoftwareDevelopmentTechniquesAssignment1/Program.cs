using System;

namespace SoftwareDevelopmentTechniquesAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Go();
            Console.ReadKey();
        }

        enum Tickets
        {
            Cubs = 200, Blackhawks = 280, Bears = 470
        }
        
        public void Go()
        {
            decimal numberOfTickets = 0 ;
            decimal totalNumberOfTickets = 0 ;
            decimal totalPrice = 0;
            var games = Enum.GetValues(typeof(Tickets));
            foreach (Tickets ticket in games)
            {
                Console.Write("How many {0} tickets do you want?: ", ticket);
                string gameString = Console.ReadLine();
                if (gameString != null)
                {
                    numberOfTickets = decimal.Parse(gameString);
                }
            }
            var names = Enum.GetNames(typeof(Tickets));
            foreach (string name in names)
            {
                int price = (int)Enum.Parse(typeof(Tickets), name);
                Console.WriteLine("You bought {0} for {1}", name, (numberOfTickets*price).ToString("c"));
                totalNumberOfTickets += numberOfTickets;
                totalPrice += numberOfTickets * price;
                
            }
            decimal averagePrice = totalPrice / totalNumberOfTickets;

            Console.WriteLine("You spent total of {0}", totalPrice.ToString("c"));
            Console.WriteLine("Your average spending was {0}", averagePrice.ToString("c"));
        }
    }
}
