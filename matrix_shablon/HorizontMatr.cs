using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
namespace matrix_shablon
{
  public  class HorizontMatr:IMatrix, IDrawer
    {
      IDrawer drawer;
      List<IMatrix> matrixs = new List<IMatrix>();

      public void addMatr(IMatrix m)
      {
          matrixs.Add(m);
      }

    

        public int this[int row, int col]
        {
            get
            {
                int t = col;
                for (int i = 0; i < matrixs.Count; i++)
                {
                    {
                        if (matrixs[i].col_num <= t)
                        { t -= matrixs[i].col_num; }
                        else
                        {
                            if (matrixs[i].row_num < row) break;
                            return matrixs[i][row, t];
                        }
                    }
                }
                return 0;
            }
            set
            {
                int t = col;
                for (int i = 0; i < matrixs.Count; i++)
                {
                    if (matrixs[i].col_num <= t)
                    { t -=  matrixs[i].col_num; }
                    else
                    {
                        if (matrixs[i].row_num < row) break;
                        matrixs[i][row, t] = value;
                    }
                }

            }
            }

        public int col_num
        {
            get
            {
                int sum = 0;

                //for (int i = 0; i < matrixs.Count; i++)
                //{
                //    sum +=  matrixs[i].col_num;
                //}
                foreach (IMatrix i in matrixs)
                {
                    sum = sum + i.col_num;
                }

                return sum;
            }
        }


        public int row_num
        {
            get
            {

                int max = 0;
                //for (int i = 0; i < matrixs.Count; i++)
                // {
                //  if (matrixs[i].row_num > max)
                //  { max = matrixs[i].row_num; }
                //}
                foreach (IMatrix i in matrixs)
                {
                    if (i.row_num > max)
                    {
                        max = i.row_num;
                    }
                }

                return max;
            }
        }

        public void draw()
        {
            //for (int i = 0; i < matrixs.Count; i++)
            //{
            //    matrixs[i].draw();
            //}
            foreach (IMatrix i in matrixs)
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
            drawer.CellBorder(this, row, getColumn(m, col));
        }

        public void CellValue(IMatrix m, int row, int col)
        {
            drawer.CellValue(this, row, getColumn(m, col));
        }

        private int getColumn(IMatrix m, int col)
        {
            int itemIndex = matrixs.IndexOf(m);
            int sum = 0;
            for (int i = 0; i < itemIndex; i++) sum += matrixs[i].col_num;
            return sum + col;
        }
    }
}
