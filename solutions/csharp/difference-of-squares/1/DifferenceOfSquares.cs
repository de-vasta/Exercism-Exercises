using System;

public static class DifferenceOfSquares
{
    public static int CalculateSquareOfSum(int max)
    {
        int sum = 1;
        for (int num = 2; num <= max; num++)
        {
            sum += num;
        }

        return sum * sum;
    }

    public static int CalculateSumOfSquares(int max)
    {
        int squareOfSum = 1;
        for (int num = 2; num <= max; num++)
        {
            squareOfSum += num * num;
        }
        return squareOfSum;
    }

    public static int CalculateDifferenceOfSquares(int max) => CalculateSquareOfSum(max) - CalculateSumOfSquares(max);
}