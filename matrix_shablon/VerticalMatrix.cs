using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
namespace matrix_shablon
{
    public class VerticalMatrix : IMatrix, IDrawer
   {
       IDrawer drawer;
       List<IMatrix> matrixs2 = new List<IMatrix>();

       public void addMatr(IMatrix m)
       {
           matrixs2.Add(m);
       }

       public int this[int row, int col]
       {
           get
           {
               int tmp = row;
               for (int i = 0; i < matrixs2.Count; i++)
               {
                   {
                       if (matrixs2[i].row_num <= tmp)
                       { tmp -= matrixs2[i].row_num; }
                       else
                       {
                           if (matrixs2[i].col_num < col) break;
                           return matrixs2[i][tmp, col];
                       }
                   }
               }
               return 0;
           }
           set
           {
               int tmp = row;
               for (int i = 0; i < matrixs2.Count; i++)
               {
                   {
                       if (matrixs2[i].row_num <= tmp)
                       { tmp -= matrixs2[i].row_num; }
                       else
                       {
                           if (matrixs2[i].col_num < col) break;
                                 matrixs2[i][tmp, col]=value;
                       }
                   }
               }

           }
       }

      
       public int col_num
       {
           get
           {

               int max = 0;
               //for (int i = 0; i < matrixs.Count; i++)
               // {
               //  if (matrixs[i].row_num > max)
               //  { max = matrixs[i].row_num; }
               //}
               foreach (IMatrix i in matrixs2)
               {
                   if (i.col_num > max)
                   {
                       max = i.col_num;
                   }
               }

               return max;
           }
       }


       public int row_num
       {
           get
           {
               int sum = 0;

               //for (int i = 0; i < matrixs.Count; i++)
               //{
               //    sum +=  matrixs[i].col_num;
               //}
               foreach (IMatrix i in matrixs2)
               {
                   sum = sum + i.row_num;
               }

               return sum;
           }
       }
       public void draw()
       {
           //for (int i = 0; i < matrixs.Count; i++)
           //{
           //    matrixs[i].draw();
           //}
           foreach (IMatrix i in matrixs2)
           {
               i.setDrawer(this);
               i.draw();
           }
       }

       public void setDrawer(IDrawer d)
       {
           this.drawer = d;

       }

       public IMatrix GetComponent()
       {
           throw new NotImplementedException();
       }

       public void Border(IMatrix m)
       {
           drawer.Border(this);
       }

       public void CellBorder(IMatrix m, int row, int col)
       {
           drawer.CellBorder(this, getRow(m, row),col );
       }

       public void CellValue(IMatrix m, int row, int col)
       {
           drawer.CellValue(this, getRow(m, row), col);
       }

       private int getRow(IMatrix m, int row)
       {
           int itemIndex = matrixs2.IndexOf(m);
           int sum = 0;
           for (int i = 0; i < itemIndex; i++) sum += matrixs2[i].row_num;
           return sum + row;
       }
    }
}
