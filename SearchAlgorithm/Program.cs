﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgorithm
{
    class Program
    {
        int[] arr = new int[20];
        int n;
        int i;
        
        public void input()
        {
            while (true)
            {
                Console.Write("Enter the number of elements in the array : ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if ((n > 0) && (n <= 20))
                    break;
                else
                    Console.WriteLine("\nArray should have minimun 1 and maximum 20 elements.\n");
            }
            Console.WriteLine("");
            Console.WriteLine("=====================");
            Console.WriteLine(" Enter array elements");
            Console.WriteLine("=====================");
            for (i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                arr[i] = Int32.Parse(s1);
            }
        }

        public void BinarySearch()
        {
            char ch;
            do
            {
                Console.Write("\nEnter element want you to serach : ");
                int item = Convert.ToInt32(Console.ReadLine());

                int lowerbound = 0;
                int upperbound = n - 1;

                int mid = (lowerbound + upperbound) / 2;
                int ctr = 1;

                while ((item != arr[mid]) && (lowerbound <= upperbound))
                {
                    if (item > arr[mid])
                        lowerbound = mid + 1;
                    else
                        upperbound = mid - 1;

                    mid = (lowerbound + upperbound) / 2;
                    ctr++;
                }
                if (item == arr[mid])
                    Console.WriteLine("\n" + item.ToString() + " found at posisition " + (mid + 1).ToString());
                else
                    Console.WriteLine("\n" + item.ToString() + " not found in the array\n");
                Console.WriteLine("\nNumber of comparision : " + ctr);
                Console.Write("\nContinue search (y/n) : ");
                ch = char.Parse(Console.ReadLine());
            }
            while ((ch == 'y') || (ch == 'Y'));
        }
        public void LinearSearch()
        {
            char ch;
            int ctr;
            do
            {
                Console.Write("\nEnter the element you want to search : ");
                int item = Convert.ToInt32(Console.ReadLine());

                ctr = 0;
                for (i = 0; i < n; i++)
                {
                    ctr++;
                    if (arr[i] == item)
                    {
                        Console.WriteLine("\n" + item.ToString() + " found st position " + (i + 1).ToString());
                        break;
                    }
                }
                if (i == n)
                    Console.WriteLine("\n" + item.ToString() + " not found in the array ");
                Console.WriteLine("\nNumber of comparision : " + ctr);
                Console.Write("\nContinue search (y/n) : ");
                ch = char.Parse(Console.ReadLine());
            } while ((ch == 'y') || (ch == 'Y'));
        }
        static void Main(string[] args)
        {
            Program myList = new Program();
            int pilihanmenu;
        }
    }
}
