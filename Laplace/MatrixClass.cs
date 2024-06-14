using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.LinearAlgebra;

namespace Laplace
{
    internal class MatrixClass
    {
        // Mathnet.Numerics matrix
        public Matrix<double> Matrix { get; private set; }

        // Constructor
        public MatrixClass(int rows, int columns)
        {
            Matrix = Matrix<double>.Build.Dense(rows, columns);
        }

        /// <summary>
        /// Populates the matrix with values
        /// </summary>
        /// <param name="row"></param>
        /// <param name="column"></param>
        /// <param name="value"></param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public void SetElement(int row, int column, double value)
        {
            if (row >= 0 && row < Matrix.RowCount && column >= 0 && column < Matrix.ColumnCount)
            {
                Matrix[row, column] = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Invalid matrix indices.");
            }
        }

        /// <summary>
        /// Returns the values of the matrix
        /// </summary>
        /// <param name="row"></param>
        /// <param name="column"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public double GetElement(int row, int column)
        {
            if (row >= 0 && row < Matrix.RowCount && column >= 0 && column < Matrix.ColumnCount)
            {
                return Matrix[row, column];
            }
            else
            {
                throw new ArgumentOutOfRangeException("Invalid matrix indices.");
            }
        }

        /// <summary>
        /// Debugging method
        /// </summary>
        public void PrintMatrix()
        {
            Debug.WriteLine(Matrix.ToString());
        }

        /// <summary>
        /// Calculating the determinant by using Matrix.LU method
        /// </summary>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        public double CalculateDeterminant()
        {
            if (Matrix.RowCount != Matrix.ColumnCount)
            {
                throw new InvalidOperationException("Determinant can only be calculated for square matrices.");
            }

            var lu = Matrix.LU();
            return lu.Determinant;
        }
    }

}

