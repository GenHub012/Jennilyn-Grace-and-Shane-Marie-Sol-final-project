using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jennilyn_Grace_and_Shane_Marie_Sol_final_project
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.ToLower() == "1792")
            {
                MessageBox.Show("Your answer is Correct...");
                Thread.Sleep(1000);

                this.Hide();
                Form7 form = new Form7();
                form.Show();
            }
            else
            {
                if (textBox1.Text != "1792")
                {
                    MessageBox.Show("Your answer is Incorrect...  Try again..");
                    textBox1.Clear();
                    textBox1.Focus();
                }
            }
        }
    }
}
