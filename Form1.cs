using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Test");

            string str = "This is a test of Linq!";

            var res = from x in str where x=='i' select x;

            foreach (var item in res)
            {
                MessageBox.Show(item.ToString());
            }

        }
    }
}
