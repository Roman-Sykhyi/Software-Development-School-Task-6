using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Задача_6._3
{
    public class Matrix <T> : IEnumerable
    {
        public T[,] value;
        private int rows, columns;

        public Matrix(int m, int n)
        {
            value = new T[m, n];
            rows = m;
            columns = n;
        }

        public MatrixEnum<T> GetEnumerator()
        {
            return new MatrixEnum<T>(value, rows, columns);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator) GetEnumerator();
        }
    }

    public class MatrixEnum<T> : IEnumerator
    {
        private T[,] value;
        private int rows, columns;
        int positionI, positionJ;

        public MatrixEnum(T[,] arr, int m, int n)
        {
            value = arr;
            rows = m;
            columns = n;

            positionI = rows - 1;
            positionJ = columns;
        }

        public bool MoveNext()
        {
            positionJ--;

            if (positionJ < 0)
            {
                positionI--;
                positionJ = columns - 1;
            }

            return (positionI >= 0 && positionJ >= 0);
        }

        public void Reset()
        {
            positionI = rows - 1;
            positionJ = columns;
        }

        public T Current
        {
            get
            {
                try
                {
                    return value[positionI, positionJ];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

        object IEnumerator.Current => Current;
    }
}
