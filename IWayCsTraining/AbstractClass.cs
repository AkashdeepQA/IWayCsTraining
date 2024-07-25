using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWayCsTraining
{
    abstract class Shape
    {
        public abstract void GetArea();

        public abstract void GetPerimeter();

    }

    class Circle : Shape
    {
        double radius;

        public Circle(double r)
        {
            this.radius = r;
        }

        public override void GetArea()
        {
            double area = Math.PI * this.radius * this.radius;
            Console.WriteLine("Area of circle is: " + area);
        }

        public override void GetPerimeter()
        {
            double perimeter = 2 * Math.PI * this.radius;
            Console.WriteLine("Perimeter of circle is: " + perimeter);
        }
    }

    class Square : Shape
    {
        double side;

        public Square(double side)
        {
            this.side = side;
        }

        public override void GetArea()
        {
            double area = this.side * this.side;
            Console.WriteLine("Area of Square is: " + area);
        }

        public override void GetPerimeter()
        {
            double perimeter = 4 * side;
            Console.WriteLine("Perimeter of Square is: " + perimeter);
        }
    }

    abstract class BankAcc
    {
        long accountNumber;
        double balance;

        public BankAcc(long accNo, double balance)
        {
            this.accountNumber = accNo;
            this.balance = balance;
        }

        public void Deposit(double amount)
        {
            this.balance += amount;
        }

        public abstract void Withdraw();
    }

}
