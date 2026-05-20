using CMathLib;
namespace _17Demo_MyMath
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CMath cmath = new CMath();
            cmath.Add(2, 3);

            AdvMath adv = new AdvMath();
            adv.Add(2, 3);
            adv.wrapperMul(5, 7);
            adv.wrapperSquare(9);

            Demo demo = new Demo();
            demo.MyDemo();
        }
    }

    public class AdvMath : CMath
    {
        // Wrapper Method
        public void wrapperMul(int x, int y)
        {
            base.Mul(x, y);
        }

        public void wrapperSquare(int x)
        {
            base.Square(x);
        }
    }
}
