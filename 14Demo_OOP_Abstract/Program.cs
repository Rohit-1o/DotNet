namespace _14Demo_OOP_Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Parse --> Validate --> Save
            #region old
            //PDF pdf = new PDF();
            //pdf.GenerateReport();
            //pdf.Validate();
            //pdf.Save();
            //pdf.Parse(); 
            #endregion
            while (true)
            {
                Console.WriteLine("1. PDF");
                int reportchoice = Convert.ToInt32(Console.ReadLine());

                ReportFactory factory = new ReportFactory();
                Report report =  factory.GetsomeReport(reportchoice);
                report.GenerateReport();

                Console.WriteLine("Do you want to continue:? y/n :");
            }
        }
    }
    
    public abstract class Report
    {
        protected abstract void Parse();
        protected abstract void Validate();
        protected abstract void Save();
        public virtual void GenerateReport()
        {
            // Parse --> Validate --> Save
            Parse();
            Validate();
            Save();
            Console.WriteLine("Report generated successfully..!");
        }
    }

    public class ReportFactory
    {
        public Report GetsomeReport(int ch)
        {
            Report reportobj = null;
            switch (ch)
            {
                case 1:
                    reportobj = new PDF();
                    break;
            }
            return reportobj;
        }
    }

    
    public class PDF : Report
    {
        protected override void Parse()
        {
            Console.WriteLine("PDF Parsed");
        }

        protected override void Validate()
        {
            Console.WriteLine("PDF Validated");
        }

        protected override void Save()
        {
            Console.WriteLine("PDF Saved");
        }
    }
}
