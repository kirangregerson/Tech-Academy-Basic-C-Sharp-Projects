using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodDrill2
{
    public class Operator
    {
        public int Operation(int x)
        {
            return x * 2;
        }
        public int Operation(double x)
        {
            return (int)(x * (x + 10));
        }
        public int Operation(string x)
        {
            try
            {
                int y = Convert.ToInt32(x);
                return (y * y) / 3;
            }
            catch
            {
                return -1;
            }
        }
    }
}
