using System.Text.RegularExpressions;

public static class TacoCat {

    public static bool IsPalindrome(string input) {

        const string regex = "[^a-zA-Z]+";
        string reversed = string.Empty;

        for (int index = input.Length - 1; index >= 0; index--) {
            reversed += input[index];
        }

        // Limit comparison to only alphanumeric characters.
        reversed = Regex.Replace(reversed.ToLower(), regex, "");
        input = Regex.Replace(input.ToLower(), regex, "");

        // Handle a case like -- which is the same reversed but is not
        // a valid Palindrome.
        if (reversed.Equals(string.Empty) || input.Equals(string.Empty)) {
            return false;
        }

        return reversed.Equals(input);
    }
}
