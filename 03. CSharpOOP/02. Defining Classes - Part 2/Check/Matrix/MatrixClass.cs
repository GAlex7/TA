namespace Check.Matrix
{
    using System;
    using System.Collections;
    using System.Globalization;
    [Version(1, 1)]
    public class Matrix<T>
        where T : IConvertible, IEquatable<T>
    {
        private T[,] matrixElems;

        public Matrix(int r, int c)
        {
            this.matrixElems = new T[r, c];
        }

        public T this[int row, int col]
        {
            get
            {
                return this.matrixElems[row, col];
            }
            set
            {
                this.matrixElems[row, col] = value;
            }
        }

        public int GetLength(int level)
        {
            return this.matrixElems.GetLength(level);
        }

        public T[,] MatrixElems
        {
            get
            {
                return this.matrixElems;
            }
            set
            {
                this.matrixElems = value;
            }
        }

        public static Matrix<T> operator +(Matrix<T> a, Matrix<T> b)
        {
            int row = a.GetLength(0);
            int col = a.GetLength(1);
            var type = typeof(T);
            var result = new Matrix<T>(row, col);
            if (type == typeof(String) || type == typeof(DateTime))
                throw new ArgumentException(String.Format("The type {0} is not supported", type.FullName), "T");
            if (b.GetLength(0) != row || b.GetLength(1) != col)
            {
                throw new ArithmeticException("The matrices must be the same dimension.");
            }
            try
            {

                for (int r = 0; r < row; r++)
                {
                    for (int c = 0; c < col; c++)
                    {
                        result[r, c] = (T)Convert.ChangeType(double.Parse(a[r, c].ToString()) + double.Parse(b[r, c].ToString()), type);
                    }
                }
            }
            catch (Exception ex) { throw new ApplicationException("The operation failed.", ex); }
            return result;
        }

        public static Matrix<T> operator -(Matrix<T> a, Matrix<T> b)
        {
            int row = a.GetLength(0);
            int col = a.GetLength(1);
            var type = typeof(T);
            var result = new Matrix<T>(row, col);
            if (type == typeof(String) || type == typeof(DateTime))
                throw new ArgumentException(String.Format("The type {0} is not supported", type.FullName), "T");
            if (b.GetLength(0) != row || b.GetLength(1) != col)
            {
                throw new ArithmeticException("The matrices must be the same dimension.");
            }
            try
            {

                for (int r = 0; r < row; r++)
                {
                    for (int c = 0; c < col; c++)
                    {
                        result[r, c] = (T)Convert.ChangeType(double.Parse(a[r, c].ToString()) - double.Parse(b[r, c].ToString()), type);
                    }
                }
            }
            catch (Exception ex) { throw new ApplicationException("The operation failed.", ex); }
            return result;
        }

        public static Matrix<T> operator *(Matrix<T> a, Matrix<T> b)
        {
            int rowA = a.GetLength(0);
            int colA = a.GetLength(1);
            int rowB = b.GetLength(0);
            int colB = b.GetLength(1);
            double temp = 0;

            var type = typeof(T);
            var result = new Matrix<T>(rowA, colB);
            if (type == typeof(String) || type == typeof(DateTime))
                throw new ArgumentException(String.Format("The type {0} is not supported", type.FullName), "T");
            if (rowA != colB)
            {
                throw new ArithmeticException("The matrices can't be multiplied.");
            }
            try
            {

                for (int r = 0; r < rowA; r++)
                {
                    for (int c = 0; c < colB; c++)
                    {
                        for (int k = 0; k < colA; k++)
                        {
                            temp += double.Parse(a[r, k].ToString()) * double.Parse(b[k, c].ToString());
                        }
                        result[r, c] = (T)Convert.ChangeType(temp, type);
                        temp = 0;
                    }
                }
            }
            catch (Exception ex) { throw new ApplicationException("The operation failed.", ex); }
            return result;
        }

        public static bool operator true(Matrix<T> matrix)
        {
            bool result = true;
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    if (double.Parse(matrix[r, c].ToString()) == 0)
                    {
                        result = false;
                        break;
                    }
                }
            }
            return result;
        }

        public static bool operator false(Matrix<T> matrix)
        {
            bool result = true;
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    if (double.Parse(matrix[r, c].ToString()) == 0)
                    {
                        result = false;
                        break;
                    }
                }
            }
            return !result;
        }
    }
}