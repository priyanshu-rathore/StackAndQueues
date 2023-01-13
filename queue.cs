using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueues
{
    internal class queue<T>
    {
        node<T> head;

        public void enqueue(T value)//UC3
            {

            node<T> Node = new node<T>(value);

            if (this.head == null)
            {
                head= Node;
            }
            else
            {
                node<T> temp = head;
                while(temp.next!= null)
                {
                    temp = temp.next;
                }
                temp.next = Node;

            }
        }

        public void dequeue()//UC4
        {
            if (head == null)
            {
                Console.WriteLine("queue is empty");
            }
            else
            {
                Console.WriteLine(head.data + " is dequeued");
                head = head.next;
            }
        }
        public void display()
        {
            node<T> temp = head;

            if (temp == null)
            {
                Console.WriteLine("Stack is empty");
            }
            else
            {
                while (temp != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
            }
        }
    }
}
