class CollatzConjecture {
  int steps(int number) {
    if (number < 1) {
      throw ArgumentError('Only positive numbers are allowed');
    }

    int step = 0;

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
