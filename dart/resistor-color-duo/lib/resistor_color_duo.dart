class ResistorColorDuo {
  final _colorMap = const {
    'black': 0,
    'brown': 1,
    'red': 2,
    'orange': 3,
    'yellow': 4,
    'green': 5,
    'blue': 6,
    'violet': 7,
    'grey': 8,
    'white': 9
  };

  int value(List<String> colors) {
    if (colors.length < 2) {
      throw ArgumentError('Expect at leat two colors');
    }

    return (10 * _colorMap[colors[0]]) + _colorMap[colors[1]];
  }
}
