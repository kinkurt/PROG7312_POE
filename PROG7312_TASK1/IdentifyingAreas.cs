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
    public partial class IdentifyingAreas : Form
    {
        Dictionary<string, string> identifiyAreas = new Dictionary<string, string>();
        Dictionary<string, string> tempDictionary = new Dictionary<string, string>();
        List<string> keyList = new List<string>();
        List<string> valueList = new List<string>();
        List<string> tempList = new List<string>();
        int score = 0;
        public IdentifyingAreas()
        {
            InitializeComponent();

            MatchTheColumn matchTheColumn = new MatchTheColumn();

            identifiyAreas.Add("000", "General Knowledge");
            identifiyAreas.Add("100", "Philosophy and Psycology");
            identifiyAreas.Add("200", "Religion");
            identifiyAreas.Add("300", "Social Sciences");
            identifiyAreas.Add("400", "Languages");
            identifiyAreas.Add("500", "Science");
            identifiyAreas.Add("600", "Technology");
            identifiyAreas.Add("700", "Arts and Recreation");
            identifiyAreas.Add("800", "Literature");
            identifiyAreas.Add("900", "History and Geography");

            foreach (KeyValuePair<string, string> ele in identifiyAreas)
            {
                matchTheColumn.terms = ele.Key;
                matchTheColumn.definition = ele.Value;

                keyList.Add(matchTheColumn.terms);
                valueList.Add(matchTheColumn.definition);

                //MessageBox.Show(matchTheColumn.terms + " " + matchTheColumn.definition);
            };

            Disable();
            Clear();
        }

        private void btnStartIdentifying_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtbUser.Text))
            {
                MessageBox.Show("Please fill in username");
                return;
            }  

            score = 0;
            Enable();
            Clear();
            btnSubmit.Enabled = true ;
            tempList.Clear();
            List<string> ansList = new List<string>();
            Random random = new Random();
            int[] numList = new int[10];
            int[] num2List = new int[7];
            tempDictionary.Clear();
            int x = 0,y =0;
            

            while ( x < 7)
            {
                //A random generator so that the questions are always different. I had to use 1,11 because 0 does count in a int array.
                int temp = random.Next(1, 11);
                bool duplicate =false;
                for (int i = 0; i < 10; i++)
                {
                    if (temp == numList[i] )
                    {
                        duplicate = true;

                    }
                }

                if (duplicate == false)
                {
                    numList[x]= temp;
                    if (rbtnCalltoDesc.Checked == true)
                    {
                        ansList.Add(valueList[temp - 1]);
                    }
                    else if (rbtnDescToCall.Checked == true)
                    {
                        ansList.Add(keyList[temp - 1]);
                    }
                    
                   
                    
                    x++;
                }
            }

            //have to switch the answers around for the differnt option the user chooses
            if (rbtnCalltoDesc.Checked == true)
            {
                //setting the labels to display the terms and store the answers into a list.
                lblTerm1.Text = "1: " + keyList[numList[0] - 1];
                tempList.Add(valueList[numList[0] - 1]);
                lblTerm2.Text = "2: " + keyList[numList[1] - 1];
                tempList.Add(valueList[numList[1] - 1]);
                lblTerm3.Text = "3: " + keyList[numList[2] - 1];
                tempList.Add(valueList[numList[2] - 1]);
                lblTerm4.Text = "4: " + keyList[numList[3] - 1];
                tempList.Add(valueList[numList[3] - 1]);
            }
            else if (rbtnDescToCall.Checked == true)
            {
                lblTerm1.Text = "1: " + valueList[numList[0] - 1];
                tempList.Add(keyList[numList[0] - 1]);
                lblTerm2.Text = "2: " + valueList[numList[1] - 1];
                tempList.Add(keyList[numList[1] - 1]);
                lblTerm3.Text = "3: " + valueList[numList[2] - 1];
                tempList.Add(keyList[numList[2] - 1]);
                lblTerm4.Text = "4: " + valueList[numList[3] - 1];
                tempList.Add(keyList[numList[3] - 1]);
            }
            

            while ( y < 7)
            {
                int temp2 = random.Next(1,8);
                bool duplicate = false;

                for (int i = 0; i < 7; i++)
                {
                    if (temp2 == num2List[i])
                    {
                        duplicate = true;
                    }
                }

                if (duplicate == false)
                {
                    num2List[y] = temp2;
                    y++;
                }
            }

            // setting all the label on the definition side for the user to choose from
            lblDefinition1.Text = "A: " + ansList[num2List[0]-1];
            lblDefinition2.Text = "B: " + ansList[num2List[1]-1];
            lblDefinition3.Text = "C: " + ansList[num2List[2]-1];
            lblDefinition4.Text = "D: " + ansList[num2List[3]-1];
            lblDefinition5.Text = "E: " + ansList[num2List[4]-1];
            lblDefinition6.Text = "F: " + ansList[num2List[5]-1];
            lblDefinition7.Text = "G: " + ansList[num2List[6]-1];


        }

        // the clearing and enable and disabling of items on the page.
        private void Disable()
        {
            cmb1.Enabled = false;
            cmb2.Enabled = false;
            cmb3.Enabled = false;
            cmb4.Enabled = false;
        }

        private void Enable()
        {
            cmb1.Enabled = true;
            cmb2.Enabled = true;
            cmb3.Enabled = true;
            cmb4.Enabled = true;

            cmb1.SelectedIndex = -1;
            cmb2.SelectedIndex = -1;
            cmb3.SelectedIndex = -1;
            cmb4.SelectedIndex = -1;
        }

        private void Clear()
        {
            lblShowAns1.Text = "";
            lblShowAns2.Text = "";
            lblShowAns3.Text = "";
            lblShowAns4.Text = "";

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Disable();
            Clear();
            string answer1, answer2, answer3, answer4;
            int count = 0;
            answer1 = cmb1.Text;
            btnSubmit.Enabled = false;

            //there might be a more efficient way of doing this but I went through each answer to see if its correct or incorrect.
            if(ansCheck(answer1, count)== true)
            {
                lblShowAns1.Text = "Correct";
            }
            else
            {
                lblShowAns1.Text = "Inorrect";
            }
            count++;
            answer2 = cmb2.Text;
            if (ansCheck(answer2, count) == true)
            {
                lblShowAns2.Text = "Correct";
            }
            else
            {
                lblShowAns2.Text = "Inorrect";
            }
            count++;
            answer3 = cmb3.Text;
            if (ansCheck(answer3, count) == true)
            {
                lblShowAns3.Text = "Correct";
            }
            else
            {
                lblShowAns3.Text = "Inorrect";
            }
            count++;
            answer4 = cmb4.Text;
            if (ansCheck(answer4, count) == true)
            {
                lblShowAns4.Text = "Correct";
            }
            else
            {
                lblShowAns4.Text = "Inorrect";
            }


            MessageBox.Show("Your scored: " + score+" out of 4");
            clearLabels();
            try
            {
                // Open the text file using a stream reader.
                using (StreamWriter sw = File.AppendText("IdentifyingAreasScore.txt"))
                {
                    // Read the stream as a string, and write the string to the console.
                    sw.WriteLine(score.ToString() + " points - " + txtbUser.Text);
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("The file could not be read:" + ex.Message);
            }



        }

        private bool ansCheck(string answer, int count)
        {
            //chcking the users answers, whichever letter they chose it pulls the text from the label and removes the extra stuff to compare.
            string definition;
            switch (answer)
            {
                case "A":
                    definition = lblDefinition1.Text.ToString();
                    break;
                case "B":
                    definition = lblDefinition2.Text.ToString();
                    break;
                case "C":
                    definition = lblDefinition3.Text.ToString();
                    break;
                case "D":
                    definition = lblDefinition4.Text.ToString();
                    break;
                case "E":
                    definition = lblDefinition5.Text.ToString();
                    break;
                case "F":
                    definition = lblDefinition6.Text.ToString();
                    break;
                case "G":
                    definition = lblDefinition7.Text.ToString();
                    break;
                default:
                    definition = "Incorrect";
                    break;
            }

            definition = definition.Remove(0, 3);

            if (definition.Equals(tempList[count]))
            {
                score++;
                return true;
            }
            else
            {
                return false;
            }
        }

        private void clearLabels()
        {
            lblDefinition1.Text = "A:";
            lblDefinition2.Text = "B:";
            lblDefinition3.Text = "C:";
            lblDefinition4.Text = "D:";
            lblDefinition5.Text = "E:";
            lblDefinition6.Text = "F:";
            lblDefinition7.Text = "G:";
            lblTerm1.Text = "1:";
            lblTerm2.Text = "2:";
            lblTerm3.Text = "3:";
            lblTerm4.Text = "4:";
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
