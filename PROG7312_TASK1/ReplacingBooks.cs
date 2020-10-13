using PROG7312_TASK1.LinkedList;
using PROG7312_TASK1.Node;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROG7312_TASK1
{
    public partial class ReplacingBooks : Form
    {
        public ReplacingBooks()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtbUser.Text))
            {
                MessageBox.Show("Please fill in username");
                return;
            }


            lboxDisplay.Items.Clear();
            
            int randomFirst, randomSecond;
            var chars = "ABCDEFGHIJKLMNOPQRSTUVQXYZ";
            var letter = new char[3];
            

            Random random = new Random();
            

            for (int i = 0; i < 10; i++)
            {
                string zero = "", zero2 = "";
                randomFirst = random.Next(0,999);
                randomSecond = random.Next(0,99);
                //does a check so that there isnt a blank space for the call number
                if (randomFirst < 10)
                {
                    zero = "00";
                }
                else if (randomFirst < 100)
                {
                    zero = "0";
                }

                if (randomSecond < 10)
                {
                    zero2 = "0";
                }


                //https://stackoverflow.com/questions/1344221/how-can-i-generate-random-alphanumeric-strings
                //Author: Dan Rigby
                //The randomisation of letters

                for (int num = 0; num < letter.Length; num++)
                {
                    letter[num] = chars[random.Next(chars.Length)];
                }
                var finalLetters = new string(letter);

                //creates random dewy decimal number by adding all the elements together
                //the letters are supposed to be author surnames but its the same as 3 random letters in my opinion.
                var ans = zero + randomFirst.ToString() + "." + zero2 + randomSecond.ToString() + " " + finalLetters;

                lboxDisplay.Items.Add(ans);
            }
            
        }


        //https://stackoverflow.com/questions/4796109/how-to-move-item-in-listbox-up-and-down
        //Author: Save
        //Used his code to help move the item up and down the listbox
        private void btnUp_Click(object sender, EventArgs e)
        {
            MoveUp();
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            MoveDown();
        }

        public void MoveUp()
        {
            MoveItem(-1);
        }

        public void MoveDown()
        {
            MoveItem(1);
        }

        public void MoveItem(int direction)
        {
            // Checking selected item
            if (lboxDisplay.SelectedItem == null || lboxDisplay.SelectedIndex < 0)
                return; // No selected item - nothing to do

            // Calculate new index using move direction
            int newIndex = lboxDisplay.SelectedIndex + direction;

            // Checking bounds of the range
            if (newIndex < 0 || newIndex >= lboxDisplay.Items.Count)
                return; // Index out of range - nothing to do

            object selected = lboxDisplay.SelectedItem;

            // Removing removable element
            lboxDisplay.Items.Remove(selected);
            // Insert it in new position
            lboxDisplay.Items.Insert(newIndex, selected);
            // Restore selection
            lboxDisplay.SetSelected(newIndex, true);
        }

        //end of Saves code used to move the listbox items................
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            GenericUtility<string> genericUtility = new GenericUtility<string>();
            lboxAnswer.Items.Clear();
            List<string> userAns = lboxDisplay.Items.Cast<string>().ToList();
            List<string> OrderedAns = new List<string>();
            int num = 0, points = 0;
            string check="";

            OrderedAns = userAns.OrderBy(q => q).ToList();

            foreach (var item in OrderedAns)
            {
                
                if (genericUtility.Compare(userAns[num], OrderedAns[num]))
                {
                    points++;
                    check = "Correct";
                }
                else
                {
                    check = "Incorrect";
                }
                lboxAnswer.Items.Add(OrderedAns[num] +" "+ check);
                num++;
            }

            
            MessageBox.Show("You scored: " + points.ToString());

            try
            {
                // Open the text file using a stream reader.
                using (StreamWriter sw = File.AppendText("Scoreboard.txt"))
                {
                    // Read the stream as a string, and write the string to the console.
                    sw.WriteLine(points.ToString()+" points - " +txtbUser.Text );
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("The file could not be read:"+ex.Message);
            }

        }

        private void btnScoreboard_Click(object sender, EventArgs e)
        {
            Form form = null;
            form = new Scoreboard();
            form.ShowDialog();
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = null;
            form = new MainMenu();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}
