/// Class responsible for parsing the Secret Handshake
class SecretHandshake {
  final _handShakeMap = const {
    1: 'wink',
    2: 'double blink',
    4: 'close your eyes',
    8: 'jump',
    16: 'reverse'
  };

  /// Returns the secret commands for a given [handshake]
  Iterable<String> commands(int handshake) {
    var query = <String>[];

    for (var cmd in _handShakeMap.keys) {
      if ((handshake & cmd) == cmd) {
        query.add(_handShakeMap[cmd]);
      }
    }

    if (query.contains('reverse')) {
      query.remove('reverse');
      return query.reversed;
    } else {
      return query;
    }
  }
}
