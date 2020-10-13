using PROG7312_TASK1.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROG7312_TASK1
{
    
    static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*SlinkedList singleList = new SlinkedList();
            DlinkedList dlinkedList = new DlinkedList();
            int countedNodes = 0;
            List<string> nodeValues;
            List<string> doubleLinkedPreviousValues;*/

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenu());

            


            /*singleList.append("first value slist");

            dlinkedList.append("first value dlist");
            dlinkedList.insertAfter("insert after",2);

            nodeValues = singleList.showNext();

            foreach (var item in nodeValues)
            {
                MessageBox.Show(item);

            }


            doubleLinkedPreviousValues = dlinkedList.showPrevious();

            foreach (var item in doubleLinkedPreviousValues)
            {
                MessageBox.Show(item);
            }*/
        }
    }
}
