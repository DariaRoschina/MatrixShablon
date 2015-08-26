using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace matrix_shablon
{
    public class SimpleMatrix:ASomeMatrix
    {
        public SimpleMatrix(int rows, int cols):base(rows,cols) {
            }

        protected override IVector function(int size)
        {
            return new SimpleVector(size);
        }

        public override void draw()
        {
            Border(this);
            for (int i = 0; i < this.row_num; i++)
                for (int j = 0; j < this.col_num;j++ )
                { 
                CellBorder(this,i,j);
                CellValue(this, i,j);
                    }
        }
    }
}
