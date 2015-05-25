using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace hotelDemoapp
{
    public partial class order : Form
    {
        public order()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            dataGridView1.Rows[1].Cells["Name"].Value = comboBox1.Text;
            dataGridView1.Rows[2].Cells["Rate"].Value = textBox1.Text;
            dataGridView1.Rows[3].Cells["Qty"].Value = textBox2.Text;
            dataGridView1.Rows[4].Cells["Total"].Value = textBox3.Text;
            //dataGridView1.Rows[0].Cells["zipcode"].Value = textBox5.Text;
            //dataGridView1.Items.Add(comboBox2.Text.PadRight(30) + textBox1.Text.PadRight(20) + textBox2.Text.PadRight(20) + textBox3.Text.PadRight(20));

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridView eachItem in dataGridView1.SelectedRows)
                {
                    
                }
            }
            catch (Exception)
            {

                return;
            }
        }
    }
}
