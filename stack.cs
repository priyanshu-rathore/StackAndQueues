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

        public void push(T value)
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
