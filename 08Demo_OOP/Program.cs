namespace _08Demo_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Demo 01
            //Derived derived = new Derived(567);
            //Console.WriteLine(derived._baseid);
            //derived.show();

            //Base baseobj = new Derived(67);
            //baseobj.show(); 
            #endregion

            Derived d = new Derived(4);
            d.Display();
            d.Method1();
            d.Method1("Rohit");
        }
    }

    public class Base
    {
        public int _baseid;
        public Base(int id)
        {
            _baseid = id;
        }

        public void show()
        {
            Console.WriteLine("Show method from Base class");
        }
        public virtual void Display()
        {
            Console.WriteLine("Display method from Base class");
        }
        public virtual void Method1()
        {
            Console.WriteLine("Method1 method from Base class");
        }
    }

    public class Derived : Base
    {
        public int _derivedid;

        //This is constructor mapping / chaning
        public Derived(int id) : base(id)
        {
            _derivedid = 2;
        }

        //Shadowing
        public new void show()
        {
            Console.WriteLine("Show method from Derived class");
        }

        public override void Display()
        {
            Console.WriteLine("Display method from Derived class");
        }

        public void Method1(string nm)
        {
            Console.WriteLine($"Method1 method from Derived class {nm}");
        }
    }
}
