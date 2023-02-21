using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230221_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Class1> list = new List<Class1>();
            Console.Write("輸入數字串(以逗點分割)");
            string[] arr = Console.ReadLine().Split(',');
            int count = 0;
            foreach (var item in arr)
            {
               list.Add(new Class1() { count = count,data = item});
                count++;
            }
            Console.Write("輸出:");
            var result = list.OrderByDescending(x => x.count);
            foreach (var item in result)
            {
                if (item.count == 0)
                {
                    Console.WriteLine(item.data );
                }
                else
                {
                    Console.Write(item.data + ",");
                }
                

            }

        }
    }
}
