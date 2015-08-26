using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace matrix_shablon
{
    public partial class Form1 : Form
    {
        IMatrix m1, m2;
        public Form1()
        {
            InitializeComponent();
            
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
           // m1 = new SimpleMatrix(2, 3);
           // m2 = new DisperseMatrix(3,4);
           // IniciatorMatrix.fullMatrix(m1,4,7);
           // IniciatorMatrix.fullMatrix(m2, 10, 5);
           // Statistics j =  new  Statistics(m1);
           // int y = j.max;
           // //textBox1.Text = Convert.ToString(y);
           // textBox1.Text = y.ToString();
           // label6.Text = y.ToString();
           //// textBox1.Text = Convert.ToInt32(y);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            m1 = new SimpleMatrix(2, 3);
            m2 = new DisperseMatrix(4, 2);
            IniciatorMatrix.fullMatrix(m1, 4, 7);
            IniciatorMatrix.fullMatrix(m2, 10, 5);
            Statistics j = new Statistics(m1);
            int y = j.max;
            Statistics l = new Statistics(m2);
            int x = l.max;
            textBox1.Text = y.ToString();
            textBox3.Text = x.ToString();
            int z = j.notnull;
            int v = l.notnull;
            textBox2.Text = z.ToString();
            textBox4.Text = v.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }
    }
}
