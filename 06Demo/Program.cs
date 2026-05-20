namespace _06Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            //int num;
            //Console.WriteLine("Enter Number : ");
            //num = Convert.ToInt32(Console.ReadLine());

            //if (num > 0)
            //{
            //    Console.WriteLine("It is Positive");
            //}
            //else
            //{
            //    Console.WriteLine("The Number is Negative");
            //}


            // name
            //Console.WriteLine("Enter Your Name :");
            //string name = Console.ReadLine();
            //Console.WriteLine("Hello " + name);

            // Menu Driven
            //Tea Stall
            int choice, qty;
            double total = 0;

            do
            {

                Console.WriteLine("----TEA STALL----");
                Console.WriteLine("=================");
                Console.WriteLine("---- MENU ----");
                Console.WriteLine("1. Tea - Rs.10");
                Console.WriteLine("2. Coffee - Rs.20");
                Console.WriteLine("3. Sandwich - Rs.30");
                Console.WriteLine("4. Exit");

                Console.WriteLine("Enter your Choice");
                choice = Convert.ToInt32(Console.ReadLine());
                
                switch (choice)
                {

                } while (choice != 0) ;
            }
        }
    }
}
