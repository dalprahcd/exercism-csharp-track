class ResistorColor {
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

  int colorCode(String color) => colors.indexOf(color);
}
