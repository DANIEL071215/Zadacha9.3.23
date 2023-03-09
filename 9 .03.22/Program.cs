using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._03._22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command=Console.ReadLine();
            while (command!="print")
            {
                string[] token = command.Split();
                string action = token[0];

                if (action=="push")
                {
                    int number = int.Parse(token[1]);
                    numbers.Add(number);
                }
                else if (action=="pop")
                {
                    if (numbers.Count>0)
                    {
                        int number = numbers[numbers.Count - 1];
                            numbers.RemoveAt(numbers.Count-1);
                        Console.WriteLine(number);
                    }
                }
                else if (action=="shift")
                {
                    if (numbers.Count>0)
                    {
                        int number = numbers[numbers.Count - 1];
                        numbers.RemoveAt(numbers.Count-1);

                    }
                }
                else if (action=="addMany")
                {
                    int index = int.Parse(token[1]);




                }
                else if (action=="remove")
                {
                    int index = int.Parse(token[1]);
                    if (index>=0 && index<numbers.Count)
                    {
                        numbers.RemoveAt(index);
                    }
                }
                command = Console.ReadLine();
            }



        }
    }
}
