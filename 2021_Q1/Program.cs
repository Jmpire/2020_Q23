using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace Exam
{
    class Program
    {
        class List
        {
            List<int> numbers;
            public List(List<int> nNumbers)
            {
                this.numbers = nNumbers;
            }
            // a)
            public List<int> Copy(int start, int end)
            {
                List<int> newList = new List<int>();
                for(int i = start; i < end; i++)
                {
                    newList.Add(numbers[i]);
                }
                return newList;
            }
            //b
            public int Find(int x)
            {
                
                if (numbers.Contains(x))
                {
                    int pos = numbers.IndexOf(x);
                    return pos;
                }
                else
                {
                    throw new Exception("Element was not found");
                }
            }
            // c
            public double Average()
            {
                int count = 0;
                double sum = 0;
                foreach (int number in numbers)
                {
                    sum += number; // sum = sum + total
                    count++;
                }
                return sum / count;
            }
        }
        static bool Exists(Stack<int> numbers, int x)
        {
            bool exists = false;
            // Create back up stack
            Stack<int> aux = new Stack<int>();
            while(numbers.Count != 0)
            {
                int removed = numbers.Pop();
                aux.Push(removed);
                if (removed.Equals(x))
                {
                    exists = true;
                    break;
                    
                }
            }
            // Move numbers back to original stack
            while (aux.Count != 0)
            {
                numbers.Push(aux.Pop());
            }
            return exists;
        }
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            List l = new List(numbers);
        }
    }
}