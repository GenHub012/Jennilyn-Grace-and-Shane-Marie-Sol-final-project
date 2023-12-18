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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.ToLower() == "holy week")
            {
                MessageBox.Show("Your answer is Correct...");
                Thread.Sleep(1000);

                this.Hide();
                Form5 form = new Form5();
                form.Show();
            }
            else
            {
                if (textBox1.Text != "holy week")
                {
                    MessageBox.Show("Your answer is Incorrect...  Try again..");
                    textBox1.Clear();
                    textBox1.Focus();
                }
            }
        }
    }
}
