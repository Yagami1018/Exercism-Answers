import java.util.ArrayList;
import java.util.List;
import java.util.stream.Collectors;
import java.util.stream.IntStream;

class DifferenceOfSquaresCalculator {

    int computeSquareOfSumTo(int input) {
        return square(naturalNumbers(input).stream().reduce(0, (acc, next) -> acc + next));

    }

    int computeSumOfSquaresTo(int input) {
        return naturalNumbers(input).stream().map(i -> i * i).reduce(0, (acc, next) -> acc + next);
    }

    int computeDifferenceOfSquares(int input) {
        return computeSquareOfSumTo(input) - computeSumOfSquaresTo(input);
    }

    private static List<Integer> naturalNumbers(int input) {
        return IntStream.rangeClosed(1, input).boxed().toList();
    }

    private static int square(int input) {
        return input * input;
    }
}
