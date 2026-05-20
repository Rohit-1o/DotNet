using System.Security.Cryptography.X509Certificates;

namespace _16Demo_OOP_Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter your Db Choice. 1. MySql, 2. Oracle, 3. SqlServer");
                int dbChoice = Convert.ToInt32(Console.ReadLine());

                DatabaseFactory factory = new DatabaseFactory();
                Database db = factory.GetSomeDatabase(dbChoice);

                Console.WriteLine("Enter your Db operation Choice : 1. Insert, 2. Update, 3. Delete");
                int opCh = Convert.ToInt32(Console.ReadLine());
                switch (opCh)
                {
                    case 1:
                        db.DoInsert();
                        break;

                    case 2:
                        db.DoUpdate();
                        break;

                    case 3:
                        db.DoDelete();
                        break;

                    default:
                        Console.WriteLine("Invalid Db Operation Choice..!!");
                        break;
                }

                Console.WriteLine("Do you want to continue..? y/n");
                string ynch = Console.ReadLine().ToLower(); // means (big and small) : Y, N, y, n
                if ( ynch == "n" )
                {
                    break;
                }
            }
        }
    }

    public abstract class Database
    {
        public Logger _logger = null;
        protected Database() 
        {
            _logger = Logger.GetLoggers();

        }

        protected abstract void Insert();
        protected abstract void Update();
        protected abstract void Delete();
        protected abstract string GetDatabaseName();

        public void DoInsert()
        {
            Insert();
        }
        public void DoUpdate()
        {
            Update();
        }
        public void DoDelete()
        {
            Delete();
        }
    }

    public class DatabaseFactory
    {
        public Database GetSomeDatabase(int choice)
        {
            Database dbobj = null;
            switch (choice)
            {
                case 1:
                    dbobj = new MySqlServer();
                    break;

                case 2:
                    dbobj = new OracleServer();
                    break;

                case 3:
                    dbobj = new SqlServer();
                    break;

                default:
                    dbobj = null;
                    break;
            }
            return dbobj;
        }
    }

    // Single Responsibility Principle (SRP)
    public class MySqlServer : Database
    {
        //private Logger logger = null;
        //public MySqlServer()
        //{
        //    logger = _logger;
        //}

        protected override string GetDatabaseName()
        {
            return "MySql";
        }

        protected override void Insert()
        {
            Console.WriteLine("Insert data in MySql db");
            //_logger.Log("Insert operation done in MySql Db");
        }

        protected override void Update()
        {
            Console.WriteLine("Update data in MySql db");
            //_logger.Log("Update operation done in MySql Db");
        }

        protected override void Delete()
        {
            Console.WriteLine("Delete data in MySql db");
            //_logger.Log("Delete operation done in MySql Db");
        }
    }

    public class OracleServer : Database
    {
        //private Logger logger = null;
        //public OracleServer()
        //{
        //    _logger = Logger.GetLoggers();
        //}

        protected override string GetDatabaseName()
        {
            return "Oracle";
        }

        protected override void Insert()
        {
            Console.WriteLine("Insert data in Oracle db");
            //_logger.Log("Insert operation done in Oracle Db");
        }

        protected override void Update()
        {
            Console.WriteLine("Update data in Oracle db");
            //_logger.Log("Update operation done in Oracle Db");
        }

        protected override void Delete()
        {
            Console.WriteLine("Delete data in Oracle db");
            //_logger.Log("Delete operation done in Oracle Db");
        }

    }


    public class SqlServer : Database
    {
        //private Logger _logger = null;
        //public SqlServer()
        //{
        //    _logger = Logger.GetLoggers();
        //}

        protected override string GetDatabaseName()
        {
            return "SqlServer";
        }

        protected override void Insert()
        {
            Console.WriteLine("Insert data in SqlServer db");
            //_logger.Log("Insert operation done in SQL Db");
        }

        protected override void Update()
        {
            Console.WriteLine("Update data in SqlServer db");
            //_logger.Log("Update operation done in SQL Db");
        }

        protected override void Delete()
        {
            Console.WriteLine("Delete data in SqlServer db");
            //_logger.Log("Delete operation done in SQL Db");
        }
    }

    // Logger is a Singleton class
    public class Logger
    {
        private static Logger _logger = new Logger();
        //private static Logger _logger2 = new Logger();
        //private static Logger _logger3 = new Logger();

        private Logger()
        {
            Console.WriteLine("Logger object created..");
        }

        #region Extra Code
        //public void CreateLogFile()
        //{
        //    Logger.txt create
        //}

        //public static Logger[] GetLoggers()
        //{
        //    // Object Pooling
        //    Logger[] loggers = new Logger[3] { _logger, _logger2, _logger3 };
        //    return loggers;
        //} 
        #endregion

        public static Logger GetLoggers()
        {
            return _logger;
        }

        public void Log(string message)
        {
            // File IO: log.txt
            Console.WriteLine($"--Log : {message} at {DateTime.Now.ToString()} ");
        }
    }
}
