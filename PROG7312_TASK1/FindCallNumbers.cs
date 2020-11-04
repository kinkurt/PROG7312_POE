using PROG7312_TASK1.Basic_Tree;
using PROG7312_TASK1.Node;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROG7312_TASK1
{
    
    public partial class FindCallNumbers : Form
    {
        Tree<string> tree = new Tree<string>();
        string answer,answerSecond,answerThird,answerFourth;
        Random randomNum = new Random();
        int gameState = 2,tempCode1,tempCode2,num1,num2,score;
        //gameState is checking what stage of the game the user is on.

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)// main menu
        {
            Form form = null;
            form = new MainMenu();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void highScoreToolStripMenuItem_Click(object sender, EventArgs e)// scoreboard menu
        {
            Form form = null;
            form = new Scoreboard();
            form.ShowDialog();
        }

        string[] arrayCodes = new string[] {"07","09","18","26","33","35","40","56","67","70","79","88","90","96"}; // had to hard code the numbers that are available for selection from the tree 13 children children of children
        public FindCallNumbers()
        {
            InitializeComponent();
            string LOG_PATH = "DDC.txt";

            var logFile = File.ReadAllLines(LOG_PATH);
            var logList = new List<string>(logFile);

            //these are the different list that are used depending on what level the user is on. They are the values for each level.
            List<string> SecondLevel = new List<string>();
            List<string> ThirdLevel = new List<string>();
            List<string> FourthLevel = new List<string>();
            List<string> codes = new List<string>();

            tree.Root = new TreeNode<string>() { Data = "DDC" };// the root

            lblQuestion.Text = "";
            rbtnClear();
            hideItems();



            foreach (var item in logList)
            {
                string temp = item;
                if (string.IsNullOrWhiteSpace(temp))
                {
                    
                }
                else
                {
                    temp = temp.Substring(0, 3);
                   // string temp2 = temp.Substring(0, 1);

                    if (temp.EndsWith("00"))//checking to see what should be after the root
                    {
                        SecondLevel.Add(item);
                        ThirdLevel.Add(item);
                        codes.Add(temp);
                    }
                    else if(temp.EndsWith("0"))//next is the child of the parent
                    {
                        ThirdLevel.Add(item);
                    }
                    else // last level the leaf/ children of the children.
                    {
                        FourthLevel.Add(item);
                    }
                }
            }

            SecondLevel.Sort();

            tree.Root.Children = new List<TreeNode<string>>{};
            foreach (string treeChild in SecondLevel)// adding the first nodes of children 2nd level
            {
                 tree.Root.Children.Add(new TreeNode<string> { Data = treeChild, Parent = tree.Root}); 
            }

            try  
            {
                tree.Root.Children[0].Children = new List<TreeNode<string>> { };
                tree.Root.Children[1].Children = new List<TreeNode<string>> { };
                tree.Root.Children[2].Children = new List<TreeNode<string>> { };
                tree.Root.Children[3].Children = new List<TreeNode<string>> { };
                tree.Root.Children[4].Children = new List<TreeNode<string>> { };
                tree.Root.Children[5].Children = new List<TreeNode<string>> { };
                tree.Root.Children[6].Children = new List<TreeNode<string>> { };
                tree.Root.Children[7].Children = new List<TreeNode<string>> { };
                tree.Root.Children[8].Children = new List<TreeNode<string>> { };
                tree.Root.Children[9].Children = new List<TreeNode<string>> { };
            }
            catch (Exception)
            {

                throw;
            }

            foreach (string treeChildChild in ThirdLevel)
            {
                try  // adding the first nodes of children 3rd level
                {
                    string temp = treeChildChild.Substring(0, 3);
                    if (temp.StartsWith("0"))
                    {
                        tree.Root.Children[0].Children.Add(new TreeNode<string> { Data = treeChildChild, Parent = tree.Root.Children[0] });
                    }
                    else if (temp.StartsWith("1"))
                    {
                        tree.Root.Children[1].Children.Add(new TreeNode<string> { Data = treeChildChild, Parent = tree.Root.Children[1] });
                    }
                    else if (temp.StartsWith("2"))
                    {
                        tree.Root.Children[2].Children.Add(new TreeNode<string> { Data = treeChildChild, Parent = tree.Root.Children[2] });
                    }
                    else if (temp.StartsWith("3"))
                    {
                        tree.Root.Children[3].Children.Add(new TreeNode<string> { Data = treeChildChild, Parent = tree.Root.Children[3] });
                    }
                    else if (temp.StartsWith("4"))
                    {
                        tree.Root.Children[4].Children.Add(new TreeNode<string> { Data = treeChildChild, Parent = tree.Root.Children[4] });
                    }
                    else if (temp.StartsWith("5"))
                    {
                        tree.Root.Children[5].Children.Add(new TreeNode<string> { Data = treeChildChild, Parent = tree.Root.Children[5] });
                    }
                    else if (temp.StartsWith("6"))
                    {
                        tree.Root.Children[6].Children.Add(new TreeNode<string> { Data = treeChildChild, Parent = tree.Root.Children[6] });
                    }
                    else if (temp.StartsWith("7"))
                    {
                        tree.Root.Children[7].Children.Add(new TreeNode<string> { Data = treeChildChild, Parent = tree.Root.Children[7] });
                    }
                    else if (temp.StartsWith("8"))
                    {
                        tree.Root.Children[8].Children.Add(new TreeNode<string> { Data = treeChildChild, Parent = tree.Root.Children[8] });
                    }
                    else if (temp.StartsWith("9"))
                    {
                        tree.Root.Children[9].Children.Add(new TreeNode<string> { Data = treeChildChild, Parent = tree.Root.Children[9] });
                    }
                }
                catch (Exception e)
                {
                    throw;
                }
                
            }
           
                   
                tree.Root.Children[0].Children[7].Children = new List<TreeNode<string>> { };
                tree.Root.Children[0].Children[9].Children = new List<TreeNode<string>> { };
                tree.Root.Children[1].Children[8].Children = new List<TreeNode<string>> { };
                tree.Root.Children[2].Children[6].Children = new List<TreeNode<string>> { };
                tree.Root.Children[3].Children[3].Children = new List<TreeNode<string>> { };
                tree.Root.Children[3].Children[5].Children = new List<TreeNode<string>> { };
                tree.Root.Children[4].Children[0].Children = new List<TreeNode<string>> { };
                tree.Root.Children[5].Children[6].Children = new List<TreeNode<string>> { };
                tree.Root.Children[6].Children[7].Children = new List<TreeNode<string>> { };
                tree.Root.Children[7].Children[0].Children = new List<TreeNode<string>> { };
                tree.Root.Children[7].Children[9].Children = new List<TreeNode<string>> { };
                tree.Root.Children[8].Children[8].Children = new List<TreeNode<string>> { };
                tree.Root.Children[9].Children[0].Children = new List<TreeNode<string>> { };
                tree.Root.Children[9].Children[6].Children = new List<TreeNode<string>> { };
            
            
            foreach (string treeChildChildChild in FourthLevel)
            {
                try
                {
                    //adding the children of the children - 4th level
                    string temp = treeChildChildChild.Substring(0, 3);
                    if (temp.StartsWith("07"))
                    {
                        tree.Root.Children[0].Children[7].Children.Add(new TreeNode<string> { Data = treeChildChildChild, Parent = tree.Root.Children[0].Children[7] });
                    }
                    else if (temp.StartsWith("09"))
                    {
                        tree.Root.Children[0].Children[9].Children.Add(new TreeNode<string> { Data = treeChildChildChild, Parent = tree.Root.Children[0].Children[9] });
                    }
                    else if (temp.StartsWith("18"))
                    {
                        tree.Root.Children[1].Children[8].Children.Add(new TreeNode<string> { Data = treeChildChildChild, Parent = tree.Root.Children[1].Children[8] });
                    }
                    else if (temp.StartsWith("26"))
                    {
                        tree.Root.Children[2].Children[6].Children.Add(new TreeNode<string> { Data = treeChildChildChild, Parent = tree.Root.Children[2].Children[6] });
                    }
                    else if (temp.StartsWith("33"))
                    {
                        tree.Root.Children[3].Children[3].Children.Add(new TreeNode<string> { Data = treeChildChildChild, Parent = tree.Root.Children[3].Children[3] });
                    }
                    else if (temp.StartsWith("35"))
                    {
                        tree.Root.Children[3].Children[5].Children.Add(new TreeNode<string> { Data = treeChildChildChild, Parent = tree.Root.Children[3].Children[5] });
                    }
                    else if (temp.StartsWith("40"))
                    {
                        tree.Root.Children[4].Children[0].Children.Add(new TreeNode<string> { Data = treeChildChildChild, Parent = tree.Root.Children[4].Children[0] });
                    }
                    else if (temp.StartsWith("56"))
                    {
                        tree.Root.Children[5].Children[6].Children.Add(new TreeNode<string> { Data = treeChildChildChild, Parent = tree.Root.Children[5].Children[6] });
                    }
                    else if (temp.StartsWith("67"))
                    {
                        tree.Root.Children[6].Children[7].Children.Add(new TreeNode<string> { Data = treeChildChildChild, Parent = tree.Root.Children[6].Children[7] });
                    }
                    else if (temp.StartsWith("70"))
                    {
                        tree.Root.Children[7].Children[0].Children.Add(new TreeNode<string> { Data = treeChildChildChild, Parent = tree.Root.Children[7].Children[0] });
                    }
                    else if (temp.StartsWith("79"))
                    {
                        tree.Root.Children[7].Children[9].Children.Add(new TreeNode<string> { Data = treeChildChildChild, Parent = tree.Root.Children[7].Children[9] });
                    }
                    else if (temp.StartsWith("88"))
                    {
                        tree.Root.Children[8].Children[8].Children.Add(new TreeNode<string> { Data = treeChildChildChild, Parent = tree.Root.Children[8].Children[8] });
                    }
                    else if (temp.StartsWith("90"))
                    {
                        tree.Root.Children[9].Children[0].Children.Add(new TreeNode<string> { Data = treeChildChildChild, Parent = tree.Root.Children[9].Children[0] });
                    }
                    else if (temp.StartsWith("96"))
                    {
                        tree.Root.Children[9].Children[6].Children.Add(new TreeNode<string> { Data = treeChildChildChild, Parent = tree.Root.Children[9].Children[6] });
                    }
                }
                catch (Exception)
                {

                    throw;
                }

            }

        }

        private void btnStart_Click(object sender, EventArgs e)// start button clears the form and calls the method that populates everything
        {
            if (string.IsNullOrWhiteSpace(txtbUser.Text))
            {
                MessageBox.Show("Please fill in username");
                return;
            }
            gameState = 2;
            setUp();
            rbtnClear();
            score = 0;
            lblScore.Text = "Score: "+score;
            btnSubmit.Enabled = true;
            btnStart.Enabled = false;
        }

        

        private void setUp()
        {
            if(gameState == 2)
            {
                //random numbers for the selection of the answer. It is 13 for num1 because thats how many children it can select from and then a further 9 from each of those 13
                num1 = randomNum.Next(0, 13);
                num2 = randomNum.Next(0, 9);
                string tempCode = arrayCodes[num1];
                tempCode1 = Int32.Parse(tempCode.Substring(0, 1));
                tempCode2 = Int32.Parse(tempCode.Substring(1, 1));
                
                try
                {
                    answer = tree.Root.Children[tempCode1].Children[tempCode2].Children[num2].Data;
                }
                catch
                {
                    throw;
                }

                //populating each of the levels with the answers so that we can compare them at the checking section.
                answerSecond = tree.Root.Children[tempCode1].Data;
                answerThird = tree.Root.Children[tempCode1].Children[tempCode2].Data;
                answerFourth = tree.Root.Children[tempCode1].Children[tempCode2].Children[num2].Data;
            }

            rbtnOption1.Text = "";
            rbtnOption2.Text = "";
            rbtnOption3.Text = "";
            rbtnOption4.Text = "";
            int counter = 0;
            int temp, temp2, temp3;
            List<string> options = new List<string>();
            List<int> numberOptions = new List<int>();
            List<int> numberOptions2 = new List<int>();
            List<int> numberOptions3 = new List<int>();


            //depending on what level the user is on the options are being populated from here on
            if (gameState == 2)
            {
                options.Add(answerSecond);
            }
            else if (gameState == 3)
            {
                options.Add(answerThird);
            }
            else if (gameState == 4)
            {
                options.Add(answerFourth);
            }
            
            numberOptions.Add(tempCode1);
            numberOptions2.Add(tempCode2);
            numberOptions3.Add(num2);

            while (counter < 3)
            {
                
                temp = randomNum.Next(0, 9);
                temp2 = randomNum.Next(0,9);
                temp3 = randomNum.Next(0,9);
                bool duplicate = false;
                if (gameState == 2)
                {
                    for (int i = 0; i < numberOptions.Count; i++)
                    {
                        if (temp == numberOptions[i])
                        {
                            duplicate = true;
                        }
                    }
                }
                else if (gameState == 3)
                {
                    for (int x = 0; x < numberOptions2.Count; x++)
                    {
                        if (temp2 == numberOptions2[x])
                        {
                            duplicate = true;
                        }
                    }
                }
                else if (gameState == 4)
                {
                    for (int y = 0; y < numberOptions3.Count; y++)
                    {
                        if (temp3 == numberOptions3[y])
                        {
                            duplicate = true;
                        }
                    }
                }
                
                // making sure there are no duplicates in the options.
                if (duplicate == false)
                {
                    if (gameState == 2)
                    {
                        options.Add(tree.Root.Children[temp].Data);
                        numberOptions.Add(temp);
                    }
                    else if (gameState == 3)
                    {
                        options.Add(tree.Root.Children[tempCode1].Children[temp2].Data);
                        numberOptions2.Add(temp2);
                    } 
                    else if(gameState == 4)
                    {
                        options.Add(tree.Root.Children[tempCode1].Children[tempCode2].Children[temp3].Data);
                        numberOptions3.Add(temp3);
                    }
                    counter++;
                }
            }
            //ordering the options as required.
            options = options.OrderByDescending(q => q).Reverse().ToList();
            rbtnOption1.Text = options[0];
            rbtnOption2.Text = options[1];
            rbtnOption3.Text = options[2];
            rbtnOption4.Text = options[3];

            string tempans = answer.Remove(0, 3);
            lblQuestion.Text = "Question: "+tempans;
            lblForMarking.Text = answer;// this was just to make it easier for the person to mark
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            setUp();
            btnNext.Enabled = false;
            btnSubmit.Enabled = true;
            rbtnClear();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            btnSubmit.Enabled = false;
            bool incorrect = false;
            string userChoice;
            //checking what the user selected
            if (rbtnOption1.Checked)
            {
                userChoice = rbtnOption1.Text;
            }
            else if (rbtnOption2.Checked)
            {
                userChoice = rbtnOption2.Text;
            }
            else if (rbtnOption3.Checked)
            {
                userChoice = rbtnOption3.Text;
            }
            else if(rbtnOption4.Checked)
            {
                userChoice = rbtnOption4.Text;
            }
            else
            {
                MessageBox.Show("Please select an answer");
                btnSubmit.Enabled = true;
                return;
            }
            //this comes in from before where we populated those 3 variables with the answers
            if (userChoice.Equals(answerSecond))
            {
                gameState++;
                score++;
                btnNext.Enabled = true;
            }
            else if(userChoice.Equals(answerThird))
            {
                gameState++;
                score++;
                btnNext.Enabled = true;
            }
            else if (userChoice.Equals(answerFourth))
            {
                gameState = 2;
                score++;
                btnNext.Enabled = true;
            }
            else
            {
                MessageBox.Show("Your run has ended with a score of "+ score);
                btnStart.Enabled = true;
                incorrect = true;
                User user = new User();
                user.Username = txtbUser.Text;//my oop i hope
                string tempPoints="";

                if (score < 10)
                {
                    tempPoints = "0" + score.ToString();
                }
                else
                {
                    tempPoints = score.ToString();
                }
                try
                {
                    // Open the text file using a stream reader.
                    using (StreamWriter sw = File.AppendText("FindCallNumbers.txt"))
                    {
                        // Read the stream as a string, and write the string to the console.
                        sw.WriteLine(tempPoints + " points - " + user.Username);
                    }
                }
                catch (IOException ex)
                {
                    MessageBox.Show("The file could not be read:" + ex.Message);
                }
            }
            //displaying to the user if the y got the correct or incorrect answer.
            if (rbtnOption1.Checked)
            {
                userChoice = rbtnOption1.Text;
                if (incorrect == true)
                {
                    rbtnOption1.Text = userChoice + "  - Incorrect answer.";
                }
                else
                {
                    rbtnOption1.Text = userChoice + "  - Correct answer.";
                }
                
            }
            else if (rbtnOption2.Checked)
            {
                userChoice = rbtnOption2.Text;
                if (incorrect == true)
                {
                    rbtnOption2.Text = userChoice + "  - Incorrect answer.";
                }
                else
                {
                    rbtnOption2.Text = userChoice + "  - Correct answer.";
                }
            }
            else if (rbtnOption3.Checked)
            {
                userChoice = rbtnOption3.Text;
                if (incorrect == true)
                {
                    rbtnOption3.Text = userChoice + "  - Incorrect answer.";
                }
                else
                {
                    rbtnOption3.Text = userChoice + "  - Correct answer.";
                }
            }
            else if (rbtnOption4.Checked)
            {
                userChoice = rbtnOption4.Text;
                if (incorrect == true)
                {
                    rbtnOption4.Text = userChoice + "  - Incorrect answer.";
                }
                else
                {
                    rbtnOption4.Text = userChoice + "  - Correct answer.";
                }
            }
            lblScore.Text = "Score: " + score;
        }

        private void rbtnClear()
        {
            rbtnOption1.Visible = true;
            rbtnOption2.Visible = true;
            rbtnOption3.Visible = true;
            rbtnOption4.Visible = true;

            rbtnOption1.Checked = false;
            rbtnOption2.Checked = false;
            rbtnOption3.Checked = false;
            rbtnOption4.Checked = false;
        }
        private void hideItems()
        {
            rbtnOption1.Visible = false;
            rbtnOption2.Visible = false;
            rbtnOption3.Visible = false;
            rbtnOption4.Visible = false;
            rbtnOption1.Text = "";
            rbtnOption2.Text = "";
            rbtnOption3.Text = "";
            rbtnOption4.Text = "";
        }
    }
}
