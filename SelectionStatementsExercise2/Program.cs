using System.Runtime.InteropServices;

namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(
                "Hello! Out of Math, English, Art, Science, History, and Computers. Which is your favorite?");
            string class1 = Console.ReadLine();
            switch (class1.ToLower())
            {
                case "math":
                Console.WriteLine("Math, its okay.");
                break;
                case "english":
                Console.WriteLine("English, its okay.");
                break;
                case "art":
                Console.WriteLine("Art, its okay.");
                break;
                case "science":
                Console.WriteLine("Science is great.");
                break;
                case "history":
                Console.WriteLine("History is great.");
                break;
                case "computers":
                Console.WriteLine("Computers, you know it!");
                break;
                default:
                Console.WriteLine("Please enter a valid option, please try again. Recess is not an option.");
                break;
            }

        }
    }
}