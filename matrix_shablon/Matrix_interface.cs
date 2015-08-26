using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace matrix_shablon
{
    //class Matrix_interface
    //{
        public interface IMatrix
        {
             int this[int row, int col] //чтение и запись значений элементов матрицы
            {
            get;
            set;
            }
            //свойства только для чтения ЧИСЛО_СТРОК и ЧИСЛО_СТОЛБЦОВ
             int col_num 
            {
                get ;  //чтение
                
            }
             int row_num
            {
                get ;  //чтение
                            }
             void draw();
             void setDrawer(IDrawer d);
             IMatrix GetComponent();
        }

    //}
}
