using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
namespace matrix_shablon
{
   public class CommRecordValue:ICommand
    {

       IMatrix m1, m2;
       IDrawer d,d1;
       Graphics g, g1;
       Form2 form2;
       public CommRecordValue(Form2 form2)
       {
           
           this.form2 = form2;
       }


        public void Execute()
        {
            ManagComm.getInstance().addComm(this);
            g = form2.getGraph1();
            g1 = form2.getGraph2();
            d = new Sheme1(g, 10, 10);
            d1 = new Sheme1(g1, 10, 10);
            m1 = m1.GetComponent();
            m2 = m2.GetComponent();
            RecordValue c = new RecordValue(m1, m2, d, d1);
            c.record();
        }
    }
}
