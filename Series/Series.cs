using System.Collections.Generic;

public static class Series {
    public static string[] Slices(string numbers, int sliceLength) {
        // Throw exception if sliceLength is longer than the numbers string
        if (numbers.Length < sliceLength || sliceLength <= 0) {
            throw new System.ArgumentException();
        }

        List<string> result = new();

        for (int index = 0; ; index++) {
            if (index > (numbers.Length - sliceLength)) {
                break;
            }
            var slice = numbers.Substring(index, sliceLength);
            result.Add(slice);
        }

        return result.ToArray();

    }
}
