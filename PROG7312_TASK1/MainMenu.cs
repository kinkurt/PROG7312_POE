using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROG7312_TASK1
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnSelectOption_Click(object sender, EventArgs e)
        {
            Form form = null;

            if(rbtnReplacingBooks.Checked)
            {
                form = new ReplacingBooks();
                this.Hide();
                form.ShowDialog();
                this.Close();

            }
            else if(rbtnIdentifyingAreas.Checked)
            {
                form = new IdentifyingAreas();
                this.Hide();
                form.ShowDialog();
                this.Close();
            }
            else if (rbtnFindingCallNumbers.Checked)
            {

            }
            else
            {
                MessageBox.Show("No task selected");
            }
        }
    }
}
