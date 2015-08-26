using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace matrix_shablon
{
  public  class HideDecorator: IMatrix, IDrawer
    {
        private IMatrix matrComp;
        private IDrawer drawer;
   
        int r, c;
        public HideDecorator(IMatrix m, int r, int c)
        {
            matrComp = m;
            this.r = r;
            this.c = c;
            
        }

        public int this[int row, int col]
        {
            get
            {
                return matrComp[row, col];
            }
            set
            {
                matrComp[row, col] = value;
            }
        }

        public int col_num
        {
            get { return matrComp.col_num - 1; }
        }

        public int row_num
        {
            get { return matrComp.row_num - 1; }
        }
        public   void draw()
        {
            matrComp.setDrawer(this);
            matrComp.draw();
        }

        public void setDrawer(IDrawer d)
        {
            this.drawer = d;
        }

        public void Border(IMatrix m)
        {
            if (matrComp.col_num == matrComp.col_num - 1 && matrComp.row_num == matrComp.row_num - 1)
            {
          drawer.Border(this);
            }
        }

        public void CellBorder(IMatrix m, int row, int col)
        {
              if (row == r || col == c) { }
                    else { 
           
                drawer.CellBorder(this, row, col);
            }
                   
        }

        public void CellValue(IMatrix m, int row, int col)
        {
            if (row == r || col == c) { }
                   else { 
            
                drawer.CellValue(this, row, col);
            }
                    
                }
      

        public IMatrix GetComponent()
        {
            return matrComp.GetComponent();
        }
    }

       

       
   
}
