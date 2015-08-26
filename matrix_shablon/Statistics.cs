using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace matrix_shablon
{
  public  class Statistics
    {
      IMatrix m;
      public Statistics(IMatrix m) 
      {
          this.m = m;
      }
      public int max
      {
          get
          {
              int max = 0;
              for (int i = 0; i < m.row_num; i++)
                  for (int j = 0; j < m.col_num; j++)
                  {
                      if (m[i,j] >= max)

                      { max = m[i,j];}
                  }
              return max;}
      
      }

      public int notnull
      {
          get {
              int k = 0;
              for (int i = 0; i < m.row_num; i++)
                  for (int j = 0; j < m.col_num; j++)
                  {
                      if (m[i, j] != 0)

                      { k = k+1; }
                  }
              return k;}

        }



    }
}
