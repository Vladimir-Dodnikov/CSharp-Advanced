using System;
using System.Collections.Generic;
using System.Text;

namespace GenericSwapMethodIntegers
{
    public class Box<T>
    {
        private T value;

        public Box(T value)
        {
            this.value = value;
        }
        public static void SwapBoxes<T>(List<Box<T>> box, int firstIndex, int secondIndex)
        {
            var temp = box[firstIndex];
            box[firstIndex] = box[secondIndex];
            box[secondIndex] = temp;
        }

        public override string ToString()
        {
            return $"{value.GetType().FullName}: {value}";
        }
    }
}
