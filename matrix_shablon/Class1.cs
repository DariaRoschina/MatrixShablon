using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace matrix_shablon
{
  public  class RecordValue
    {
      IMatrix matr1, matr2;
      IDrawer dr1, dr2;

      public RecordValue(IMatrix matr1, IMatrix matr2, IDrawer dr1, IDrawer dr2)
      {
          this.matr1 = matr1;
          this.matr2 = matr2;
          this.dr1 = dr1;
          this.dr2 = dr2;
               }

    public  void record()
      {
          Random x = new Random();
          Random y = new Random();
          Random znach = new Random();
          int   i = x.Next(matr1.row_num);
          int  j = y.Next(matr1.col_num);
          int z = znach.Next(20);
          matr1[i, j] = z;                         
          int  l = x.Next(matr2.row_num);
          int  m = y.Next(matr2.col_num);
          int zh = znach.Next(20);
          matr2[i, j] = zh;
          matr1.GetComponent();
          matr1.setDrawer(dr1);
          matr1.draw();
          matr2.GetComponent();
          matr2.setDrawer(dr2);
          matr2.draw();
      }


    }
}
