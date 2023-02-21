using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230221_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("輸入數字串(以逗點分割):");
            string[] arr = Console.ReadLine().Split(',');
            var even = arr.Where(x=>Convert.ToDouble(x)%2 == 0).OrderBy(x=> Convert.ToDouble(x));
            var odd = arr.Where(x => Convert.ToDouble(x) % 2 != 0).OrderBy(x => Convert.ToDouble(x));

            int count = 0;
            int count1 = 0;
            Console.Write("奇數:");
            foreach (var x in odd)
            {
                if (count1 < odd.Count() - 1)
                {
                    Console.Write(x + ",");
                    count1++;
                }
                else
                {
                    Console.WriteLine(x);
                }
            }



            Console.Write("偶數:");
            foreach(var x in even)
            {
                if(count< even.Count()-1)
                {
                    Console.Write(x+",");
                    count++;
                }
                else
                {
                    Console.WriteLine(x);
                }
            }






        }
    }
}
