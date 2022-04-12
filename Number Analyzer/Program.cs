class Program
{
    static void Main()
    {
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();

        bool tryAgain = true;
        while (tryAgain == true)
        {
            Console.WriteLine("\n" + name + ", please enter an integer between 1 and 100 ");
            int input = int.Parse(Console.ReadLine());

            if (input >= 1 && input <= 100)
            {
                if (input % 2 != 0 && input < 60)
                {
                    Console.WriteLine(name + ", " + input + " is ODD and less than 60.");
                }
                else if (input % 2 == 0 && input >= 2 && input <= 24)
                {
                    Console.WriteLine(name + ", " + input + " is EVEN and less than 25.");
                }
                else if (input % 2 == 0 && input >= 26 && input <= 60)
                {
                    Console.WriteLine(name + ", " + input + " is EVEN and between 26 and 60 inclusive.");
                }                
                else if (input % 2 == 0 && input > 60)
                {
                    Console.WriteLine(name + ", " + input + " is EVEN and greater than 60.");
                }
                else if (input % 2 != 0 && input > 60)
                {
                    Console.WriteLine(name + ", " + input + " is ODD and greater than 60.");
                }

                Console.WriteLine("\nWould you like to try again? y/n" );
                string restart = Console.ReadLine().ToLower();
            
                if (restart == "y")
                {
                    tryAgain = true;
                }
                else if (restart == "n")
                {
                    Console.WriteLine("Goodbye, "+ name + "!");
                    break;
                }
                else
                {
                    Console.WriteLine("That's not a valid answer. Goodbye " + name + ".");
                    break;
                }
            }
            else
            {
                Console.WriteLine("That was not a valid integer, " + name + ". Let's try again.");
            }
        }
    }
}