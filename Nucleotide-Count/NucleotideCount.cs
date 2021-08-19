using System.Collections.Generic;

public static class NucleotideCount {

    public static IDictionary<char, int> Count(string sequence) {

        int a = 0;
        int c = 0;
        int g = 0;
        int t = 0;

        foreach (var letter in sequence) {
            switch (letter) {
                case 'A':
                    a++;
                    break;

                case 'C':
                    c++;
                    break;

                case 'G':
                    g++;
                    break;

                case 'T':
                    t++;
                    break;

                default:
                    throw new System.ArgumentException();
            }
        }

        var dict = new Dictionary<char, int>() {
            ['A'] = a,
            ['C'] = c,
            ['G'] = g,
            ['T'] = t
        };

        return dict;

    }
}
