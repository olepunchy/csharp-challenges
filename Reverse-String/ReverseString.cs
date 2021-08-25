// using System;

public static class ReverseString {
    public static string Reverse(string input) {
        string reverse = string.Empty;

        for (int index = input.Length - 1; index >= 0; index--) {
            reverse += input[index];
        }

        return reverse;
    }
}
