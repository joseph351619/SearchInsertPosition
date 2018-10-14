using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchInsertPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Key-in an Array Length:");
            //int number = 0;
            //int length = int.Parse(Console.ReadLine());
            //List<int> numbers = new List<int>();
            //Console.WriteLine("Key-in an Array:");
            //int i = 0;
            //while (i<length)
            //{
            //    i++;
            //    number = int.Parse(Console.ReadLine());
            //    numbers.Add(number);
            //}
            int[] numbers = new int[] { 1,3,5,6 };
            while (true)
            {
                Console.WriteLine("Key-in the target:");
                int target = int.Parse(Console.ReadLine());
                Console.WriteLine($"Answer : {SearchInsert(numbers.ToArray(), target)}");
            }
            Console.ReadLine();
        }

        static int SearchInsert(int[] nums, int target)
        {
            int end = nums.Length ;
            int begin = -1;
            int answer = 0;
            while (true)
            {
                answer = (begin + end) / 2;
                if (nums[answer] == target)
                {
                    return answer;
                }
                else if (nums[answer] > target)
                {
                    end = answer;
                }
                else
                {
                    begin = (begin + end) / 2;
                }
                if(begin > end)
                {
                    answer = begin;
                    break;
                }
                if (begin == end || end - begin == 1)
                {
                    answer = end;
                    break;
                }
            }
            return answer;
        }
    }
}
