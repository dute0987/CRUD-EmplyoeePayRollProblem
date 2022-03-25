using System;
namespace EmployeePayRoll
{
    class Program
    {
        public static void Main(string[]args)
        {
            Console.WriteLine("Welcome to Employee PayRoll");

            EmployeeRepo repo = new EmployeeRepo();
            EmployeeModel employee = new EmployeeModel();

            employee.EmployeeName = "Vishal Dute";
            employee.PhoneNumber = "9887899787";
            employee.Address = "Mumbai";
            employee.Department = "HR";
            employee.Gender = 'M';
            employee.BasicPay = 2200.00;
            employee.Deduction = 1500.00;
            employee.TaxablePay = 200.00;
            employee.Tax = 300.00;
            employee.NetPay = 2500.00;
            employee.City = "Mumbai";
            employee.Country = "India";

            repo.AddEmployee(employee);
        }
    }
}