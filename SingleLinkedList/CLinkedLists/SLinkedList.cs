using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedList
{
   public class SLinkedList<T>
    {
       CustomNode<T> head;
        CustomNode<T> current;
        public T data;
        int nodeCount;
        List<T> nextlist;

        public void appendNode(T data)
        {
            // if the list is empty make a node call it head
            if(head == null)
            {
                head = new CustomNode<T>(data);
                nodeCount++;
                return;
            }

            current = head;

            while (current.Next!=null)
            {
                    current = current.Next;   
            }

            current.Next = new CustomNode<T>(data);

        }

        public void prepend(T data)
        {
            if (head == null)
            {
                head=new CustomNode<T>(data);
                nodeCount++;
            }

            else
            {
                CustomNode<T> newHead = new CustomNode<T>(data);
                nodeCount++;
                newHead.Next = head;
                head = newHead;

            }


        }

        public void deteleWithData(T data)
        {
            //Check if the list exists 
            if (head==null)
            {
                MessageBox.Show("Cannot delete a value from an empty list");
                return;
            }

            //2 what if the head contains the data we need to delete

            if (head.data.Equals(data))
            {
                head = head.Next;
            }

            // if the node we want to delete is not the head, we need to walk the list
            
            //set the head to current walk the list
            current=head;

            while (current.Next!=null)
            {
                if (current.data.Equals(data))
                {
                    current.Next = current.Next.Next;
                    MessageBox.Show("Node with data" + data + " delted");
                }

                current = current.Next;
            }

            MessageBox.Show("Could not delete data , data not present in list");
            //if the data does not match- check the next element
           
        }

        //public void applyProfanityFilter(T data)
        //{

        //    if (head == null)
        //    {
        //        MessageBox.Show("No list to clean ");
        //        return;
        //    }



            //if (head.data.Contains(data))
            //{
            //    string replaceString = head.data.Replace(data, "*****");
            //    head.data = replaceString;
            //    MessageBox.Show(head.data);


            //}

        //    current = head;

        //    while (current.Next != null)
        //    {
        //        current = current.Next;
        //        if (current.data.Contains(data))
        //        {
        //            string replaceString = current.data.Replace(data, "*****");
        //            current.data = replaceString;
        //            MessageBox.Show(current.data);

        //        }
        //    }

        //    MessageBox.Show("No swearwords in here !");

        //}

        public void insertAfter(T nodeData, T searchData)
        {
            if (head == null)
            {
                MessageBox.Show("There is no linst you nana");
            }

            if (head.data.Equals(searchData))
            {
                CustomNode<T> insertNode = new CustomNode<T>(nodeData);
                insertNode.Next = head.Next;
                head.Next = insertNode;


            }

            current = head;

            while (current.Next != null)
            {
                current = current.Next;

                if (current.data.Equals(searchData))
                {
                    CustomNode<T> insertNode = new CustomNode<T>(nodeData);
                    insertNode.Next = current.Next;
                    current.Next = insertNode;


                }


            }


        }

        public List<T> showNext()
        {
            nextlist = new List<T>();
            current = head;

            nextlist.Add(current.data);

            while (current.Next != null)
            {

                nextlist.Add(current.Next.data);
                current = current.Next;

            }



            return nextlist;

        }


    }

    

}
