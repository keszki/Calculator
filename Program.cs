namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string read = "error";
            int x = 0;
            int y = 0;

            Console.WriteLine("Welcome to my calculator");
            Console.WriteLine("Current possible actions are:");
            Console.WriteLine("1.Addiction");
            Console.Write("I want to test the: ");
            read = Console.ReadLine();

            Console.Write("Write first number: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Write second number: ");
            y = int.Parse(Console.ReadLine());

            if (read == "error")
            {
                Console.WriteLine("!! !! ERROR !! !!");
            }
            else if (read == "1" || read == "Addiction" || read == "addiction")
            {
                Console.WriteLine("OK Thanks");
            }

            Console.ReadLine();
        }
    }
}