using PROG7312_TASK1.Node;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG7312_TASK1.LinkedList
{
    class DlinkedList
    {
        CNode head;
        CNode current;
        CNode tail;
        CNode temp;
        int nodeCount = 0;
        List<String> nextList;
        List<String> previousList;

        public void append(string data)
        {
            CNode customNode = new CNode(data);

            //check if head is null

            if (head == null)
            {
                head = customNode;
                head.Next = null;
                head.Previous = null;
                nodeCount++;
                return;
            }
            else
            {
                current = head;

                //walk through the list

                while (current.Next != null)
                {
                    current = current.Next;

                }

                current.Next = customNode;
                customNode.Previous = current;
                tail = customNode;
                nodeCount++;
            }
        }

        public List<String> showNext()
        {
            nextList = new List<string>();
            current = head;

            nextList.Add(current.data);


            while (current.Next != null)
            {
                nextList.Add(current.Next.data);
                current = current.Next;
            }

            return nextList;
        }

        public List<string> showPrevious()
        {
            previousList = new List<string>();

            current = tail;

            previousList.Add(current.data);

            while (current.Previous != null)
            {
                previousList.Add(current.Previous.data);
                current = current.Previous;
            }
            return previousList;
        }

        public void insertAfter(string data, int after)
        {
            CNode customNode = new CNode(data);
            current = head;
            int ithNode = 1;

            while (ithNode != after)
            {
                current = current.Next;
                ithNode++;
            }

            temp = current.Next;
            current.Next = customNode;
            customNode.Next = temp;
            temp.Previous = customNode;
            customNode.Previous = current; 
        }
    }
}
