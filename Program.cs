namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int loop = 1;
            string read;
            int x;
            int y;
            int result;

            Console.WriteLine("Welcome to my calculator");
            Console.WriteLine("Current possible actions are:");
            Console.WriteLine("1.Addiction, 2.Subtraction, 3.Multiplication, 4.Division");
            while (loop > 0)
            {
                Console.Write("I want to test the: ");
                read = Console.ReadLine();

                Console.Write("Write the first number: ");
                int.TryParse(Console.ReadLine(), out x);
                Console.Write("Write the second number: ");
                int.TryParse(Console.ReadLine(), out y);

                if (read == "1" || read == "+" || read.ToLower().Contains("add"))
                {
                    result = x + y;

                    Console.WriteLine("Your result is " + result);
                }
                else if (read == "2" || read == "-" || read.ToLower().Contains("sub"))
                {
                    result = x - y;

                    Console.WriteLine("Your result is " + result);
                }
                else if (read == "3" || read == "*" || read.ToLower().Contains("mul"))
                {
                    result = x * y;

                    Console.WriteLine("Your result is " + result);
                }
                else if (read == "4" || read == "/" || read.ToLower().Contains("div"))
                {
                    result = x / y;

                    Console.WriteLine("Your result is " + result);
                }
                else
                {
                    Console.WriteLine("ERROR");
                }
                Console.WriteLine("Do you want to use it again?");
                string LOOP = Console.ReadLine();
                if (LOOP.ToLower().Contains("y"))
                {
                    loop++;
                }
                else
                {
                    Console.WriteLine("You've done " + loop + " loops! :D");

                    loop = 0;
                }
            }

            Console.ReadKey();
        }
    }
}
