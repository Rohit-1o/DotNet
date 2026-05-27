using System.Reflection;


namespace _19Demo_Events_Delegate
{
    public delegate void ResultHandler (int mark);
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            // += Coupling Operator
            student._Pass += new ResultHandler(student.pass_stud);
            student._Fail += new ResultHandler(student.fail_stud);

            Console.WriteLine("Please enter your Marks :");
            student.Marks = Convert.ToInt32(Console.ReadLine());

            ResultHandler passDel = new ResultHandler(student.pass_stud);
            ResultHandler failDel = new ResultHandler(student.fail_stud);

            //if (mark > 40)
            //{
            //    student.pass_stud(mark);
            //    passDel(mark);
            //}
            //else
            //{
            //    student.fail_stud(mark);
            //    failDel(mark);
            //}
        }
    }

    public class Student
    {
        // Members
        public event ResultHandler _Pass;
        public event ResultHandler _Fail;

        private int _marks;
        public int Marks
        {
            set
            {
                _marks = value;
                if (_marks > 40)
                {
                    // We can invoke events only within the same class
                    _Pass.Invoke(Marks);
                }
                else
                {

                }
            }
            get
            {
                return _marks;
            }
        }

        public void pass_stud(int mark)
        {
            Console.WriteLine($"Congratulations..! You have passed with {mark} mark");
        }

        public void fail_stud(int mark)
        {
            Console.WriteLine($"Congratulations..! You have Fail with {mark} mark");
        }
    }
}
