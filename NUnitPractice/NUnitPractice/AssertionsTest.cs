using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace AssertionsTest
{
    public class Task
    {
        public static void Main()
        {
            CompareTwoStrings();
        }

        public static void CheckIfStringContainsInList()
        {
            var names = new List<string> { "Artem", "Sasha", "Masha" };
            string myName = "Artem";
            foreach (var name in names)
            {
                Console.WriteLine($"hello { name.ToUpper()}");
            }

            Assert.Contains(myName, names);
        }
        public static void CompareTwoLists()
        {
            IList<string> myList1 = new List<string> { "a", "b", "c" };
            IList<string> myList2 = new List<string> { "a", "b", "c" };
            {
                Console.WriteLine($"First list {myList1} is equale to second {myList2}");
            }

            Assert.AreEqual(myList1, myList2);
        }
        public static void CompareAandB()
        {
            int a = 10;
            int b = 5;
            {
                Console.WriteLine($"True");
            }

            Assert.IsTrue(a > b);
        }
        public static void CompareTwoStrings()
        {
            string first = "abc";
            string second = "abc";
            {
                Console.WriteLine($"True");
            }

            Assert.IsTrue(first == second);
        }
    }
}