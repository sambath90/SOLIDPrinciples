using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples
{
    public class ReportGenerate
    {
        public Employee emp { get; private set; }
        public ReportGenerate(Employee emp)
        {
            this.emp = emp;
        }
        public void Calculate()
        {
            emp.NetSalary = emp.GrossSalary - emp.Deduction;
            Console.WriteLine("net salary calculated :  {0} ", emp.NetSalary);
        }
        public virtual void GeneateReport()
        {
        }
    }

    public class PdfReport : ReportGenerate
    {

        public PdfReport(Employee emp) : base(emp)
        {

        }

        public override void GeneateReport()
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine(emp.EmpName);
            Console.WriteLine("PDF report generated");
        }
    }
    public class XlsRport : ReportGenerate
    {
        public XlsRport(Employee emp) : base(emp)
        {

        }
        public override void GeneateReport()
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine(emp.EmpName);
            Console.WriteLine("XLS report generated");
        }
    }
    public class CsvReport : ReportGenerate
    {
        public CsvReport(Employee emp) : base(emp)
        {
        }
        public override void GeneateReport()
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine(emp.EmpName);
            Console.WriteLine("CSV report generated");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.EmpName = "sambath";
            emp.EmpCode = "15786";
            emp.MobileNo = "9488588135";
            emp.Deduction = 1000;
            emp.GrossSalary = 15000;

            ReportGenerate rep = new ReportGenerate(emp);
            rep.Calculate();

            rep = new PdfReport(emp);
            rep.GeneateReport();

            rep = new XlsRport(emp);
            rep.GeneateReport();

            rep = new CsvReport(emp);
            rep.GeneateReport();
            Console.ReadKey();
        }
    }



    public class Employee
    {
        public string EmpName { get; set; }
        public string EmpCode { get; set; }
        public string MobileNo { get; set; }
        public decimal Deduction { get; set; }
        public decimal GrossSalary { get; set; }
        public decimal NetSalary { get; set; }
    }


}
