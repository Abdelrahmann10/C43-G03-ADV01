using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvC_1_Demo
{
    internal class Point3D
    {
        public int Z {  get; set; }

        public Point3D(int _X, int _Y, int _Z) : base (_X, _Y)
        {
            Z = _Z;
        }
    }
}
