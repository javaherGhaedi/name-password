using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace UserName_Password
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = "Javaher";
            string password = "j1234";
            if(textBox1.Text== username && textBox2.Text== password)
            {
                Form2 j = new Form2();
                j.Show();
                Hide();
                MessageBox.Show("welcome");
            }
            else
            {
                MessageBox.Show("please check user and password");
            }
            File.WriteAllText(@"D:\Information","Name:" +textBox1.Text +"\r\n"+ "Password:" +textBox2.Text);
        }
        
    }
}
