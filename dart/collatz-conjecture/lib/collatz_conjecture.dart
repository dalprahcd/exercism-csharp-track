/// Responsible for calculating the Collatz Conjecture number.
class CollatzConjecture {
  /// Returns the Collatz Conjecture step number for a given [number].
  int steps(int number) {
    if (number < 1) {
      throw ArgumentError('Only positive numbers are allowed');
    }

    var step = 0;

    while (number != 1) {
      if (number.isEven) {
        number ~/= 2;
      } else {
        number = (3 * number) + 1;
      }

      step++;
    }

    return step;
  }
}
