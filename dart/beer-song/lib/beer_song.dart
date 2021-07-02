/// Responsible for reciting the beer song.
class BeerSong {
  /// Returns the beer song verse according to the [startBottles] and [takeDown]
  Iterable<String> recite(int startBottles, int takeDown) {
    if (startBottles < 0) {
      throw ArgumentError('startBottles must be a positive number');
    }

    if (takeDown < 0 || takeDown > startBottles + 1) {
      throw ArgumentError(
          'takeDown must be a positive number less than startBottles');
    }

    var beerSong = <String>[];

    while (takeDown > 1) {
      beerSong
        ..add(_firstPhrase(startBottles))
        ..add(_secondPhrase(startBottles))
        ..add('');

      startBottles--;
      takeDown--;
    }

    beerSong..add(_firstPhrase(startBottles))..add(_secondPhrase(startBottles));

    return beerSong;
  }

  String _firstPhrase(int beerNumber) {
    switch (beerNumber) {
      case 0:
        return 'No more bottles of beer on the wall, no more bottles of beer.';
      case 1:
        return '1 bottle of beer on the wall, 1 bottle of beer.';
      default:
        return '$beerNumber bottles of beer on the wall, $beerNumber bottles of beer.';
    }
  }

  String _secondPhrase(int beerNumber) {
    switch (beerNumber) {
      case 0:
        return 'Go to the store and buy some more, 99 bottles of beer on the wall.';
      case 1:
        return 'Take it down and pass it around, no more bottles of beer on the wall.';
      case 2:
        return 'Take one down and pass it around, 1 bottle of beer on the wall.';
      default:
        return 'Take one down and pass it around, ${beerNumber - 1} bottles of beer on the wall.';
    }
  }
}
