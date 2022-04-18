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
    public partial class Form2 : Form
    {
        Model1 db = new Model1();

        public Form2()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Drivers drivers = new Drivers();
            drivers.Идентификатор = Convert.ToInt32(textBox14.Text);
            drivers.Имя = textBox2.Text;
            drivers.Фамилия = textBox3.Text;
            drivers.Отчество = textBox4.Text;
            drivers.Паспорт = textBox5.Text;
            drivers.Почта = textBox1.Text;
            drivers.АдресРегистрации = textBox7.Text;
            drivers.АдресПроживания = textBox8.Text;
            drivers.МестоРаботы = textBox9.Text;
            drivers.Должность = textBox10.Text;
            drivers.МобильныйТелефон = textBox11.Text;
            drivers.Email = textBox12.Text;
            drivers.Фотография = textBox13.Text;
            db.Drivers.Add(drivers);
            db.SaveChanges();
            this.Hide();
            Form2 frm = new Form2();
            frm.Show();
        }
    }
}
