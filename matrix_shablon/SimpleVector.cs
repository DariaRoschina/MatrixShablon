using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace matrix_shablon
{
  public   class SimpleVector:IVector

    {
      int[] a;
      
      public SimpleVector(int size)
      { 
      a = new int[size];
      }


      public int this[int param]
      {
          get
          {
            return a[param];
              
          }
          set
          {
              a[param]=value;
          }
      }

      public int size
      {
          get { return size; }
      }
    }
}
