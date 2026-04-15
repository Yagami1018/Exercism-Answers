public static class DifferenceOfSquares
{
    public static int CalculateSquareOfSum(int max)
    {
        int[] sequence = [.. from n in Enumerable.Range(1,max) select n];
        int sum = sequence.Aggregate(0,(acc,next)=>acc+next);
        return sum*sum; 
    }

    public static int CalculateSumOfSquares(int max)
    {
        int[] sequence = [.. from n in Enumerable.Range(1,max) select n*n];
        int sum = sequence.Aggregate(0,(acc,next)=>acc+next);
        return sum;
    }

    public static int CalculateDifferenceOfSquares(int max) => CalculateSquareOfSum(max) - CalculateSumOfSquares(max);
}