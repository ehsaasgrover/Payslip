using System;

namespace Payslip
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ");
            Console.WriteLine("Welcome to the payslip generator!");
            Console.WriteLine(" ");

            // Calling Functions
            Name name = new Name();
            name.inputName();

            Salary salary = new Salary();
            salary.inputSalary();
            salary.inputRate();

            Dates dates = new Dates();
            dates.inputDates();

            Console.WriteLine(" ");
            Console.WriteLine("Your Payment has been generated:");
            Console.WriteLine(" ");

            name.newName();
            Console.WriteLine(" ");

            dates.payPeriod();
            Console.WriteLine(" ");

            salary.grossIncome();
            Console.WriteLine(" ");

            salary.incomeTax();
            Console.WriteLine(" ");

            salary.netIncome();
            Console.WriteLine(" ");

            salary.super();
            Console.WriteLine(" ");

            Console.WriteLine(" ");
            Console.WriteLine("Thank you for using MYOB!");
        }

        class Name
        {
            string firstName;
            string surname;

            // Taking user input
            public void inputName()
            {
                Console.Write("Please input your name: ");
                firstName = Console.ReadLine();
                Console.Write("Please input your surname: ");
                surname = Console.ReadLine();
            }
            
            // Putting together first and last name
            public String newName()
            {
                string name = firstName + " " + surname;
                Console.Write("Name: " + name);
                return name;
            }
        }

        class Salary
        {
            int salary;
            double tax;
            int gross;
            int rate;
            
            // Salary user input
            public void inputSalary()
            {
                Console.Write("Please enter your annual salary: ");
                salary = Convert.ToInt32(Console.ReadLine());
            }

            // Super Rate user input
            public void inputRate()
            {
                Console.Write("Please enter your super rate: ");
                rate = Convert.ToInt32(Console.ReadLine());
            }

            // Calculating gross income
            public int grossIncome()
            {
                gross = salary / 12;
                Console.Write("Gross Income: " + gross);
                return gross;
            }

            // Calculating income tax
            public int incomeTax()
            {
                if ((salary >= 18201) && (salary <= 37000))
                {
                    tax = ((salary - 18200) * 0.19) / 12;
                }
                else if ((salary >= 37001) && (salary <= 87000))
                {
                    tax = (3572 + (salary - 37000) * 0.325) / 12;
                }
                else if ((salary >= 87001) && (salary <= 180000))
                {
                    tax = (19822 + (salary - 87000) * 0.37) / 12;
                }
                else if (salary >= 180001)
                {
                    tax = (54232 + (salary - 180000) * 0.45) / 12;
                }
                Console.Write("Income Tax: " + Convert.ToInt32(tax));
                return Convert.ToInt32(tax);
            }

            // Calculating net income
            public int netIncome()
            {
                int net;
                net = gross - Convert.ToInt32(tax);
                Console.Write("Net Income: " + net);
                return net;
            }

            // Calculating super 
            public int super()
            {
                double super;
                super = gross * (rate * 0.01);
                Console.Write("Super: " + Convert.ToInt32(super));
                return Convert.ToInt32(super);
            }
        }

        class Dates
        {
            string startDate;
            string endDate;

            // User input start and end dates
            public void inputDates()
            {
                Console.Write("Please enter your start date: ");
                startDate = Console.ReadLine();
                Console.Write("Please enter your end date: ");
                endDate = Console.ReadLine();
            }

            // Output pay period
            public String payPeriod()
            {
                string dates = (startDate + " – " + endDate);
                Console.Write("Pay Period: " + startDate + " - " + endDate);
                return dates;
            }
        }
    }
}