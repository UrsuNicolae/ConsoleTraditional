namespace ConsoleAppTraditional.SOLID
{
    //public class Report
    //{
    //    public string Title { get; set; }
    //    public string Content { get; set; }

    //    public void Generate(string format)
    //    {
    //        if (format == "pdf")
    //        {
    //            Console.WriteLine("Generating PDF report...");
    //        }
    //        else if (format == "excel")
    //        {
    //            Console.WriteLine("Generating Excel report...");
    //        }
    //        else if (format == "word")
    //        {
    //            Console.WriteLine("Generating Word report...");
    //        }
    //        else
    //        {
    //            Console.WriteLine("Unknown report format");
    //        }
    //    }

    //    public void SaveToDatabase()
    //    {
    //        Console.WriteLine("Saving report to database...");
    //    }

    //    public static Report LoadFromDatabase(int reportId)
    //    {
    //        Console.WriteLine("Loading report from database...");
    //        return new Report();
    //    }
    //}

    public class Report
    {
        public string Title { get; set; }
        public string Content { get; set; }
    }

    public interface IReportGenerator
    {
        public void GenerateReport(Report report);
    }

    public class PdfGenerator : IReportGenerator
    {
        public void GenerateReport(Report report)
        {
            Console.WriteLine("Generating PDF report...");
        }
    }

    public class ExcelGenerator : IReportGenerator
    {
        public void GenerateReport(Report report)
        {
            Console.WriteLine("Generating Excel report...");
        }
    }
    
    public class WordGenerator : IReportGenerator
    {
        public void GenerateReport(Report report)
        {
            Console.WriteLine("Generating Word report...");
        }
    }

    public interface IReportRepository
    {
        void SaveToDatabase();

        Report LoadFromDatabase(int reportId);
    }

    public class ReportRepository : IReportRepository
    {
        public ReportRepository(/*contex*/)
        {
            
        }
        public void SaveToDatabase()
        {

            Console.WriteLine("Saving report to database...");
        }

        public Report LoadFromDatabase(int reportId)
        {
            Console.WriteLine("Loading report from database...");
            return new Report();
        }
    }


}
