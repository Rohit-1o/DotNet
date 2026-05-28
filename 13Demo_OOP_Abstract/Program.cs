namespace _13Demo_OOP_Abstract
{

     
    internal class Program
    {
        static void Main(string[] args)
        {
            //Derived derived = new Derived();
            //derived.show();
            //Console.WriteLine(derived.Add(10, 20));
            //derived.Display();

            //Base baseobj = new Base();
            //baseobj.Display();

            Calculator obj = new Calculator();
            obj.Add(10, 20);
            BaseCalculator baseCal = new Calculator();
            baseCal.Add(10, 20);
            CMath cMath = new Calculator();
            cMath.Add(10, 20);


        }
    }

    public abstract class Base
    {
        //Pure virtuaL method
        public abstract void show();
        public abstract void Add(int x, int y);
        public void Display()
        {
            Console.WriteLine("Display from Base");
        }
    }

    public class Derived : Base
    {
        public override void show()
        {
            Console.WriteLine("Show from Derived");
        }

        public override int Add(int x, int y)
        {
            return x+y;
        }

        public new void Display()
        {
            Console.WriteLine("Display from Derived");
        }
    }

    public abstract class CMath
    {
        public abstract void Add(int x, int y);
        public abstract void Sub(int x, int y);
        public abstract void Mul(int x, int y);
    }

    public abstract class BaseCalculator : CMath
    {
        public abstract void Div(int x, int y);
        public override void Add(int x, int y)
        {
            Console.WriteLine($"Add = {x+y}");
        }
    }

    public class Calculator : BaseCalculator
    {
        public override void Sub(int x, int y)
        {
            Console.WriteLine($"Sub = {x - y}");
        }

        public override void Mul(int x, int y)
        {
            Console.WriteLine($"Sub = {x * y}");
        }

        public override void Div(int x, int y)
        {
            Console.WriteLine($"Sub = {x / y}");
        }
    }
}
