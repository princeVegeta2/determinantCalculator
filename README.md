# Determinant calculator
This **Windows Forms** application created with .NET and written in C# has a simple interface which allows the user to quickly calculate the determinant of any square matrix.

## Prerequisites
- .NET
- MathNet.Numerics

## Usage
- Launch the app
- In the first textbox write the amount of **rows**, in the second box write the amount of **columns** and click **Generate**. The dimensions must be that of a *square* matrix (rows == columns).
- In the generated table, write down the values of the matrix
- Click calculate
- A message box will appear stating the Determinant of the matrix

## MatrixClass.cs
- This class uses MathNet.Numerics, specifically MathNet.Numerics.LinearAlgebra to create a matrix and calculate the determinant using the [**LU** decomposition](https://en.wikipedia.org/wiki/LU_decomposition).

## Note
Use this software however you like.