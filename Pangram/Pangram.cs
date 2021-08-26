using System.Linq;
using System.Text.RegularExpressions;

public static class Pangram {

    private const string _alphabet = "abcdefghijklmnopqrstuvwxyz";
    private const string _regex = "[^a-zA-Z]+";

    public static bool IsPangram(string input) {

        input = Regex.Replace(input.ToLower(), _regex, "");

        if (string.IsNullOrEmpty(input) || input.Length < 26) {
            return false;
        }

        int missingCount = 0;

        for (int index = 0; index < _alphabet.Length; index++) {
            bool result = input.Any(a => a == _alphabet[index]);
            if (!result) {
                missingCount++;
            }
        }

        return missingCount == 0;
    }
}
