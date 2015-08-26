using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace matrix_shablon
{
    class CommGen:ICommand
    {
       IMatrix m1, m2;
       IDrawer d,d1;
       Graphics g, g1;
       Form2 form2;
       public CommGen( Form2 form2)
       {
           
           this.form2 = form2;
       }

     public    void Execute()
        {
            ManagComm.getInstance().addComm(this);
            m1 = new SimpleMatrix(3, 4);
            m2 = new DisperseMatrix(5, 3);
            IniciatorMatrix.fullMatrix(m1, 8, 45);
            IniciatorMatrix.fullMatrix(m2, 6, 45);
            g = form2.getGraph1();
            g1 = form2.getGraph2();
            d = new Sheme1(g, 10, 10);
            d1 = new Sheme1(g1, 10, 10);
            m1.setDrawer(d);
            m2.setDrawer(d1);
            m1.draw();
            m2.draw();
        }

        
    }
}
