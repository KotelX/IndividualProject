using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject
{
    class MyArray
    {
        private int[] Arr { get; set; }

        public int Size { get; private set; }

        public MyArray(int size)
        {
            if (size < 0) size = 0;
            Arr = new int[size];
            Size = size;
            var random = new Random();
            for (int i = 0; i < size; i++)
            {
                Arr[i] = random.Next(-100, 100);
            }
        }

        public int this [int index]
        {
            get
            {
                if (index < 0 || index >= Arr.Length) throw new Exception("Индекс находится за пределы масива!");
                return Arr[index];
            }
            set
            {
                if (index < 0 || index >= Arr.Length) throw new Exception("Индекс находится за пределы масива!");
                Arr[index] = value;
            }
        }

        public static MyArray operator + (MyArray left, MyArray right)
        {
            if (left.Arr.Length != right.Arr.Length) throw new Exception("");
            for (int i = 0; i < left.Arr.Length; i++)
            {
               left.Arr[i] += right.Arr[i];
            }
            return left;
        }

        public static MyArray operator - (MyArray left, MyArray right)
        {
            if (left.Arr.Length != right.Arr.Length) throw new Exception("");
            for (int i = 0; i < left.Arr.Length; i++)
            {
                left.Arr[i] -= right.Arr[i];
            }
            return left;
        }

        public static MyArray operator *(MyArray left, int value)
        {
            for (int i = 0; i < left.Arr.Length; i++)
            {
                left.Arr[i] *= value;
            }
            return left;
        }

        public static MyArray operator /(MyArray left, int value)
        {
            for (int i = 0; i < left.Arr.Length; i++)
            {
                left.Arr[i] /= value;
            }
            return left;
        }

    }
}
