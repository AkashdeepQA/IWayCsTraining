using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;
using System.Threading;

namespace IWayCsTraining
{
    class Program
    {
        const double pi = 3.14;
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, World!!");
            #region
            //Variables:
            //int num = 100;
            //Console.WriteLine("The value of num variable is: " + num);

            //Declare multiple variables of same type
            //int x = 5;
            //int y = 10;
            //int z = 15;

            //int x = 5, y = 10, z = 15;
            //int a, b, c;
            //a = b = c = 100;

            //num = 150;
            //Console.WriteLine("The value of num variable is: " + num);

            //Data Types:
            //int intVar = 100;
            //long longVar = 3123456789;
            //float floatVar = 100.123456F;
            //double doubleVar = 100.1234567890123;
            //bool boolVar = true;
            //char charVar = 'a';

            //Console.WriteLine(intVar);
            //Console.WriteLine(longVar);
            //Console.WriteLine(floatVar);
            //Console.WriteLine(doubleVar);
            //Console.WriteLine(boolVar);
            //Console.WriteLine(charVar);

            //Type Conversion:
            //long var1 = (long)floatVar;
            //int var2 = charVar;
            //Console.WriteLine(var1);
            //Console.WriteLine(var2);

            //bool var3 = Convert.ToBoolean(0);
            //Console.WriteLine(var3);
            //int a = 5;
            //int b = 10;
            //Console.WriteLine(a + b);
            //Console.WriteLine(a - b);
            //Console.WriteLine(a * b);
            //Console.WriteLine(b / a);
            //Console.WriteLine(a%b);
            //Console.WriteLine(++a);
            //Console.WriteLine(--b);

            //Console.WriteLine(a == b);
            //Console.WriteLine(a > b);
            //Console.WriteLine(a >= b);
            //Console.WriteLine(a < b);
            //Console.WriteLine(a <= b);
            //Console.WriteLine(a != b);

            //Conditional statements:
            //Console.Write("Please enter your age: ");
            //int age = int.Parse(Console.ReadLine());
            //if(age < 10)
            //{
            //    Console.WriteLine("You are a Toddler");
            //}
            //else if(age < 18)
            //{
            //    Console.WriteLine("You are a Kid");
            //}
            //else if(age < 60)
            //{
            //    Console.WriteLine("You are a Adult");
            //}
            //else
            //{
            //    Console.WriteLine("You are a Senior Citizen");
            //}

            //Console.Write("Please enter a number from 1 to 7: ");
            //int dayOfWeek = int.Parse(Console.ReadLine());

            //switch (dayOfWeek)
            //{
            //    case 1:
            //        Console.WriteLine("The day you chose is Monday");
            //        break;
            //    case 2:
            //        Console.WriteLine("The day you chose is Tuesday");
            //        break;
            //    case 3:
            //        Console.WriteLine("The day you chose is Wednesday");
            //        break;
            //    case 4:
            //        Console.WriteLine("The day you chose is Thursday");
            //        break;
            //    case 5:
            //        Console.WriteLine("The day you chose is Friday");
            //        break;
            //    case 6:
            //        Console.WriteLine("The day you chose is Saturday");
            //        break;
            //    case 7:
            //        Console.WriteLine("The day you chose is Sunday");
            //        break;
            //    default:
            //        Console.WriteLine("You have not entered a valid number");
            //        break;
            //}

            //Console.Write("Please enter your age: ");
            //int age = int.Parse(Console.ReadLine());

            //if (age < 18)
            //    Console.WriteLine("You are a child");
            //else
            //    Console.WriteLine("You are an adult");

            //string result = age < 18 ? "You are a child" : "You are an adult";
            //Console.WriteLine(result);

            //Console.Write("Please enter a number between 1 to 50: ");
            //int num = int.Parse(Console.ReadLine());

