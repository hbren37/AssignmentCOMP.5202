using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Question_2
{//Helen Brennan 9981703
    class Employee
    {
        public string Fullname { get; set; }
        public double Tax { get; set; }
        public double Gross { get; set; } // getters and setters for employee info all public



        public Employee(string fullname, double tax, double gross)
        {
            Fullname = fullname; //constructor
            Tax = tax;
            Gross = gross;
            Console.Write("Employee record created");

        }
        public double CalcNet()
        {
            return Gross * (1 - Tax / 100);//method to calculate net salary
        }






        static void Main(string[] args)
        {
            Console.Write("Welcome to Payroll 345, please enter your employees details\n");
            Console.Write("Please enter employee full name\n");
            string fullname = Console.ReadLine();
            Console.Write("Please enter required tax rate\n");
            double tax = double.Parse(Console.ReadLine());
            Console.Write("Please enter annual gross salary\n");
            double gross = double.Parse(Console.ReadLine());


            Employee e1 = new Employee(fullname, tax, gross);

            Console.WriteLine($"Full name: {e1.Fullname}\nTax: {e1.Tax}%\nAnnual Gross Salary: {e1.Gross}");
            Console.Write($"Net Salary: {e1.CalcNet()}");



            Console.ReadLine();


        }
    }
}















