using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace matrix_shablon
{
   public class IniciatorMatrix
    {
        //IMatrix m;

        static public void fullMatrix(IMatrix m,int notnull, int max) // так заполняется пока , но это неправильно, так как будет заполняться первые элементы
        {
            Random r = new Random();

            for (int k = 0; k < notnull; k++)
            {
                int i = r.Next(m.row_num);
                int j = r.Next(m.col_num);
                if (m[i, j] == 0)
                {
                    m[i, j] = r.Next(max) + 1;
                }
                else
                {
                    i--;
                }
            }      
            }
        
        }
    }

