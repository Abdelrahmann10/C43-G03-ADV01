using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AdvC_1_Demo
{
    internal class Point:IComparable<Point>
    {
        public int x {  get; set; }
        public int y { get; set; }

        public Point(int _x, int _Y) 
        {
            x = _x;
            y = _Y;
        }
        public override string ToString()
        {
            return $"X = {x} , Y = {y}";
        }

        public int CompareTo(object? obj)
        {
            Point? other = (Point?)obj; //Explicit casting "unsafe"
            #region Is Operator For Casting
            // 1- is conditional operator : returns true in 3 cases
            // 2- obj is object of type "Point"
            // 3- obj is object of another type inheriting from "Point"
            // 4- obj is null
            //if (obj is Point other02)
            //{
            //    if (other02 is null) return 1;
            //    if (this.x == other02.x)
            //        return this.y.CompareTo(other02.y);
            //    else
            //        return this.x.CompareTo(other02.x);
            //}
            //return -1;
            #endregion

            #region As Operator
            // As casting operator
            // casting will succed if and only if obj is Point
            // if casting fails, will return null, no exception will be thrown

            Point? other03 = obj as Point;
            if (other03 is null) return 1;
            if (this.x == other03.x)
                return this.y.CompareTo(other03.y);
            else
            {
                return this.x.CompareTo(other03.x);
            } 
        }
            #endregion

        public int CompareTo(Point? other)
        {
            if (other == null) return 1;
            if (other.GetType() == typeof(Point))
            {
                if (this.x == other.x)
                    return this.y.CompareTo(other.y);
                else
                {
                    return this.CompareTo(other.x);
                }
            }
            else
                return 1;

        }
        
        
    }
}
