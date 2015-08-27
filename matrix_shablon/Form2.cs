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
    public partial class Form2 : Form
    {
        IMatrix m1, m2;
        IDrawer d, d1;
        public Form2()
        {
            InitializeComponent();
            new CommInit(this).Execute();
        }
        void CleanMatrix()
        {
            Graphics g = Graphics.FromHwnd(panel1.Handle);
            Graphics g1 = Graphics.FromHwnd(panel2.Handle);
            g.Clear(Color.AntiqueWhite);
            g1.Clear(Color.AntiqueWhite);
        }
         private void Form2_Load(object sender, EventArgs e)
                {
                    radioButton1.Checked = true;
                    CleanMatrix();
                }
        private void button1_Click(object sender, EventArgs e)
        {
            CleanMatrix();
           // new CommGen(this).Execute();
            m1 = new SimpleMatrix(3, 4);
            m2 = new DisperseMatrix(5, 3);
            IniciatorMatrix.fullMatrix(m1, 8, 45);
            IniciatorMatrix.fullMatrix(m2, 6, 45);
            Graphics g = Graphics.FromHwnd(panel1.Handle);
            Graphics g1 = Graphics.FromHwnd(panel2.Handle);
            d = new Sheme1(g, 10, 10);
            d1 = new Sheme1(g1, 10, 10);
            m1.setDrawer(d);
            m2.setDrawer(d1);
            m1.draw();
            m2.draw();
        }

        
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            CleanMatrix();
            Graphics g = Graphics.FromHwnd(panel1.Handle);
            Graphics g1 = Graphics.FromHwnd(panel2.Handle);
            d = new Sheme1(g, 10, 10);
            d1 = new Sheme1(g1, 10, 10);
            m1.setDrawer(d);
            m2.setDrawer(d1);
            m1.draw();
            m2.draw();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            CleanMatrix();
            Graphics g = Graphics.FromHwnd(panel1.Handle);
            Graphics g1 = Graphics.FromHwnd(panel2.Handle);
            d = new Sheme2(g, 10, 10);
            d1 = new Sheme2(g1, 10, 10);
            m1.setDrawer(d);
            m2.setDrawer(d1);
            m1.draw();
            m2.draw();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            CleanMatrix();
            Graphics g = Graphics.FromHwnd(panel1.Handle);
            Graphics g1 = Graphics.FromHwnd(panel2.Handle);
            d = new Sheme3(g, 10, 10);
            d1 = new Sheme3(g1, 10, 10);
            m1.setDrawer(d);
            m2.setDrawer(d1);
            m1.draw();
            m2.draw();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            CleanMatrix();
            Graphics g = Graphics.FromHwnd(panel1.Handle);
            Graphics g1 = Graphics.FromHwnd(panel2.Handle);
            d = new Sheme4(g, 10, 10);
            d1 = new Sheme4(g1, 10, 10);
            m1.setDrawer(d);
            m2.setDrawer(d1);
            m1.draw();
            m2.draw();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CleanMatrix();
            Graphics g = Graphics.FromHwnd(panel1.Handle);
            Graphics g1 = Graphics.FromHwnd(panel2.Handle);
            
            d = new Sheme4(g, 10, 10);
            d1 = new Sheme4(g1, 10, 10);
            m1 = new HideDecorator(m1, 1, 2);
            m2 = new HideDecorator(m2, 1, 2);
            m1.setDrawer(d);
            m2.setDrawer(d1);
            m1.draw();
            m2.draw();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CleanMatrix();
            Graphics g = Graphics.FromHwnd(panel1.Handle);
            Graphics g1 = Graphics.FromHwnd(panel2.Handle);
            d = new Sheme4(g, 10, 10);
            d1 = new Sheme4(g1, 10, 10);
            m1 = m1.GetComponent();
            m2 = m2.GetComponent();
            m1.setDrawer(d);
            m2.setDrawer(d1);
            m1.draw();
            m2.draw();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromHwnd(panel3.Handle);
            g.Clear(Color.AntiqueWhite);
            HorizontMatr matrix1;
            matrix1 = new HorizontMatr();
            matrix1.addMatr(m1);
            matrix1.addMatr(m2);
            d = new Sheme4(g, 10, 10);
            matrix1.setDrawer(d);
            matrix1.draw();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromHwnd(panel4.Handle);
            g.Clear(Color.AntiqueWhite);
            VerticalMatrix matrix1;
            matrix1 = new VerticalMatrix();
            matrix1.addMatr(m1);
            matrix1.addMatr(m2);
            d = new Sheme4(g, 10, 10);
            matrix1.setDrawer(d);
            matrix1.draw();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromHwnd(panel5.Handle);
            g.Clear(Color.AntiqueWhite);
            HorizontMatr component = new HorizontMatr();
            VerticalMatrix matrix1 = new VerticalMatrix();
            matrix1.addMatr(m1);
            matrix1.addMatr(m2);
            VerticalMatrix matrix2 = new VerticalMatrix();
            matrix2.addMatr(m1);
            matrix2.addMatr(m2);
            component.addMatr(matrix1);
            component.addMatr(matrix2);
            d = new Sheme4(g, 10, 10);
            component.setDrawer(d);
            component.draw();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ManagComm.getInstance().remComm();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CleanMatrix();
           // new CommRecordValue(this).Execute();
            Graphics g = Graphics.FromHwnd(panel1.Handle);
            Graphics g1 = Graphics.FromHwnd(panel2.Handle);
            d = new Sheme1(g, 10, 10);
            d1 = new Sheme1(g1, 10, 10);
            m1 = m1.GetComponent();
            m2 = m2.GetComponent();
            RecordValue c = new RecordValue(m1, m2, d, d1);
            c.record();
        }


        public Graphics getGraph1()
        { return Graphics.FromHwnd(panel1.Handle); }
        public Graphics getGraph2()
        { return Graphics.FromHwnd(panel2.Handle); }
        public Graphics getGraph3()
        { return Graphics.FromHwnd(panel3.Handle); }
        public Graphics getGraph4()
        { return Graphics.FromHwnd(panel4.Handle); }
        public Graphics getGraph5()
        { return Graphics.FromHwnd(panel5.Handle); }
     
    }
}
