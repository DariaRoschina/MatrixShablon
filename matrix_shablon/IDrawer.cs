using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace matrix_shablon
{
    public interface IDrawer
    {
        void Border(IMatrix m);
        void CellBorder(IMatrix m,int row,int col);
        void CellValue(IMatrix m,int row,int col);
        
    }
}
