import java.util.List;
import java.util.stream.IntStream;

class DifferenceOfSquaresCalculator {

    int computeSquareOfSumTo(int input) {
        return square(naturalNumbers(input).stream().sum());

    }

    int computeSumOfSquaresTo(int input) {
        return naturalNumbers(input).stream().map(square).sum();
    }

    int computeDifferenceOfSquares(int input) {
        return computeSquareOfSumTo(input) - computeSumOfSquaresTo(input);
    }

    private static List<Integer> naturalNumbers(int input) {
        return IntStream.rangeClosed(1, input).toArray();
    }

    private static int square(int input) {
        return input * input;
    }
}
