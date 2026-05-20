using _04Demo;
namespace _04Demo
{


    namespace two
    {
        public enum Week { Mon, Tue, Wed }

    }

    internal class Program
    {
        string name = "Rohit Goud";
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World..");
            Console.WriteLine(two.Week.Mon);
            Console.WriteLine(two.Week.Tue);
        }
    }
}