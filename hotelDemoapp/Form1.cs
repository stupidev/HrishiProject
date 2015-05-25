using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace hotelDemoapp
{
    public partial class Form1 : Form
    {
        Class1 cs = new Class1();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cs.con.Open();
            SqlCommand cmd = new SqlCommand();
            

        }
    }
}
