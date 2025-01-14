using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvC_1
{
    internal class Helper<T> where T : IComparable
    {

        static void SWAP<T>(ref T X, ref T Y)
        {
            T Temp = X;
            X = Y;
            Y = Temp;
        }

        public static void BubbleSort(T[] arr)
        {
            if (arr is not null)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr.Length - 1 - i; j++)
                    {
                        if (arr[j].CompareTo(arr[j + 1]) == 1)

                            SWAP<T>(ref arr[j], ref arr[j + 1]);
                    }
                }
            }
        }
    }
}
