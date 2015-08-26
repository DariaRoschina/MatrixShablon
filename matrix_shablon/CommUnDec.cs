using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
namespace matrix_shablon
{
   public class CommUnDec:ICommand
    {
        IMatrix smatrix, dmatrix;
        IDrawer draw1, draw2;
        
        Form2 form2;

        public CommUnDec(Form2 form2)
        { this.form2 = form2; }
       public  void Execute()
        {
            ManagComm.getInstance().addComm(this);
            form2.getGraph1().Clear(Color.AntiqueWhite);
            form2.getGraph2().Clear(Color.AntiqueWhite);
            draw1 = new Sheme4(form2.getGraph1(), 10, 10);
            draw2 = new Sheme4(form2.getGraph2(), 10, 10);
            smatrix = smatrix.GetComponent();
            dmatrix = dmatrix.GetComponent();
            smatrix.setDrawer(draw1);
            dmatrix.setDrawer(draw2);
            smatrix.draw();
            dmatrix.draw();
        }
    }
}
