using Xunit;

public class TacoCatTests {

    [Fact]
    public void Word_Is_Palindrome() {
        Assert.True(TacoCat.IsPalindrome("Otto"));
    }

    [Fact]
    public void Phrase_Is_Palindrome() {
        Assert.True(TacoCat.IsPalindrome("Taco Cat!"));
    }

    [Fact]
    public void Sentence_Is_Palindrome() {
        Assert.True(TacoCat.IsPalindrome("A santa at Nasa."));
    }

    [Fact]
    public void Dashs_Not_Palindrome() {
        Assert.False(TacoCat.IsPalindrome("--"));
    }

    [Fact]
    public void Numbers_Not_Palindrome() {
        Assert.False(TacoCat.IsPalindrome("999"));
    }

    [Fact]
    public void Punctuation_Not_Palindrome() {
        Assert.False(TacoCat.IsPalindrome("!!!"));
    }
}
