namespace _09Demo_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Emp emp = new Emp();
            //emp.EId = 22;
            ////emp.set_EId(1);
            //Console.WriteLine(emp.EId);
            ////Console.WriteLine(emp.get_EId());
            //emp.Name = "Hugh Jackman";
            //string nm = emp.Name;
            //Console.WriteLine(nm);
            //Console.WriteLine(string.Format("Id : {0}, Name: {1}",emp.EId,emp.Name));

        }
    }

    public class Emp
    {
        //Fields
        private int _EID;
        private string _Ename;
        private bool _isActive;
        private MyClass _obj;
        private int[] _numbers;

        // Property Syntax:
        // accessModifier DataType PropertyName
        // {
        // set{
        //      pvt fieldname =  value;
        //    }

        // get{
        //      return pvt fieldname;
        //    }
        // }


        //Properties
        public int EID
        {
            set
            {
                if (value == 5) 
                    _EID = value;
                else
                    _EID = 0;
            }
            //get
            //{
            //    return _EID;
            //}
        }

        public string EName
        {
            set
            {
                _Ename = value;
            }
            get
            {
                return _Ename;
            }
        }

        public bool isActive
        {
            set
            {
                _isActive = value;
            }
            get
            {
                return _isActive;
            }
        }

        public MyClass Obj
        {
            set
            {
                _obj = value;
            }
            get
            {
                return _obj;
            }
        }

        public int[] Indices
        {
            set
            {
                _numbers = value;
            }
            get
            {
                return _numbers;
            }
        }

        #region Java like getter setter code Demo
        //public void set_EID(int id)
        //{
        //    if(id == 5)
        //        this._EID = id;
        //    else
        //        this._EID = 0;
        //}
        //public int get_EID()
        //{
        //    return this._EID ;
        //} 
        #endregion

    }

    public class MyClass
    {

    }
}
