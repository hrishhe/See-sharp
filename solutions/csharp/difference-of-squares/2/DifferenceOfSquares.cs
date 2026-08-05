public static class DifferenceOfSquares
{
    public static int CalculateSquareOfSum(int max)
    {
        int n=max;
        int sum = (n * (n + 1)) / 2;

        return sum * sum;
    }

    public static int CalculateSumOfSquares(int max)
    {
        int n=max;
        return (n * (n + 1) * (2 * n + 1)) / 6;
    }
    public static int CalculateDifferenceOfSquares(int max)
    {
        return CalculateSquareOfSum(max) - CalculateSumOfSquares(max);
    }
}