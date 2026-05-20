
namespace CMathLib
{
    public class CMath
    {
        // Accessible with the same assembly as well as outside the assembly/ with OR without inheritance
        public void Add(int x, int y)
        {
            Console.WriteLine($"Public : Addition = {x + y}");
        }

        // Accessible only within the class
        private void Sub(int x, int y)
        {
            Console.WriteLine($"Private : Subtraction =  {x - y}");
        }

        // Accessible only within inherited hirarchey
        protected void Mul(int x, int y)
        {
            Console.WriteLine($"Protected : Multiplication = {x * y}");
        }

        // Only accessible within the same assembly:/ Public to in the same assembly
        internal void Div(int x, int y)
        {
            Console.WriteLine($"Internal : Division = {x / y}");
        }

        // Accessible only within inherited hirarchey as well as Public to same assembly
        protected internal void Square(int x)
        {
            Console.WriteLine($"Protected Internal : Square = {x * x}");
        }
    }

    public class MyClass
    {
        CMath obj = new CMath();
        public void Test()
        {
            obj.Square(4);
            obj.Div(100, 20);
            obj.Add(100, 20);
        }
    }

    public class Demo : CMath
    {
        public void MyDemo()
        {
            base.Square(8);     // Protected Iinternal
            base.Mul(15, 3);    // Protected
            base.Div(100, 20);  // Internal
            base.Add(100, 20);  // Public
        }
    }
}
