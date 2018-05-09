using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value = textBox2.Text;
            dataGridView1.Rows[n].Cells[1].Value = textBox3.Text;
            Class1 c2 = new Class1();
            c2.Name = textBox2.Text;
            c2.Description = textBox1.Text;
            arrayuse u1 = new arrayuse();
            u1.Addlist_item(c2);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Class1 c1 = new Class1();
            Class1 c2 = new Class1();
            int index = e.RowIndex;
            DataGridViewRow selected_row = dataGridView1.Rows[index];
            arrayuse u4 = new arrayuse();
            c1.Name = selected_row.Cells[0].Value.ToString();
            //c1.Description = selected_row.Cells[1].Value.ToString();
            foreach (Class1 c3 in arrayuse.des)
            {

                if (c1.Name == c3.Name)
                {
                    c2.Name = c3.Name;
                    c2.Description = c3.Description;
                }
                u4.Addlist_item1(c2);
            }

            Form2 f1 = new Form2();
            f1.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