            //Console.WriteLine("While loop output:");
            ////num = 5
            //int i = 1;
            //while(i <= num)
            //{
            //    Console.Write(i + " ");
            //    i++;
            //}

            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("Do...While loop output:");
            //i = 1;
            //do
            //{
            //    Console.Write(i + " ");
            //    i++;
            //} while (i <= num);

            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("for loop output:");

            //for(i = 1; i <= num; i++)
            //{
            //    Console.Write(i + " ");
            //}

            //Console.Write("Please enter a number between 1 to 100: ");
            //int num = int.Parse(Console.ReadLine());

            //int i;
            //for(i = 2; i < num; i++)
            //{
            //    if(num % i == 0)
            //    {
            //        Console.WriteLine("The number you entered is not a Prime number");
            //        break;
            //    }
            //}
            //if(i == num)
            //{
            //    Console.WriteLine("You have entered a prime number");
            //}


            //Console.Write("Please enter a number between 1 to 100: ");
            //int num = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= num; i++)
            //{
            //    Console.WriteLine(i + " % " + "5 = " + i % 5 + " ");
            //    if (i % 5 == 0)
            //    {

            //        break;
            //    }
            //    Console.WriteLine(i + " ");
            //}

            //Console.WriteLine("Prime Number: loop output:");


            //int[] arrNum = new int[5]; //[0,0,0,0,0,0,0,0,0,0,0,0]
            //int[] arrNum1 = new int[5] { 10, 20, 30, 40, 50};
            //int[] arrNum2 = new int[] { 10, 20, 30, 40, 50 };
            //int[] arrNum = { 10, 20, 30, 40, 50 };

            //arrNum[0] = 10;
            //arrNum[1] = 20;
            //arrNum[2] = 30;
            //arrNum[3] = 40;
            //arrNum[4] = 50;
            //Console.WriteLine("1st element of array is: " + arrNum[0]);
            //Console.WriteLine("4th element of array is: " + arrNum[3]);
            ////Console.WriteLine("6th element of array is: " + arrNum[5]);

            //Console.WriteLine("3rd element of array before change is: " + arrNum[2]);
            //arrNum[2] = 300;
            //Console.WriteLine("3rd element of array after change is: " + arrNum[2]);

            ////arrNum[5] = 500;
            ////Console.WriteLine("6th element of array after adding is: " + arrNum[5]);

            //Console.WriteLine("The length of this array is: " + arrNum.Length);


            //Array.Resize(ref arrNum, 7);
            //Console.WriteLine("The length of this array is: " + arrNum.Length);

            //int[] random = { 7, 3, 4, 1, 9, 2, 8 };
            //Console.WriteLine("Array before sorting: ");
            //for (int i = 0; i < random.Length; i++)
            //{
            //    Console.Write(random[i] + "    ");
            //}

            //Array.Sort(random);

            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("Array after sorting: ");
            //for (int i = 0; i < random.Length; i++)
            //{
            //    Console.Write(random[i] + "    ");
            //}

            //Console.WriteLine();
            //Console.WriteLine();
            //int[] decArr = random.Reverse().ToArray();
            //for (int i = 0; i < decArr.Length; i++)
            //{
            //    Console.Write(decArr[i] + "    ");
            //}


            //Console.WriteLine("Using foreach loop");
            //foreach(int ele in decArr)
            //{
            //    Console.Write(ele + "    ");
            //}


            ////int[,] arr2d = new int[5,4];
            //int[,] arr2d = { { 1, 4, 2 }, { 3, 6, 8 }, { 10, 20, 30 } };

            //Console.WriteLine(arr2d.Length);

            //foreach(int ele in arr2d)
            //{
            //    Console.Write(ele + "    ");
            //}

            //FirstFunc();

            //Console.Write("Enter 1st number: ");
            //int first = int.Parse(Console.ReadLine());
            //Console.Write("Enter 2nd number: ");
            //int second = int.Parse(Console.ReadLine());

            //int total = Sum(first, second);
            //Console.WriteLine("The total is: " + total);

