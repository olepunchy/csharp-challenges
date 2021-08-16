public static class Leap {
    public static bool IsLeapYear(int year) {

        // Leap:
        // Retrun 'true' if year is a leap year, else 'false'.
        //
        // - on every year that is evenly divisible by 4
        //   - except every year that is evenly divisible by 100
        //     - unless the year is also evenly divisible by 400

        if (year < 1 || year > 9999) {
            // Clamp the year range to something we can work with.
            return false;
        }

        // Is the year?:
        // - Evenly divisible by 4
        // - Not evenly divisble by 100
        // - Evenly divisible by 400
        return year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);

    }
}
