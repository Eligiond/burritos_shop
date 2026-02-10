using System;

class Program
{
    static void Main()
    {
        bool running = true;

        while (running)
        {
            Console.Clear();

            Console.WriteLine("=== Burritos Shop Break Even Points Calculator ===");
            Console.WriteLine("1) Using For Loop");
            Console.WriteLine("2) Using While Loop");
            Console.WriteLine("3) Using Do-While Loop");
            Console.WriteLine("4) Exit");
            Console.Write("\nSelect an option: ");

            string input = Console.ReadLine();

            if (input == "1")
            {
                using_for_loop();
            }
            else if (input == "2")
            {
                using_while_loop();
            }
            else if (input == "3")
            {
                using_dowhile_loop();
            }
            else if (input == "4")
            {
                Console.WriteLine("Exiting program...");
                running = false;
            }
            else
            {
                Console.WriteLine("Invalid choice. Press any key to try again.");
                Console.ReadKey();
            }
        }
    }

    // --- Using For Loop ---

    static void using_for_loop()
    {
        Console.WriteLine("Calculating the break-even point using for loop ... ");
        Console.WriteLine("------------------------------------");

        decimal unitprice = 9.00m;
        decimal fixedcost = 1200.00m;
        decimal variablecost = 3.80m;

        int itemsold = 0;
        decimal totalcost = 0.00m;
        decimal totalrevenue = 0.00m;
        decimal profit = 0.00m;

        for (itemsold = 0; ; itemsold++)
        {
            totalcost = fixedcost + (variablecost * itemsold);
            totalrevenue = unitprice * itemsold;
            profit = totalrevenue - totalcost;

            if (profit <= 0)
            {
                Console.WriteLine($"After selling {itemsold} burritos: the profit equals ${profit:F2}.");
            }
            else
            {
                break;
            }
        }

        Console.WriteLine("------------------------");
        Console.WriteLine($"Success. You've turned a profit!");
        Console.WriteLine($"Number of Burritos Sold: {itemsold}");
        Console.WriteLine($"Total Revenue: ${totalrevenue:F2}");
        Console.WriteLine($"Total Cost: ${totalcost:F2}");
        Console.WriteLine($"The profit is ${profit:F2}.");

        Console.WriteLine("\nPress any key to return to menu...");
        Console.ReadKey();
    }

    // --- Using While Loop ---

    static void using_while_loop()
    {
        Console.WriteLine("Calculating the break-even point using while loop ... ");
        Console.WriteLine("------------------------------------");

        // Please Enter Your While Loop Codes Here

        



        Console.WriteLine("\nPress any key to return to menu...");
        Console.ReadKey();

    }

    // --- Using Do-While Loop ---

    static void using_dowhile_loop()
    {
        Console.WriteLine("Calculating the break-even point using do-while loop ... ");
        Console.WriteLine("------------------------------------");

        // Please Enter Your Do-While Loop Codes Here

        





        Console.WriteLine("\nPress any key to return to menu...");
        Console.ReadKey();
    }
}