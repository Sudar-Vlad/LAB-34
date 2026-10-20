using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаб_43
{
    internal class Array2
    {
        public string Name = "Двовимірний масив";

        // Закритий масив.
        private readonly int[,] a;

        // Властивості.
        public int Rows
        {
            get { return a.GetLength(0); }
        }

        public int Columns
        {
            get { return a.GetLength(1); }
        }

        // Конструктор без параметрів.
        public Array2() : this(0, 0)
        {
        }

        // n та m — останні індекси.
        public Array2(int n, int m)
        {
            if (n < 0 || m < 0)
                throw new ArgumentException(
                    "N і M не можуть бути від'ємними.");

            a = new int[checked(n + 1), checked(m + 1)];
        }

        private void CheckIndices(int i, int j)
        {
            if (i < 0 || i >= Rows ||
                j < 0 || j >= Columns)
            {
                throw new IndexOutOfRangeException(
                    $"Рядок: 0..{Rows - 1}; " +
                    $"стовпець: 0..{Columns - 1}.");
            }
        }

        // Індексатор.
        public int this[int i, int j]
        {
            get
            {
                CheckIndices(i, j);
                return a[i, j];
            }

            set
            {
                CheckIndices(i, j);
                a[i, j] = value;
            }
        }

        public void FillRandom(Random random)
        {
            for (int i = 0; i < Rows; i++)
                for (int j = 0; j < Columns; j++)
                    a[i, j] = random.Next(-50, 51);
        }

        // Сума елементів рядка.
        public long RowSum(int row)
        {
            if (row < 0 || row >= Rows)
                throw new IndexOutOfRangeException(
                    "Неправильний індекс рядка.");

            long sum = 0;

            for (int j = 0; j < Columns; j++)
                sum += a[row, j];

            return sum;
        }

        // Пошук рядка з найбільшою сумою.
        public int FindMaxRow()
        {
            int maxRow = 0;
            long maxSum = RowSum(0);

            for (int i = 1; i < Rows; i++)
            {
                long sum = RowSum(i);

                if (sum > maxSum)
                {
                    maxSum = sum;
                    maxRow = i;
                }
            }

            return maxRow;
        }
    }
}
