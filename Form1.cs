using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _27_07_22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);

                MessageBox.Show("Successfully Excluded student", "Exclusion",
                                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                label5.Text = dataGridView1.RowCount.ToString();

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(textBox1.Text, textBox2.Text);

            textBox1.Clear();
            textBox2.Clear();

            MessageBox.Show("Student successfully inducted", "Included", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            label5.Text = dataGridView1.RowCount.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
             if (dataGridView1.RowCount > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);

                MessageBox.Show("Successfully Excluded student", "Exclusion",
                                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                label5.Text = dataGridView1.RowCount.ToString();

            }
        }
    }
}
