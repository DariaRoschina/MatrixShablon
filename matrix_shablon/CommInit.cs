using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
namespace matrix_shablon
{
    class CommInit:ICommand
    {
       Form2 form2;

       public CommInit(Form2 form2)
       {
           this.form2 = form2;
       }
       

      public   void Execute()
        {
            ManagComm.getInstance().addComm(this);
            form2.BackColor = Color.AliceBlue;
           // SolidBrush brush = new SolidBrush(Color.BlueViolet);
            //SolidBrush brush1 = new SolidBrush(Color.Fuchsia);
            //form2.getGraphics2().FillRectangle(brush1, 2, 3, 200, 300);
        }
    }
}
