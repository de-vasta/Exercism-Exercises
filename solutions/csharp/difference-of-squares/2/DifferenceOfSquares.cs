using System;
using System.Linq;

public static class DifferenceOfSquares
{
    public static int CalculateSquareOfSum(int max) => Square(Enumerable.Range(1, max).Sum());

    public static int CalculateSumOfSquares(int max) => Enumerable.Range(1, max).Sum(num => num * num);

    public static int CalculateDifferenceOfSquares(int max) => CalculateSquareOfSum(max) - CalculateSumOfSquares(max);

    private static int Square(int num) => num * num;
}