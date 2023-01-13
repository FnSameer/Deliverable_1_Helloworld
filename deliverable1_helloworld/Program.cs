using System.Transactions;

namespace deliverable1_helloworld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Solution (1): Hello, World!");
            Console.WriteLine(" ");

            string stg = "Hello, World!";
            Console.WriteLine("Solution (2):" + stg);
            Console.WriteLine(" ");

            Console.WriteLine("Enter a username: ");
            string userName = Console.ReadLine();
            Console.WriteLine("The user's name is: " + userName);
            Console.WriteLine(" ");

            Console.WriteLine("Enter user's age: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("User's age is: " + age);

        }
    }
}