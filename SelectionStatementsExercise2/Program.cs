namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(
                "Hello! Out of Math, English, Art, Science, History, and Computers. Which is your favorite?");
            string class = Console.ReadLine();
            
            case "Math":
                Console.WriteLine("Math, its okay.");
                break;
            case "English":
                Console.WriteLine("English, its okay.");
                break;
            case "Art":
                Console.WriteLine("Art, its okay.");    
                break;
            case "Science":
                Console.WriteLine("Science is great.");
                break;
            case "History":
                Console.WriteLine("History is great.");
                break;
            case "Computers":
                Console.WriteLine("Computers, you know it!");       
                break;
            default:
                Console.WriteLine("Please enter a valid option, please try again. Recess is not an option.");
                break;


        }
    }
}