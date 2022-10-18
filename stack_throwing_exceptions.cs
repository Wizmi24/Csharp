using System;
using System.Collections;

namespace Cwiczenie_27._1
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(null);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            stack.Push(3);

            stack.Clear();
            stack.Push(1);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
        }
    }

    public class Stack
    {
        private ArrayList stackList = new ArrayList();

        public void Push(object obj)
        {
            if (obj != null)
            {
                stackList.Add(obj);
            }
            else Console.WriteLine("You cannnot add empty object.");
        }

        public object Pop()
        {
            if (stackList.Count != 0)
            {
                object last = stackList[stackList.Count - 1];
                stackList.RemoveAt(stackList.Count - 1);
                return last;

            }
            else throw new InvalidCastException("There are no objects in the list");
        }

        public void Clear()
        {
            stackList.Clear();
        }

    }
}
