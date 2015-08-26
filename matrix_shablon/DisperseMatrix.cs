using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace matrix_shablon
{
  public  class DisperseMatrix:ASomeMatrix
           {
         public DisperseMatrix (int rows,int cols):base(rows,cols){}


        protected override IVector function(int size)
        {
            return new DisperseVector(size);
        }

        public override void draw()
        {
            Border(this);
            for (int i = 0; i < this.row_num; i++)
                for (int j = 0; j < this.col_num; j++)
                {
                    if (this[i, j] != 0)
                    {
                        CellBorder(this, i, j);
                        CellValue(this, i, j);
                    }
                }
        }
           }
}
