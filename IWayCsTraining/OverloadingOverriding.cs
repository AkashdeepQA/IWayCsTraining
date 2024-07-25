using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWayCsTraining
{
    class Employee
    {
        protected string name;
        protected string position;
        protected double baseSalary;

        public Employee()
        {
            this.name = "Unknown";
            this.position = "Unknown";
            this.baseSalary = 0;
        }

        
        public Employee(string name, string position)
        {
            this.name = name;
            this.position = position;
            this.baseSalary = 50000;
        }

        public Employee(string name, string position, double baseSalary)
        {
            this.name = name;
            this.position = position;
            this.baseSalary = baseSalary;
        }

        public virtual double CalculateSalary()
        {
            Console.WriteLine("Total salary of Employee is: " + this.baseSalary);
            return this.baseSalary;
        }
        public void PrintDetails()
        {
            Console.WriteLine($"Details: \n Name: {this.name}\n Position: {this.position}" +
                $"\n Salary: INR{this.baseSalary}");
        }
    }

    class RegularEmployee: Employee
    {
        double travelAllowance;
        public RegularEmployee(string name, string position, double baseSalary, double travelAll): base(name, position, baseSalary)
        {
            this.travelAllowance = travelAll;
        }

        public override double CalculateSalary()
        {
            double total = this.baseSalary + this.travelAllowance;
            Console.WriteLine("Total salary of Regular Employee is: " + total);
            return total;
        }
    }

    class Manager : Employee
    {
        double bonus;
        public Manager(string name, string position, double baseSalary, double bonus) : base(name, position, baseSalary)
        {
            this.bonus = bonus;
        }

        public override double CalculateSalary()
        {
            double total = this.baseSalary + this.bonus;
            Console.WriteLine("Total salary of Manager is: " + total);
            return total;
        }
    }

    class SalesPerson : Employee
    {
        double incentive;
        double travelAllowance;
        public SalesPerson(string name, string position, double baseSalary, double incentive, double travelAllowance) : base(name, position, baseSalary)
        {
            this.incentive = incentive;
            this.travelAllowance = travelAllowance;
        }

        public override double CalculateSalary()
        {
            double total = this.baseSalary + this.incentive + this.travelAllowance;
            Console.WriteLine("Total salary of Sales Person is: " + total);
            return total;
        }
    }
}
