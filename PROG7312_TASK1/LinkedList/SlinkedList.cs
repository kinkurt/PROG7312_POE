using PROG7312_TASK1.Node;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG7312_TASK1.LinkedList
{
    public class SlinkedList
    {
        static int nodeCount;
        CNode head;
        CNode current;
        List<string> nextList;

        public void append(string data)
        {
            if (head == null)
            {
                head = new CNode(data);
                nodeCount++;
                current = head;

            }

            else
            {
                while (current.Next != null)
                {
                    current = current.Next;
                }

                current.Next = new CNode(data);
                nodeCount++;

            }
        }

        public void prepend(string data)
        {
            CNode newHead = new CNode(data);
            nodeCount++;
            newHead.Next = head;
            head = newHead;
        }


        public int count()
        {
            return nodeCount++;
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
        
    }

}
