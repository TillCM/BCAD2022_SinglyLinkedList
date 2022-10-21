using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedList.Queue
{
    public  class CQueue<T>
    {

        CustomNode<T> Head;
        CustomNode<T> Tail;
        public T data;
       
        public void Enqueue(T data)
        {
            CustomNode<T> newNode = new CustomNode<T>(data);
            if (Tail != null )
            {
                Tail.Next = newNode;
                Tail = newNode;

            }

           
            else
            {
                Head = newNode;
                Tail = Head;
                
            }

        }

        public T peek()
        {
            return Head.data; 
        }

        public void  DeQueue()
        {

        }


    }
}
