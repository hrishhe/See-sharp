public class SpiralMatrix
{
    public static int[,] GetMatrix(int size)
    {
        int[,] matrix = new int[size, size];
        int value = 1;
        int minRow = 0;
        int maxRow = size - 1;
        int minCol = 0;
        int maxCol = size - 1;

        while (value <= size * size)
        {
            for (int i = minCol; i <= maxCol; i++)
            {
                matrix[minRow, i] = value++;
            }
            minRow++;


            for (int i = minRow; i <= maxRow; i++)
            {
                matrix[i, maxCol] = value++;
            }
            maxCol--;

            for (int i = maxCol; i >= minCol; i--)
            {
                matrix[maxRow, i] = value++;
            }
            maxRow--;

            for (int i = maxRow; i >= minRow; i--)
            {
                matrix[i, minCol] = value++;
            }
            minCol++;
        }

        return matrix;
        

        
    }
}
