using ExcelDna.Integration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace daHelper
{
    public static class ArrayExt
    {
        public static T[] GetColumn<T>(T[,] matrix, int columnNumber)
        {
            return Enumerable.Range(0, matrix.GetLength(0))
                    .Select(x => matrix[x, columnNumber])
                    .ToArray();
        }

        public static T[] GetRow<T>(T[,] matrix, int rowNumber)
        {
            return Enumerable.Range(0, matrix.GetLength(1))
                    .Select(x => matrix[rowNumber, x])
                    .ToArray();
        }

        public static string[] CastArrayString(object[] data)
        {
            string[] new_data = new string[data.Length];
            for (int i = 0; i < data.Length; i++)
            {
                if (Marshal<object>.Missing(data[i]))
                {
                    new_data[i] = default;
                }
                else
                {
                    new_data[i] = data[i].ToString();
                }
            }
            return new_data;
        }

        public static string[,] CastMatrixString(object[,] data)
        {
            int row = data.GetUpperBound(0) + 1;
            int col = data.GetUpperBound(1) + 1;

            string[,] new_data = new string[row,col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (Marshal<object>.Missing(data[i,j]))
                    {
                        new_data[i, j] = default;
                    }
                    else
                    {
                        new_data[i, j] = data[i, j].ToString();
                    }
                }
            }
            return new_data;
        }

    }

    public static class Marshal<T>
    {
        public static bool Missing(T data)
        {
            return (data is ExcelEmpty) || (data is ExcelMissing);
        }
    }
}
