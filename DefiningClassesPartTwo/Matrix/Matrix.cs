using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Define a class Matrix<T> to hold a matrix of numbers (e.g. integers, floats, decimals). 
//Implement an indexer this[row, col] to access the inner matrix cells.
//Implement the operators + and - (addition and subtraction of matrices of the same size) and * for matrix multiplication. Throw an exception when the operation cannot be performed. Implement the true operator (check for non-zero elements).


namespace Matrix
{
    class Matrix<T>
        where T : struct, IEnumerator<T>
    {
        private T[,] matrice;
        private int row;
        private int col;

        public int Row
        {
            get { return this.row; }
        }
        public int Col
        {
            get { return this.col; }
        }

        public Matrix(int row, int col)
        {
            this.matrice = new T[row, col];
            this.row = row;
            this.col = col;
        }

        public T this[int row, int col]
        {
            get 
            {
                if (row >= this.row || row < 0 || col >= this.col || col < 0)
                {
                    throw new IndexOutOfRangeException("Invalid dimensions for the matrix!");
                }
                else
                {
                    return matrice[row, col];
                }
            }
            set 
            {
                if (row >= this.row || row < 0 || col >= this.col || col < 0)
                {
                    throw new IndexOutOfRangeException("Invalid dimensions for the matrix!");
                }
                else
                {
                    matrice[row, col] = value;
                }
            }
        }
        public static Matrix<T> operator +(Matrix<T> matrice1, Matrix<T> matrice2)
        {
            if (matrice1.Col == matrice2.Col && matrice1.Row == matrice2.Row)
            {
                Matrix<T> newMatrice = new Matrix<T>(matrice1.Row, matrice1.Col);
                for (int i = 0; i < matrice1.Row; i++)
                {
                    for (int j = 0; j < matrice1.Col; j++)
                    {
                        newMatrice[i, j] = (dynamic)matrice1[i, j] + (dynamic)matrice2[i, j];
                    }
                }
                return newMatrice;
            }
            else
            {
                throw new InvalidOperationException("Invalid number of rows and columbs!");
            }
        }
        public static Matrix<T> operator -(Matrix<T> matrice1, Matrix<T> matrice2)
        {
            if (matrice1.Col == matrice2.Col && matrice1.Row == matrice2.Row)
            {
                Matrix<T> newMatrice = new Matrix<T>(matrice1.Row, matrice1.Col);
                for (int i = 0; i < matrice1.Row; i++)
                {
                    for (int j = 0; j < matrice1.Col; j++)
                    {
                        newMatrice[i, j] = (dynamic)matrice1[i, j] - (dynamic)matrice2[i, j];
                    }
                }
                return newMatrice;
            }
            else
            {
                throw new InvalidOperationException("Invalid number of rows and columbs!");
            }
        }
        public static Matrix<T> operator *(Matrix<T> matrice1, Matrix<T> matrice2)
        {
            if (matrice1.Col == matrice2.Row)
            {
                Matrix<T> newMatrice = new Matrix<T>(matrice1.Row, matrice2.Col);
                for (int i = 0; i < newMatrice.Row; i++)
                {
                    for (int j = 0; j < newMatrice.col; j++)
                    {
                        newMatrice[i,j] = (dynamic)0;
                        for (int k = 0; k < matrice1.Col; k++)
                        {
                            newMatrice[i, j] = newMatrice[i, j] + (dynamic)matrice1[i, k] * matrice2[k, j];                       
                        }
                    }   
                }
                return newMatrice;
            }
            else
            {
                throw new InvalidOperationException("Invalid number of rows and columbs!");
            }
        }
        public static bool operator true(Matrix<T> matrice)
        {
            foreach (var item in matrice.matrice)
            {
                if (!item.Equals(null) && !item.Equals(default(T)))
                {
                    return true;
                }
            }
            return false;
        }
    }
}

