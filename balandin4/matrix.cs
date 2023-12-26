using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace balandin4
{
    internal class Matrix<T>
    {
        private T[,] data;
        public int Rows { get; }
        public int Columns { get; }

        // Конструктор по умолчанию
        public Matrix(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
            data = new T[rows, columns];
        }

        // Конструктор копирования
        public Matrix(Matrix<T> other)
        {
            Rows = other.Rows;
            Columns = other.Columns;
            data = new T[Rows, Columns];
            Array.Copy(other.data, data, Rows * Columns);
        }

        // Оператор присваивания
        public void Assign(Matrix<T> other)
        {
            if (Rows != other.Rows || Columns != other.Columns)
            {
                throw new ArgumentException("Matrices must have the same dimensions for assignment");
            }

            Array.Copy(other.data, data, Rows * Columns);
        }

        // Оператор перемещения
        public void Move(Matrix<T> other)
        {
            if (Rows != other.Rows || Columns != other.Columns)
            {
                throw new ArgumentException("Matrices must have the same dimensions for movement");
            }

            Array.Copy(other.data, data, Rows * Columns);
            other.data = new T[Rows, Columns]; // Опционально: обнуляем матрицу other после перемещения
        }

        // Оператор индексации
        public T this[int row, int col]
        {
            get { return data[row, col]; }
            set { data[row, col] = value; }
        }

        // Оператор сложения
        public static Matrix<T> operator +(Matrix<T> a, Matrix<T> b)
        {
            if (a.Rows != b.Rows || a.Columns != b.Columns)
            {
                throw new ArgumentException("Matrices must have the same dimensions for addition");
            }

            Matrix<T> result = new Matrix<T>(a.Rows, a.Columns);
            for (int i = 0; i < a.Rows; i++)
            {
                for (int j = 0; j < a.Columns; j++)
                {
                    dynamic aValue = a[i, j];
                    dynamic bValue = b[i, j];
                    result[i, j] = aValue + bValue;
                }
            }
            return result;
        }



        // Оператор умножения на скаляр
        public static Matrix<T> operator *(Matrix<T> matrix, T scalar)
        {
            Matrix<T> result = new Matrix<T>(matrix.Rows, matrix.Columns);
            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Columns; j++)
                {
                    dynamic matrixValue = matrix[i, j];
                    result[i, j] = matrixValue * scalar;
                }
            }
            return result;
        }

        // Оператор умножения матриц
        public static Matrix<T> operator *(Matrix<T> a, Matrix<T> b)
        {
            if (a.Columns != b.Rows)
            {
                throw new ArgumentException("Number of columns in the first matrix must be equal to the number of rows in the second matrix");
            }

            Matrix<T> result = new Matrix<T>(a.Rows, b.Columns);
            for (int i = 0; i < a.Rows; i++)
            {
                for (int j = 0; j < b.Columns; j++)
                {
                    dynamic sum = new Polynomial();
                    for (int k = 0; k < a.Columns; k++)
                    {
                        dynamic aValue = a[i, k];
                        dynamic bValue = b[k, j];
                        sum = sum + aValue * bValue;
                    }
                    result[i, j] = sum;
                }
            }
            return result;
        }

        // Функция поиска детерминанта
        public dynamic Determinant()
        {
            if (Rows != Columns)
            {
                throw new InvalidOperationException("Determinant is defined only for square matrices");
            }

            if (Rows == 1)
            {
                return data[0, 0];
            }

            if (Rows == 2)
            {
                return Subtract(Multiply(data[0, 0], data[1, 1]), Multiply(data[0, 1], data[1, 0]));
            }

            dynamic det = 0;
            for (int i = 0; i < Columns; i++)
            {
                det += Multiply(data[0, i], Cofactor(0, i));
            }
            return det;
        }

        // Вспомогательная функция для вычисления алгебраического дополнения
        private dynamic Cofactor(int row, int col)
        {
            Matrix<T> minor = new Matrix<T>(Rows - 1, Columns - 1);
            for (int i = 0, r = 0; i < Rows; i++)
            {
                if (i == row)
                {
                    continue;
                }
                for (int j = 0, c = 0; j < Columns; j++)
                {
                    if (j == col)
                    {
                        continue;
                    }
                    minor[r, c] = data[i, j];
                    c++;
                }
                r++;
            }

            // Знак алгебраического дополнения зависит от суммы индексов строки и столбца
            return (row + col) % 2 == 0 ? minor.Determinant() : -minor.Determinant();
        }

        // Метод для транспонирования матрицы
        public Matrix<T> Transpose()
        {
            Matrix<T> result = new Matrix<T>(Columns, Rows);
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    result[j, i] = data[i, j];
                }
            }
            return result;
        }

        // Оператор вычитания
        public static Matrix<T> operator -(Matrix<T> a, Matrix<T> b)
        {
            if (a.Rows != b.Rows || a.Columns != b.Columns)
            {
                throw new ArgumentException("Matrices must have the same dimensions for subtraction");
            }

            Matrix<T> result = new Matrix<T>(a.Rows, a.Columns);
            for (int i = 0; i < a.Rows; i++)
            {
                for (int j = 0; j < a.Columns; j++)
                {
                    dynamic aValue = a[i, j];
                    dynamic bValue = b[i, j];
                    result[i, j] = aValue - bValue;
                }
            }
            return result;
        }

        // Метод нахождения обратной матрицы
        public Matrix<T> GetInverse()
        {
            if (Rows != Columns)
            {
                throw new InvalidOperationException("Inverse is defined only for square matrices");
            }

            int n = Rows;
            Matrix<T> augmentedMatrix = new Matrix<T>(n, 2 * n);

            // Создаем расширенную матрицу, где правая часть - единичная матрица
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    augmentedMatrix[i, j] = this[i, j];
                    augmentedMatrix[i, j + n] = (i == j) ? Add(default(T), (dynamic)1) : default(T);
                }
            }

            // Приводим расширенную матрицу к ступенчатому виду
            for (int i = 0; i < n; i++)
            {
                // Находим первый ненулевой элемент в столбце i
                int pivotRow = -1;
                for (int j = i; j < n; j++)
                {
                    if (!EqualityComparer<T>.Default.Equals(augmentedMatrix[j, i], default(T)))
                    {
                        pivotRow = j;
                        break;
                    }
                }

                // Если не найден, матрица необратима
                if (pivotRow == -1)
                {
                    throw new InvalidOperationException("Matrix is not invertible");
                }

                // Переставляем строку с ненулевым элементом на верх
                for (int j = 0; j < 2 * n; j++)
                {
                    T temp = augmentedMatrix[i, j];
                    augmentedMatrix[i, j] = augmentedMatrix[pivotRow, j];
                    augmentedMatrix[pivotRow, j] = temp;
                }

                // Приводим элемент на диагонали к единице
                T pivot = augmentedMatrix[i, i];
                for (int j = 0; j < 2 * n; j++)
                {
                    augmentedMatrix[i, j] = Divide(augmentedMatrix[i, j], pivot);
                }

                // Обнуляем остальные элементы в столбце
                for (int k = 0; k < n; k++)
                {
                    if (k != i)
                    {
                        T factor = Subtract(default(T), augmentedMatrix[k, i]);
                        for (int j = 0; j < 2 * n; j++)
                        {
                            augmentedMatrix[k, j] = Add(augmentedMatrix[k, j], Multiply(factor, augmentedMatrix[i, j]));
                        }
                    }
                }
            }

            // Извлекаем обратную матрицу из правой части расширенной матрицы
            Matrix<T> inverseMatrix = new Matrix<T>(n, n);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    inverseMatrix[i, j] = augmentedMatrix[i, j + n];
                }
            }

            return inverseMatrix;
        }
        private static T Divide(T a, T b)
        {
            if (EqualityComparer<T>.Default.Equals(b, default(T)))
            {
                throw new DivideByZeroException("Division by zero");
            }

            return (dynamic)a / b;
        }

        // Вспомогательные методы для работы с динамическими типами
        private static T Add(T a, T b) => (dynamic)a + b;
        private static T Subtract(T a, T b) => (dynamic)a - b;
        private static T Multiply(T a, T b) => (dynamic)a * b;
    }
}
