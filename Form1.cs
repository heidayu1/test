using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Daytime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            t1.Text = "ngày " + DateTime.Now.ToString("dd") + " tháng " + DateTime.Now.ToString("MM") + " năm " + DateTime.Now.ToString("yyyy");
            t1.SelectionStart = 0;
            t1.SelectionLength = t1.Text.Length;
        }
        /*private void textBox1_TextChanged(object sender, EventArgs e)
        {
            t1.Text = "TPHCM, ngày " + DateTime.Now.ToString("dd") + " Tháng " + DateTime.Now.ToString("MM") + " năm " + DateTime.Now.ToString("yyyy");
            t1.SelectionStart = 0;
            t1.SelectionLength = t1.Text.Length;
        }*/
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
