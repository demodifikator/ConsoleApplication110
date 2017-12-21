using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Program
    {
        struct Human
        {
            public string Name;
            public int Age;

            public string GetAge()
            {
                return Age.ToString();
            }
        }

        static public int GetAge(params int[] array)
        {
            //if (list.Count < 16)
            //    return 0;

            //list = new List<int>()
            //{

            //};

            //return 15;
        }


        static void Main(string[] args)
        {
            //Human human = new Human();
            //human.Age = 15;
            //string age = human.GetAge();
            //Console.WriteLine(age);

            //List<int> array = new List<int>
            //{
            //    2,4,6
            //};

            //int x = 14;
            //GetAge(ref x);

            //Console.WriteLine(x);

            //List<int> h = GetAge(ref array);

            GetAge(2, 3, 4, 5, 6, 7, 8, 9, 0, 1);
        }
    }
}
