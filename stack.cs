using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueues
{
    internal class stack<T>
    {
        node<T> top;

        public void push(T value)//UC1
        {
            node<T> current = new node<T>(value);

            if(top== null)
            {
                current.next = null;
            }
            else
            {
                current.next = top;
            }

            top = current;
            Console.WriteLine(top.data+" is added to the stack");
        }

        public void peek()//UC2
        {
            if (top == null)
            {
                Console.WriteLine("Stack is empty");
            }
            else
            {
                Console.WriteLine(top.data);
            }
        }

        public void pop()//UC2
        {
            node<T> current = top;
            if (top == null)
            {
                Console.WriteLine("Stack is empty nothing to delete");
            }
            else
            {
                Console.WriteLine(current.data+" is popped");

                current = current.next;
            }
            top =current;
        }

        public void display() {
            node<T> temp = top;

            if(temp == null) {
                Console.WriteLine("Stack is empty");
            }
            else
            {
                while(temp!=null)
                {
                    Console.Write(temp.data + " ");
                    temp= temp.next;
                }
            }
        }
    }
}
