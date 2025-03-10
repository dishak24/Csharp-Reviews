using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review5
{
    internal class StackOperations
    {
        private int[] stack;
        private int size;
        private int top;

        public StackOperations( int size)
        {
            this.size = size;
            stack = new int[size];
            top = -1;
        }
                     
                
        public void Push( int ele)
        {
            if ( top == size-1)
            {
                Console.WriteLine("Stack Overflow ! ");
                return;
            }

            stack[++top] = ele;
            Console.WriteLine($"{ ele } Element pushed on to stack.");
        }

        public int Pop()
        {
            if ( top == -1)
            {
                Console.WriteLine("Stack Underflow !");
                return -1;
            }

            return stack[top--];

        }

        public int Peek()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is Empty !");
                return -1;
            }
            return stack[top];
        }

        public void DisplayStack()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is Empty !");
                return;
            }

            for (int i = 0; i <= top; i++)
            {
                Console.Write(stack[i] + " ");
            }

            Console.WriteLine("\n");
        }


        public static void PerformAllStackOperation()
        {
            StackOperations stack = new StackOperations(5);
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);

            stack.DisplayStack();

            stack.Push(5);
            Console.WriteLine($"{stack.Pop()} Popped !");
            Console.WriteLine($"{stack.Peek()} is Top most element.");
            Console.WriteLine($"{stack.Pop()} Popped !");
            Console.WriteLine($"{stack.Peek()} is Top most element.");

            stack.DisplayStack();
        }

    }
}
