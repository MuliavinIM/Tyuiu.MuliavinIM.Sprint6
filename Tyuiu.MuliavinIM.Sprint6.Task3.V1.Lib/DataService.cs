using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MuliavinIM.Sprint6.Task3.V1.Lib
{
    public class DataService : ISprint6Task3V1
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.GetUpperBound(1) + 1;
            int numCol = 0;
            for (int numRow = 0; numRow < rows - 1; numRow++)
            {
                int minRow = numRow;
                for (int j = numRow + 1; j < rows; j++)
                {
                    if (matrix[j, numCol] < matrix[minRow, numCol])
                    {
                        minRow = j;
                    }
                }
                int temp = matrix[numRow, numCol];
                matrix[numRow, numCol] = matrix[minRow, numCol];
                matrix[minRow, numCol] = temp;
            }
            return matrix;
        }
    }
}