using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using static ProgramTasks.Class1;

namespace ProgramTasks
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public static void CompareTwoNumbers()
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());

            if (x > y)
            {
                Console.WriteLine($"{x} greater than {y}");
            }
            else if (y > x)
            {
                Console.WriteLine($"{y} greater than {x}");
            }
            else
            {
                Console.WriteLine($"{x} equale to {y}");
            }
        }
        public static void CompareOneNumber2()
        {
            int number = Convert.ToInt32(Console.ReadLine());

            if (number > 5 && number < 10)
                Console.WriteLine($"{number} is greater than 5 and less than 10");
            else
                Console.WriteLine("number is out of range");
        }
        public static void GetPercent3()
        {
            int sum = Convert.ToInt32(Console.ReadLine());

            if (sum < 100)
                Console.WriteLine(sum * 0.05 + sum);
            else if (sum > 100 && sum < 200)
                Console.WriteLine(sum * 0.07 + sum);
            else
                Console.WriteLine(sum * 0.10 + sum);
        }
        public static void GetSqrtForEachNumber()
        {
            var numbers = new List<int>();
            numbers.Add(4);
            numbers.Add(9);
            numbers.Add(10);

            var sqrt = from int Number in numbers
                       let Sqrt = Number * Number
                       where Sqrt > 1
                       select new { Number, Sqrt };

            foreach (var n in sqrt)
                Console.WriteLine(n);
        }
        public static void GetNumbersFromStringAndGetMaxNumber()
        {
            var nums = new List<int>();
            string message = "text123contains44numbers232";
            Regex re = new Regex(@"[0-9]+");
            var matches = re.Matches(message).ToArray();

            foreach (Match match in matches)
            {
                Console.WriteLine(match);
                nums.Add(Convert.ToInt32(match.Value));
            }

            Console.WriteLine($"Max number = {nums.Max()}");
        }
        public static void CheckThatAllStrinsContainsSubstring()
        {
            var list = new List<string>();
            list.Add("awdadada11221");
            list.Add("awdadada112211");
            list.Add("awdadada1122111");

            var substring = from s in list
                            where s.Contains("awd")
                            orderby s
                            select s;

            foreach (var t in substring)
            {
                Console.WriteLine(t);
            }
        }
        public static void DeleteWhiteSpace()
        {
            string message = "How to delete whitespace?";
            var chars = message.ToCharArray();
            string empty = string.Empty;

            foreach (var letter in chars)
            {
                if (letter != ' ')
                {
                    empty = empty + letter;
                }
            }
            Console.WriteLine(empty);
        }
        public static void CheckThatPropertiesHaveExpectedValuesAndOrderedByDescending()
        {
            var list = new List<Object1>();
            list.Add(new Object1 { A = "X", B = "Yawda", C = 19 });
            list.Add(new Object1 { A = "X", B = "Yada", C = 24 });
            list.Add(new Object1 { A = "X", B = "Yda", C = 1 });
            list.Add(new Object1 { A = "g", B = "z", C = 9 });

            var selectedList = from l in list
                               where l.A.Equals("X") && l.B.Contains("Y")
                               orderby l.C descending
                               select new { l.A, l.B, l.C };
            foreach (var s in selectedList)
                Console.WriteLine(s);
        }
        public static void PutDuplicateValuesInaListAndPutUniqueValuesInaList4()
        {
            var numbers = new[] { 0, 1, 2, 2, 2, 3, 4, 4, 5 };

            var uniqueNumbers =
                from n in numbers
                group n by n into nGroup
                where nGroup.Count() == 1
                select nGroup.Key;

            foreach (var u in uniqueNumbers)
            {
                Console.WriteLine(u);
            }
            List<int> duplicates = numbers.GroupBy(x => x)
                                                 .Where(g => g.Count() > 1)
                                                 .Select(x => x.Key).ToList();
            Console.WriteLine("Duplicate elements are: " + String.Join(",", duplicates));

            foreach (var d in duplicates)
            {
                Console.WriteLine(d);
            }
        }
        public static void GetPositiveNumbers()
        {
            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(-1);
            numbers.Add(32);
            numbers.Add(-80);

            var positiveNumbers = numbers.Where(x => x > 0).ToList();
            foreach (var number in positiveNumbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