            //PrintName(lastname: "Akash", fname: "Deep", mname: "Srivatava");

            //Console.WriteLine("Sum of two ints: " + Sum(10, 20));

            //Console.WriteLine("Sum of two doubles: " + Sum(10.5, 20.3));

            //Console.WriteLine("Sum of two strings: " + Sum("Akash", "deep"));

            //Console.WriteLine("Area of rectangle with length = 20.5 nd width = 10 is = " + Area(20.5, 10));

            //Console.WriteLine("Area of circle with radius = 20.5 is = " + Area(20.5));


            /*
            Car baleno = new Car("Blue", "HatchBack", 220, 4); //creating object of the class - Car
            Console.WriteLine("Baleno's color is: " + baleno.color);
            Console.WriteLine("Baleno's model type is: " + baleno.model);
            Console.WriteLine("Baleno's number of doors is: " + baleno.numberOfDoors);
            Console.WriteLine("Baleno's top speed is: " + baleno.topSpeed);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Car scorpio = new Car("Red", "SUV", 330, 5);
            Console.WriteLine("Scorpio's color is: " + scorpio.color);
            Console.WriteLine("Scorpio's model type is: " + scorpio.model);
            Console.WriteLine("Scorpio's number of doors is: " + scorpio.numberOfDoors);
            Console.WriteLine("Scorpio's top speed is: " + scorpio.topSpeed);
            */

            /*
            BankAccount acc1 = new BankAccount("Akashdeep Srivastava", 134679);
            acc1.Deposit(55000);
            Console.WriteLine($"Balance after first deposit is Rs. {acc1.CheckBalance()}");

            acc1.Withdrawal(55001);
            acc1.Withdrawal(5000);

            Console.WriteLine("Balance is: " + acc1.Balance);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Vehicle v1 = new Vehicle("Hero", "Ranger", "Black");
            v1.Start();
            v1.Stop();


            Car c1 = new Car("Maruti Suzuki", "Baleno", "Blue", 4, "Automatic");
            c1.Start(); //base class method
            c1.VideoRecording(); //derived class method
            c1.Stop(); // bse class method
            */

            /*
            Employee emp1 = new Employee();
            Console.WriteLine("Emp1 deails:");
            emp1.PrintDetails();

            Employee emp2 = new Employee("Ankit", "Senior Software Engineer");
            Console.WriteLine("Emp2 deails:");
            emp2.PrintDetails();

            Employee emp3 = new Employee("Ariba", "Lead Engineer", 100000);
            Console.WriteLine("Emp3 deails:");
            emp3.PrintDetails();
            

            Employee emp1 = new Employee("Akashdeep", "Intern", 10000);
            emp1.CalculateSalary();

            RegularEmployee reg1 = new RegularEmployee("Yash", "Associate", 15000, 5000);
            reg1.CalculateSalary();

            Manager mgr1 = new Manager("Swale", "Senir Manager", 75000, 35000);
            mgr1.CalculateSalary();

            SalesPerson sp1 = new SalesPerson("Ankit", "Sr. Sales Executive", 30000, 7000, 10000);
            sp1.CalculateSalary();
            

            Circle c1 = new Circle(100);
            c1.GetArea();
            c1.GetPerimeter();

            Square sq1 = new Square(100);
            sq1.GetArea();
            sq1.GetPerimeter();
            */


