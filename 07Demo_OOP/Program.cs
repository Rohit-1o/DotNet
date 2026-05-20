using System.Globalization;

namespace _07Demo_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Person class obj
            //Person person = new Person();
            //person.PID = 1;
            //person.PName = "Gopal Warang";
            //person.PAddress = "123 Main St, Anytown, USA";
            //person.PersonInfo();
            //string info = string.Format("Id: {0}, Name: {1}, Address: {2}",person.PID,person.PName,person.PAddress);
            //Console.WriteLine(info); 
            #endregion

            Employee employee = new Employee();
            employee.EID = 1;
            employee.PID = 2;
            employee.PName = "Rohit Goud";
            employee.PAddress = "Mumbai";
            employee.EDepartment = "Software Development";
            employee.EmployeeInfo();

        }
    }

    public class Person
    {
        public int PID;
        public string PName;
        public string PAddress;

        public void PersonInfo()
        {
            string info = string.Format("ID : {0}, Name : {1}, Address : {2}",PID,PName,PAddress);
            Console.WriteLine(info);
        }

    }

    public class Employee : Person
    {
        public int EID;
        public string EDepartment;

        public void EmployeeInfo()
        {
            string info = string.Format("ID : {0}, Name : {1}, Address : {2}, Department : {3}", EID, PName, PAddress, EDepartment);
            Console.WriteLine(info);
        }
    }
}
