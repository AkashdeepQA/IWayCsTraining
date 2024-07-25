using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWayCsTraining
{
    class Collections
    {
        static public void ListFunc()
        {
            List<int> intList = new List<int>();
            intList.Add(10); //0
            intList.Add(20); //1
            //2nd Index - 100
            intList.Add(30); //3
            intList.Add(40); //4

            //Console.WriteLine("Element at index 2 is: " + intList[2]);
            foreach (int element in intList)
            {
                Console.WriteLine(element);
            }

            //intList.Insert(2, 100);
            int[] arr = { 1, 2, 3 };
            intList.InsertRange(2, arr);
            Console.WriteLine("After insertion:");
            foreach (int element in intList)
            {
                Console.WriteLine(element);
            }

            List<string> strList = new List<string>();
            strList.Add("Akash");
            strList.Add("Yash");
            strList.Add("Swale");
            strList.Add("Ariba");
            //Console.WriteLine("Element at index 2 is: " + strList[2]);

            foreach (string element in strList)
            {
                Console.WriteLine(element);
            }

            //strList.Insert(2, "Shivam");
            string[] arrStr = { "Sunday", "Monday", "Tuesday" };
            strList.InsertRange(2, arrStr);
            Console.WriteLine("After insertion:");
            foreach (string element in strList)
            {
                Console.WriteLine(element);
            }

            strList.Remove("Akash");
            strList.Remove("Swale");

            Console.WriteLine("After removal:");
            foreach (string element in strList)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine(strList.Contains("Akash"));
        }

        static public void HashTableAndDictionary()
        {
            Hashtable hasht = new Hashtable()
            {
                { 1, "One" },
                { 2, "Two" },
                {3, "Three" },
                {4, "Four" }
            };
            //Console.WriteLine("The value of key 3 is: " + hasht[3]);
            hasht[3] = "III";

            foreach (DictionaryEntry de in hasht)
            {
                Console.WriteLine($"Key is {de.Key} & value is {de.Value}");
            }


            Dictionary<string, int> dict = new Dictionary<string, int>()
            {
                { "Kiwi", 8},
                {"Guava", 10 }
            };
            dict.Add("Apples", 5);
            dict.Add("Oranges", 7);
            dict.Add("Banana", 5);
            //Console.WriteLine("The value of key Kiwi is: " + dict["Kiwi"]);
            dict["Apples"] = 15;
            foreach (KeyValuePair<string, int> kvp in dict)
            {
                Console.WriteLine($"Key is {kvp.Key} & value is {kvp.Value}");
            }

            Console.WriteLine("=====Sorted List======");

            SortedList<string, int> sl = new SortedList<string, int>()
            {
                { "Kiwi", 8},
                {"Guava", 10 }
            };
            sl.Add("Apples", 5);
            sl.Add("Oranges", 7);
            foreach (KeyValuePair<string, int> kvp in sl)
            {
                Console.WriteLine($"Key is {kvp.Key} & value is {kvp.Value}");
            }
        }

        public static void TwoSum(int[] arr)
        {

            //[2, 7, 11, 15]
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (dict.ContainsKey(arr[i]))
                {
                    Console.WriteLine($"The sum of values at indices {dict[arr[i]]} and {i} is 9");

                }
                else
                {
                    dict.Add(9 - arr[i], i);
                }
            }
        }

        public static void Stacks()
        {
            Stack s1 = new Stack(); //non-generic inplementation of stack

            string[] arrCities = { "Prayagraj", "Bengaluru", "Ahmedabad", "Lucknow" };

            Stack<string> cities = new Stack<string>(arrCities);//generic inplementation of stack

            foreach (string element in cities)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("\nPeeking the last element of Stack: ");
            Console.WriteLine(cities.Peek());

            cities.Push("Panaji");
            cities.Push("Noida");

            Console.WriteLine("\nStack after doing two more pushes: ");
            foreach (string element in cities)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("\nPeeking the last element of Stack: ");
            Console.WriteLine(cities.Peek());

            string pop1 = cities.Pop(); //popeed one value
            Console.WriteLine("\nPopped Value: " + pop1); //print

            Console.WriteLine("\nStack after doing one pop: ");
            foreach (string element in cities)
            {
                Console.WriteLine(element);
            }

            string pop2 = cities.Pop();
            Console.WriteLine("\nPopped Value: " + pop2); //popped second value
            Console.WriteLine("\nStack after doing one pop: ");//print
            foreach (string element in cities)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("\nLucknow exists in the Stack?: " + cities.Contains("Lucknow"));

            Console.WriteLine("\nNoida exists in the Stack?: " + cities.Contains("Noida"));

            cities.Clear();

            Console.WriteLine("\n No. of elements in the stack: " + cities.Count);
            foreach (string element in cities)
            {
                Console.WriteLine(element);
            }

            //cities.Push("Prayagraj");
            //cities.Push("Bengaluru");
            //cities.Push("Ahmedabad");
            //cities.Push("Lucknow");
        }

        public static void Queues()
        {
            Queue q1 = new Queue();//non-generic

            string[] carsArr = { "Scorpio", "Alcazar", "Ford", "Audi" };
            Queue<string> carsQ = new Queue<string>(carsArr);//generic
            carsQ.Enqueue("Baleno");
            carsQ.Enqueue("Fortuner");
            carsQ.Enqueue("Aura");
            carsQ.Enqueue("XUV");

            Console.WriteLine("\nInitial Queue");
            foreach (string element in carsQ)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("\nPeeking the first element: " + carsQ.Peek());

            string dequeue1 = carsQ.Dequeue();
            Console.WriteLine("\nDequeued element: " + dequeue1);
            Console.WriteLine("\nQueue after dequeue:");
            foreach (string element in carsQ)
            {
                Console.WriteLine(element);
            }

            string dequeue2 = carsQ.Dequeue();
            Console.WriteLine("\nDequeued element: " + dequeue2);
            Console.WriteLine("\nQueue after dequeue:");
            foreach (string element in carsQ)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("\nAlcazar exists in the Queue?: " + carsQ.Contains("Alcazar"));

            Console.WriteLine("\nBeleno exists in the Queue?: " + carsQ.Contains("Baleno"));

            carsQ.Clear();
            Console.WriteLine("\n No. of elements in the queue: " + carsQ.Count);
            foreach (string element in carsQ)
            {
                Console.WriteLine(element);
            }
        }

        public static void HighestFrequencyElement(int[] nums)
        {

            Dictionary<int, int> dict = new Dictionary<int, int>();
            int result = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                //num[i] = 10
                if (dict.ContainsKey(nums[i]))
                {
                    //dict[10]++;
                    dict[nums[i]]++;
                }
                else
                {
                    dict.Add(nums[i], 1);
                }
            }
            
            int maxFreq = 0;
            foreach (KeyValuePair<int, int> kvp in dict)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
                if (kvp.Value > maxFreq)
                {

                    maxFreq = kvp.Value;
                    result = kvp.Key;
                }
            }
            Console.WriteLine($"Element {result} has max frequency of {maxFreq}");
        }
    }
}
