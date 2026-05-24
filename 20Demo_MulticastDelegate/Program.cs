namespace _20Demo_MulticastDelegate
{
    internal class Program
    {

        
        public delegate void AnnualFunDelegate();
        static void Main(string[] args)
        {
            AnnualEvent obj = new AnnualEvent();

            // Multicast Delegate
            AnnualFunDelegate fundel = new AnnualFunDelegate(obj.Welcome);
            fundel += obj.Speech;
            
            Console.WriteLine("Is Guest Arrived..!");
            string isArrived = Console.ReadLine();
            if ( isArrived == "y" )
            {
                // += Coupling Operator
                fundel += obj.GuestSpeech;
            }
            else
            {
                // -= Decoupling Operator
                fundel -= obj.GuestSpeech;
            }

            fundel += obj.Dance;
            fundel += obj.Dinner;
            fundel += obj.GoodBye;
            fundel += obj.Packup;

            fundel();
        }
    }
    
    public class AnnualEvent
    {
        public void Welcome()
        {
            Console.WriteLine("Welcome all..!");
        }

        public void Speech()
        {
            Console.WriteLine("Co-ordinate : blah blah blah ");
        }

        public void GuestSpeech()
        {
            Console.WriteLine("Guest : blah blah blah");
        }

        public void Dance()
        {
            Console.WriteLine("Lungi Dance");
        }

        public void Dinner()
        {
            Console.WriteLine("Enjoy your Dinner");
        }

        public void GoodBye()
        {
            Console.WriteLine("Thankyou for Comming");
        }

        public void Packup()
        {
            Console.WriteLine("Pack up..!!");
        }
    }
}
