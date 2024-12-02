using System;

class GreenvilleRevenue
{
    static void Main(string[] args)
    {

        Console.WriteLine("************************************");
        Console.WriteLine("*  The stars shine in Greenville.  *");
        Console.WriteLine("************************************");

        bool running = true;
        while (running)
        {
            Console.WriteLine("\nPlease Enter the following number below from the following menu:");
            Console.WriteLine("1. CALCULATE Greenville Revenue Year-Over-Year");
            Console.WriteLine("2. Exit");


            string choice = Console.ReadLine().Trim();

            switch (choice)
            {
                case "1":

                    CalculateRevenue();
                    break;

                case "2":

                    Console.WriteLine("Thank you for using the Greenville Revenue App, good-bye!");
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid selection. Please enter 1 or 2.");
                    break;
            }
        }
    }

    static void CalculateRevenue()
    {
        int lastYearContestants = GetValidContestantCount("last year");
        int thisYearContestants = GetValidContestantCount("this year");

        const int ticketPrice = 25; 
        int revenue = thisYearContestants * ticketPrice;

        Console.WriteLine();
        Console.WriteLine($"Last year's competition had {lastYearContestants} contestants, and this year's has {thisYearContestants} contestants.");
        Console.WriteLine($"Revenue expected this year is ${revenue}");

        if (thisYearContestants > 2 * lastYearContestants)
        {
            Console.WriteLine("The competition is more than twice as big this year!");
        }
        else if (thisYearContestants > lastYearContestants)
        {
            Console.WriteLine("The competition is bigger than ever!");
        }
        else
        {
            Console.WriteLine("A tighter race this year! Come out and cast your vote!");
        }

        Console.WriteLine("\n************************************");
        Console.WriteLine("*  The stars shine in Greenville.  *");
        Console.WriteLine("************************************");
    }

    static int GetValidContestantCount(string year)
    {
        int contestants;
        while (true)
        {
            Console.Write($"Enter the number of contestants {year} (0 to 30): ");
            if (int.TryParse(Console.ReadLine().Trim(), out contestants) && contestants >= 0 && contestants <= 30)
            {
                return contestants;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 0 and 30.");
            }
        }
    }
}