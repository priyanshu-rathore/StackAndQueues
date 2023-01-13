using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueues
{
    internal class node<T>
    {
        public T data { get; set; }
        public node<T> next { get; set; }

        public node(T data)
        {
            this.data = data;
            this.next = null;
        }
    }
}
