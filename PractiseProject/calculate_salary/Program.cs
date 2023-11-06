using System.Data;
using System.Data.OleDb;
using System.Text;
using NPOI.XSSF.UserModel;
using NPOI.SS.UserModel;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Employee> employeeList = new List<Employee>();

        string connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\project\\exam300sample\\PractiseProject\\calculate_salary\\exercise.xlsx;Extended Properties=Excel 12.0;";
        using (OleDbConnection oledbConn = new OleDbConnection(connString))
        {
            oledbConn.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM [Input$]", oledbConn);
            OleDbDataAdapter oleda = new OleDbDataAdapter();
            oleda.SelectCommand = cmd;
            DataSet ds = new DataSet();
            oleda.Fill(ds);

            foreach (var m in ds.Tables[0].DefaultView)
            {
                Console.OutputEncoding = Encoding.UTF8;
                Console.WriteLine(((DataRowView)m).Row.ItemArray[0] + "       | " + ((DataRowView)m).Row.ItemArray[1] + "   | " + ((DataRowView)m).Row.ItemArray[2]);
                employeeList.Add
                    (new Employee
                    {
                        EmployeeName = ((DataRowView)m).Row.ItemArray[0].ToString(),
                        Department = ((DataRowView)m).Row.ItemArray[1].ToString(),
                        GrossSalary = Int32.Parse(((DataRowView)m).Row.ItemArray[2].ToString())
                    }
                    );
            }
        }

        double ttncn = 0;
        double tntt = 0;
        Console.Write("\n Nhập tháng dưới dạng số từ 1 -> 12 :  ");
        int month = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("----------------------\n");

        foreach (var m in employeeList)
        {
            tntt = m.GrossSalary - 11000000;
            if (month < 1 && month > 12)
            {
                return;
            }

            if(month % 2 ==0)
            {
                if (m.Department=="manager")
                {
                    if (tntt >= 0 && tntt <= 5000000) //5%
                    {
                        m.GrossSalary = m.GrossSalary * 0.5;                               
                        m.GrossSalary = m.GrossSalary + (m.GrossSalary * 0.30);
                        Console.WriteLine("Salary's Employeee work in Manager Department :  " + m.EmployeeName + "  | " + m.Department + " | " + m.GrossSalary);
                    }
                    else if (tntt > 5000000 && tntt <= 10000000) //10%
                    {

                        m.GrossSalary = (m.GrossSalary + 5000000) * 0.1;
                        m.GrossSalary = m.GrossSalary + (m.GrossSalary * 0.30);
                        Console.WriteLine("Salary's Employeee work in Manager Department :  " + m.EmployeeName + "   | " + m.Department + " | " + m.GrossSalary);
                    }

                    else if (tntt > 10000000 && tntt <= 18000000) //15%
                    {

                        m.GrossSalary = (m.GrossSalary + 5000000 + 5000000 + 8000000)*0.15;
                        m.GrossSalary = m.GrossSalary + (m.GrossSalary * 0.30);
                        Console.WriteLine("Salary's Employeee work in Manager Department :  " + m.EmployeeName + "  | " + m.Department + " | " + m.GrossSalary);
                    }

                    else if (tntt > 18000000 && tntt <= 32000000) //20%
                    {

                        m.GrossSalary = (m.GrossSalary + 18000000 + 14000000)*0.20;
                        m.GrossSalary = m.GrossSalary + (m.GrossSalary * 0.30);
                        Console.WriteLine("Salary's Employeee work in Manager Department :  " + m.EmployeeName + "  | " + m.Department + " | " + m.GrossSalary);
                    }

                    else if (tntt > 32000000 && tntt <= 52000000)//25%
                    {

                        m.GrossSalary = (m.GrossSalary + 18000000 + 14000000+ 2000000)*0.25;
                        m.GrossSalary = m.GrossSalary + (m.GrossSalary * 0.30);
                        Console.WriteLine("Salary's Employeee work in Manager Department :  " + m.EmployeeName + "   0| " + m.Department + " | " + m.GrossSalary);
                    }

                    else if (tntt > 52000000 && tntt <= 80000000) //30%
                    {
                        
                        m.GrossSalary = (m.GrossSalary+32000000+20000000+28000000)*0.30;
                        m.GrossSalary = m.GrossSalary + (m.GrossSalary * 0.30);
                        Console.WriteLine("Salary's Employeee work in Manager Department :  " + m.EmployeeName + " | " + m.Department + " | " + m.GrossSalary);
                    }
                    else //35%
                    {
                       

                        m.GrossSalary = (m.GrossSalary + 52000000+80000000+9000000)*0.35;
                        m.GrossSalary = m.GrossSalary + (m.GrossSalary * 0.30);
                        Console.WriteLine("Salary's Employeee work in Manager Department :  " + m.EmployeeName + "  | " + m.Department + " | " + m.GrossSalary);
                    }

                }
                if (m.Department=="leader")
                {
                    if (tntt >= 0 && tntt <= 5000000) //5%
                    {
                        m.GrossSalary = m.GrossSalary * 0.5;
                        m.GrossSalary = (m.GrossSalary - (m.GrossSalary * 0.105) - ttncn);
                       
                        Console.WriteLine("Salary's Employeee work in Leader Department  :  " + m.EmployeeName + " | " + m.Department + "  | " + m.GrossSalary);
                    }

                    else if (tntt > 5000000 && tntt <= 10000000) //10%
                    {
                        m.GrossSalary = (m.GrossSalary + 5000000) * 0.1;

                        Console.WriteLine("Salary's Employeee work in Leader Department  :  " + m.EmployeeName + " | " + m.Department + "  | " + m.GrossSalary);
                    }

                    else if (tntt > 10000000 && tntt <= 18000000) //15%
                    {
                        m.GrossSalary = (m.GrossSalary + 5000000 + 5000000 + 8000000) * 0.15;

                        Console.WriteLine("Salary's Employeee work in Leader Department  :  " + m.EmployeeName + " | " + m.Department + "  | " + m.GrossSalary);
                    }

                    else if (tntt > 18000000 && tntt <= 32000000) //20%
                    {

                        m.GrossSalary = (m.GrossSalary + 18000000 + 14000000) * 0.20;
                        Console.WriteLine("Salary's Employeee work in Leader Department  :  " + m.EmployeeName + "  | " + m.Department + "  | " + m.GrossSalary);
                    }

                    else if (tntt > 32000000 && tntt <= 52000000)//25%
                    {
                        m.GrossSalary = (m.GrossSalary + 18000000 + 14000000+ 20000000)*0.25;

                        Console.WriteLine("Salary's Employeee work in Leader Department  :  " + m.EmployeeName + "  | " + m.Department + "  | " + m.GrossSalary);
                    }

                    else if (tntt > 52000000 && tntt <= 80000000) //30%
                    {
                        m.GrossSalary = (m.GrossSalary + 32000000+20000000 + 28000000)*0.30;

                        Console.WriteLine("Salary's Employeee work in Leader Department  :  " + m.EmployeeName + "  | " + m.Department + "  | " + m.GrossSalary);
                    }
                    else //35%
                    {
                        m.GrossSalary = (tntt + 80000000) + (89000000-80000000)*0.35;

                        Console.WriteLine("Salary's Employeee work in  Leader Department        :  " + m.EmployeeName + "      | " + m.Department + "  | " + m.GrossSalary);
                    }
                }
                if (m.Department =="employee")
                {
                    if (tntt >= 0 && tntt <= 5000000) //5%
                    {
                        m.GrossSalary = m.GrossSalary * 0.5;
                        m.GrossSalary = (m.GrossSalary - (m.GrossSalary * 0.105) - ttncn);

                        Console.WriteLine("Salary's Employeee work in Department         :  " + m.EmployeeName + "  | " + m.Department + "| " + m.GrossSalary);
                    }

                    else if (tntt > 5000000 && tntt <= 10000000) //10%
                    {
                        m.GrossSalary = (m.GrossSalary + 5000000) * 0.1;

                        Console.WriteLine("Salary's Employeee work in Department         :  " + m.EmployeeName + "  | " + m.Department + "| " + m.GrossSalary);
                    }

                    else if (tntt > 10000000 && tntt <= 18000000) //15%
                    {
                        m.GrossSalary = (m.GrossSalary + 5000000 + 5000000 + 8000000) * 0.15;

                        Console.WriteLine("Salary's Employeee work in Department         :  " + m.EmployeeName + "  | " + m.Department + "| " + m.GrossSalary);
                    }

                    else if (tntt > 18000000 && tntt <= 32000000) //20%
                    {

                        m.GrossSalary = (m.GrossSalary + 18000000 + 14000000) * 0.20;
                        Console.WriteLine("Salary's Employeee work in Department         :  " + m.EmployeeName + "  | " + m.Department + "| " + m.GrossSalary);
                    }

                    else if (tntt > 32000000 && tntt <= 52000000)//25%
                    {
                        m.GrossSalary = (m.GrossSalary + 18000000 + 14000000 + 20000000) * 0.25;

                        Console.WriteLine("Salary's Employeee work in Department         :  " + m.EmployeeName + "  | " + m.Department + "| " + m.GrossSalary);
                    }

                    else if (tntt > 52000000 && tntt <= 80000000) //30%
                    {
                        m.GrossSalary = (m.GrossSalary + 32000000 + 20000000 + 28000000) * 0.30;

                        Console.WriteLine("Salary's Employeee work in Department         :  " + m.EmployeeName + "  | " + m.Department + "| " + m.GrossSalary);
                    }
                    else //35%
                    {
                        m.GrossSalary = (tntt + 80000000) + (89000000 - 80000000) * 0.35;

                        Console.WriteLine("Salary's Employeee work in Department         :  " + m.EmployeeName + "  | " + m.Department + "| " + m.GrossSalary);
                    }

                  
                }
            }

        }


        //XSSFWorkbook wb = new XSSFWorkbook();
        //ISheet sheet = wb.CreateSheet();
        //var row = sheet.CreateRow(0);
        //row.CreateCell(1).SetCellValue("Employee");
        //row.CreateCell(2).SetCellValue("Department");
        //row.CreateCell(3).SetCellValue("Gross Salary");

        //int rowIndex = 1;
        //foreach (var item in employeeList)
        //{
        //    var newRow = sheet.CreateRow(rowIndex);
        //    newRow.CreateCell(1).SetCellValue(item.EmployeeName);
        //    newRow.CreateCell(2).SetCellValue(item.Department);
        //    newRow.CreateCell(3).SetCellValue(item.GrossSalary);
        //    rowIndex++;
        //}
        //FileStream fs = new FileStream(@"D:\project\exam300sample\PractiseProject\calculate_salary\exercise1.xlsx", FileMode.CreateNew);
        //wb.Write(fs);
        Console.ReadLine();


    }

    public class Employee
    {
        public string EmployeeName { get; set; }
        public string Department { get; set; }
        public double GrossSalary { get; set; }
    }
}