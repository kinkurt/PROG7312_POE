using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG7312_TASK1
{
    public class GenericUtility<T>
    {

        public bool Compare(T x,T y)
        {
            if (x.Equals(y))
            {
                return true; 
            }
            else
            {
                return false;
            }
        }
    }
}
