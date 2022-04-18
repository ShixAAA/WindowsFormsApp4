using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public static int Code;
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           pass.UseSystemPasswordChar = true;
           PIN.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {          
            string loggR = "inspector";
            string PassR = "inspector";
            if (login.Text != loggR || pass.Text != PassR)
            {
                MessageBox.Show("Ошибка ввода!");
            }
            else
            {
                Form3 form3 = new Form3();
                form3.Show();
                this.Hide();
            }
        }
    }
}
