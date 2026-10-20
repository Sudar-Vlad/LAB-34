using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаб_43
{
    internal class Array1
    {
        public string Name = "Одновимірний масив";

        // Закритий масив.
        private int[] a;

        // Властивість.
        public int Length
        {
            get { return a.Length; }
        }

        // Конструктор без параметрів.
        public Array1() : this(0)
        {
        }

        // n — останній індекс.
        public Array1(int n)
        {
            if (n < 0)
                throw new ArgumentException(
                    "N не може бути від'ємним.");

            a = new int[checked(n + 1)];
        }

        private void CheckIndex(int i)
        {
            if (i < 0 || i >= Length)
            {
                throw new IndexOutOfRangeException(
                    $"Індекс має бути від 0 до {Length - 1}.");
            }
        }

        // Індексатор.
        public int this[int i]
        {
            get
            {
                CheckIndex(i);
                return a[i];
            }

            set
            {
                CheckIndex(i);
                a[i] = value;
            }
        }
        public void FillRandom(Random random)
        {
            for (int i = 0; i < Length; i++)
                a[i] = random.Next(-50, 51);
        }

        // Створення інверсного масиву.
        public Array1 GetReversed()
        {
            Array1 result = new Array1(Length - 1);

            for (int i = 0; i < Length; i++)
                result[i] = a[Length - 1 - i];

            return result;
        }
    }
}
