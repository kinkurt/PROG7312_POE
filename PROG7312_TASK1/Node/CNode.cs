using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG7312_TASK1.Node
{
    public class CNode
    {
        public CNode Next;
        public CNode Previous;
        public string data;

        public CNode()
        {
            //default construcotr
        }

        public CNode(string data)
        {
            this.data = data;
        }
    }
}
