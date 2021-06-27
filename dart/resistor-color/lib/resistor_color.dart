/// Responsible for parsing the resistor's colors.
class ResistorColor {
  /// Complete resistor's color code.
  final colors = const [
    'black',
    'brown',
    'red',
    'orange',
    'yellow',
    'green',
    'blue',
    'violet',
    'grey',
    'white'
  ];

  /// Returns the color code for a given [color].
  int colorCode(String color) => colors.indexOf(color);
}
