using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvC_1_Demo
{
    internal class Helper<T> where T : class, IComparable<T>, ICloneable, new()
    {
        // T Must be class or struct and implementation the built in interface 



        #region Before Generics
        //public static void SWAP(ref int x, ref int y)
        //{
        //    Console.WriteLine("After Swap");
        //    int Temp = x;
        //    x = y;
        //    y = Temp;
        //}
        //public static void SWAP(ref double x, ref double y)
        //{
        //    Console.WriteLine("After Swap");
        //    double Temp = x;
        //    x = y;
        //    y = Temp;
        //}
        //public static void SWAP(ref Point x, ref Point y)
        //{
        //    Point Temp = x;
        //    x = y;
        //    y = Temp;
        //} 
        #endregion
        #region After Generics
        public static void SWAP<T>(ref T x, ref T y)
        {
            T Temp = x;
            x = y;
            y = Temp;
        }

        //Compiler can detect the type of "T" based on thr typr of "Methods Input parameters"
        //Incase generic type T is not declared on method level not [class-struct-interface] level
        #endregion
        public static int SearchArray(T[] Arr, T Value)
        {
            if (Arr is not null)
            {
                for (int i = 0; i < Arr.Length; i++)
                {
                    if (Value.Equals(Arr[i]))
                    {
                        return i;
                    }
                }
            }
            return -1;
        }

        public static void BubbleSort(int[] Arr)
        {
            if (Arr is not null)
            {
                for (int i = 0; i < Arr.Length; i++)
                {
                    for (int j = 0; j < Arr.Length - i - 1; j++)
                    {
                        if (Arr[j].CompareTo(Arr[j + 1]) == 1)
                        {
                           SWAP(ref Arr[j], ref Arr[j + 1]);
                        }
                    }

                }
            }
        }
    }
}
