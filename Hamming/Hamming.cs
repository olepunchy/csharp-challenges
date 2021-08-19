public static class Hamming {
    public static int Distance(string firstStrand, string secondStrand) {
        // NOTE:
        // Hamming distance requires the strings to be the same length.
        // This implementation throws System.ArgumentException if the
        // input strings are not the same length.
        if (firstStrand.Length != secondStrand.Length) {
            throw new System.ArgumentException();
        }

        int differences = 0;

        for (int index = 0; index <= firstStrand.Length - 1; index++) {
            if (firstStrand[index] != secondStrand[index]) {
                differences++;
            }
        }

        return differences;
    }
}
