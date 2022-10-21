using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedList
{
    public class CustomNode<T>
    {
        public CustomNode<T> Next;
        public T data;

        public CustomNode()
        {
            //good practice
        }

        public CustomNode(T data)
        {
            this.data = data;
        }

        


    }
}
