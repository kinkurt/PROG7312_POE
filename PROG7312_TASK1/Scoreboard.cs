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
    public partial class Scoreboard : Form
    {
        public Scoreboard()
        {
            InitializeComponent();
        }

        private void Scoreboard_Load(object sender, EventArgs e)
        {
            lboxScoreboard.Items.Add("Select which scoreboard");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            lboxScoreboard.Items.Clear();
            string scoreboard = "";
            if (rbtnReplacing.Checked == true)
            {
                scoreboard = "Scoreboard.txt";
            }
            else if (rbtnIdentify.Checked == true)
            {
                scoreboard = "IdentifyingAreasScore.txt";
            }
            else if (rbtnFind.Checked == true)
            {
                scoreboard = "FindCallNumbers.txt";
            }

            int num = 0;
            using (StreamReader sr = File.OpenText(scoreboard))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    lboxScoreboard.Items.Add(s);
                }
            }

            List<string> userScoreboard = lboxScoreboard.Items.Cast<string>().ToList();
            userScoreboard = userScoreboard.OrderByDescending(q => q).ToList();

            lboxScoreboard.Items.Clear();
            foreach (var item in userScoreboard)
            {
                lboxScoreboard.Items.Add(userScoreboard[num]);
                num++;
            }
        }
    }
}
