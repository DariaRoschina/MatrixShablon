using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace matrix_shablon
{
    public class DisperseVector:IVector
    {
        Dictionary<int, int> vector;
       // int size;
        public DisperseVector(int size)
        {
            vector = new Dictionary<int, int>();
           // this.size = size;
            }
        public int this[int param]
        {
            get
            {
                if (vector.ContainsKey(param))
                    return vector[param];
                else
                    return 0;
                
            }
            set
            {
                vector[param]=value;
            }
        }

        public int size
        {
            get { return size; }
        }
    }
}