            /*
            try
            {
                Console.WriteLine("Enter the first number: ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the second number : ");
                int b = int.Parse(Console.ReadLine());
                double res = a / b; // Divide by zero
                Console.WriteLine("Division result is: " + res);

                Console.WriteLine("Enter the index that you want to access: ");
                int c = int.Parse(Console.ReadLine());
                int[] arr = { 1, 2, 3, 4, 5 };
                int element = arr[c]; //Array out of bound
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("An error occured: " + e.Message);
                Console.WriteLine("Please enter a valid number next time.");
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine("An error occured: " + e.Message);
                Console.WriteLine("Please enter a valid array index next time.");
            }
            finally
            {
                Console.WriteLine("Thank you for using our app");
            }
            
            try
            {
                Console.WriteLine("Enter your age: ");
                int age = int.Parse(Console.ReadLine());

                if (age < 18)
                {
                    throw new Exception("Access Denied!!! You are not eligible to use our app.");
                }
                else
                {
                    Console.WriteLine("Welcome user!!");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Please visit us when you are 18 years old or above.");
            }
            

            GenClass<int, string> obj1 = new GenClass<int, string>();
            obj1.prop1 = 100;
            obj1.prop2 = "TempString";
            Console.WriteLine(obj1.prop1);
            Console.WriteLine(obj1.prop2);
            obj1.PrintMessage(123, "StringParam");

            GenClass<string, double> obj2 = new GenClass<string, double>();
            obj2.prop1 = "StringValue";
            obj2.prop2 = 100.456;
            Console.WriteLine(obj2.prop1);
            Console.WriteLine(obj2.prop2);
            obj2.PrintMessage("StringParam", 456.123);
            

            ArrayList arrlist1 = new ArrayList();
            arrlist1.Add(10); //0
            arrlist1.Add("Akash"); //1
            arrlist1.Add(10.123); //2
            arrlist1.Add(true); //3

            ArrayList arrlist2 = new ArrayList() { 10, "Akash", 10.123, true };

            Console.WriteLine(arrlist1[1]);
            Console.WriteLine(arrlist1[3]);

            arrlist1.Insert(2, "Swale");
            Console.WriteLine(arrlist1[2]);
            Console.WriteLine(arrlist1[3]);
            //10, Akash, Swle, 10.123, true

            arrlist1.RemoveRange(1, 2);
            Console.WriteLine(arrlist1[1]);

            Console.WriteLine(arrlist1.Contains(10.123)); //true
            Console.WriteLine(arrlist1.Contains("Akash")); //false

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            for(int i = 0; i < arrlist2.Count; i++)
            {
                Console.WriteLine(arrlist2[i]);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            foreach (var element in arrlist2)
            {
                Console.WriteLine(element);
            }
            */
            #endregion

            //Collections.HashTableAndDictionary();

            //Collections.Stacks();

            //Collections.Queues();

            //int[] nums = { 11, 22, 33, 11, 33, 33, 22, 44, 55, 11, 66, 33, 77, 88 };
            //Collections.HighestFrequencyElement(nums);


            string filePathWithName = @"D:\TrainingFiles\firstFile.txt";
            //FileHandling.CreateFile(filePathWithName);

            string content = "Hi There,\nWe are Studying C#.\nAnkit, Swale and Ariba are in the class today.\nAkashdeep is teaching";
            FileHandling.WriteToFile(filePathWithName, content);
            FileHandling.AppendToFile(filePathWithName, "\nShivam is absent today");
            FileHandling.AppendToFile(filePathWithName, "\nShiva is absent today");
            FileHandling.AppendToFile(filePathWithName, "\nYash is absent today");

            Console.WriteLine(FileHandling.ReadFromFile(filePathWithName));



            Console.ReadKey();
        }

        static double Division(int a, int b)
        {
            double result = 0;
            try
            {
                result = a / b;
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occured: " + e.Message);
                Console.WriteLine("Please enter a valid number next time.");
            }

            return result;
        }

        static void FirstFunc()
        {
            Console.WriteLine("This is my first function!!!");
        }

        static int Sum(int a, int b)
        {
            int sum = a + b;
            return sum;
        }

        static double Sum(double a, double b)
        {
            return a + b;
        }

        static string Sum(string a, string b)
        {
            return a + b;
        }

        static void PrintName(string fname, string mname, string lastname)
        {
            Console.WriteLine(fname + " " + mname + " " + lastname);
        }

        static double Area(double radius)
        {
            return pi * radius * radius;
        }

        static double Area(double length, double width)
        {
            return length * width;
        }
    }
}
