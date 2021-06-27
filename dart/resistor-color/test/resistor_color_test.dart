import 'package:resistor_color/resistor_color.dart';
import 'package:test/test.dart';

final resistorColor = ResistorColor();

void main() {
  group('ResistorColor', () {
    group('Color codes', () {
      test('Black', () {
        final result = resistorColor.colorCode('black');
        expect(result, equals(0));
      }, skip: false);

      test('White', () {
        final result = resistorColor.colorCode('white');
        expect(result, equals(9));
      }, skip: false);

      test('Orange', () {
        final result = resistorColor.colorCode('orange');
        expect(result, equals(3));
      }, skip: false);
    });

    test('Colors', () {
      final result = resistorColor.colors;
      expect(
          result,
          equals(<String>[
            'black',
            'brown',
            'red',
            'orange',
            'yellow',
            'green',
            'blue',
            'violet',
            'grey',
            'white',
          ]));
    }, skip: false);
  });
}
