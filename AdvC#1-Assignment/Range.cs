using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvC_1
{
    internal class Range<T> where T : IComparable<T>
    {

        public T MinValue { get; set; }
        public T MaxValue { get; set; }

        public Range(T minimum, T maximum)
        {
            if (minimum.CompareTo(maximum) > 0)
            {
                Console.WriteLine(" Minimum value must be less than or equal to maximum value ");
            }

            MinValue = minimum;
            MaxValue = maximum;
        }

        public bool IsInRange(T value)
        {
            return (value.CompareTo(MinValue) >= 0) && (value.CompareTo(MaxValue) <= 0);
        }

        public dynamic Length()
        {
            dynamic minValue = MinValue;
            dynamic maxValue = MaxValue;
            return maxValue - minValue;
        }

    }
}
