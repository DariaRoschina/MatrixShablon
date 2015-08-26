using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
namespace matrix_shablon
{
    public abstract  class ASomeMatrix : IMatrix
    {
        List<IVector> array;
        int rows, cols;
        IDrawer d;
        public ASomeMatrix(int rows, int cols)
        {
            this.cols = cols;
            this.rows = rows;
            array = new List<IVector>();
            for (int i=0;i< rows ; i++)
            {
            array.Add(function(cols) );

            }
            }

        protected abstract IVector function(int size);
        public int this[int row, int col]
        {
            get
            {
                return array[row][col];
            }
            set
            {
                array[row][col] = value;
            }
        }
        public void Border(IMatrix m)
        {
            d.Border(this);
          
        }
          

       public void CellBorder(IMatrix m, int row, int col)
         {
             d.CellBorder(this,row,col);
            }
       
        public   void CellValue(IMatrix m, int row, int col)
         {
             d.CellValue(this, row, col);
            
            }

        public void setDrawer(IDrawer drawer)
        {
            if (drawer != null)
                d = drawer;
        
            }

       

        public int col_num
        {
            get { return cols; }
        }

        public int row_num
        {
            get { return rows; }
        }
        public abstract void draw();
        public IMatrix GetComponent()
        {
            return this;
        }
    }
}
