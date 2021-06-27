/// Responsible for parsing leap years.
class Leap {
  /// Returns whether a given [year] is leap or not.
  bool leapYear(int year) =>
      (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;
}
