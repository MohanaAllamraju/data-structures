using Xunit;

namespace ds_problems.bit_manipulation
{
    public class BADWORD_DETECTOR
    {
        [Fact]
        public void TEST_FindMaxLengthOfTwoWordsWhichAreUnique()
        {
            // Find a pair of unique words -> abc and cba are not unique
            // All are lower cases
            // return 0 if no such words exist

            var finder = new FindMaxLengthOfTwoStrings();
            Assert.Equal(0, finder.FindMaxLengthOfTwoWordsWhichAreUnique(new string[] { }));
            Assert.Equal(16, finder.FindMaxLengthOfTwoWordsWhichAreUnique(new string[] { "abcw", "baz", "foo", "bar", "xtfn", "abcdef" }));
            Assert.Equal(35, finder.FindMaxLengthOfTwoWordsWhichAreUnique(new string[] { "hello", "world", "any", "item", "thing", "welcome" }));
            Assert.Equal(0, finder.FindMaxLengthOfTwoWordsWhichAreUnique(new string[] { "gajani", "ramba", "urvasi", "menaka", "thamanna", "charmi" }));
            Assert.Equal(4, finder.FindMaxLengthOfTwoWordsWhichAreUnique(new string[] { "a", "ab", "abc", "d", "cd", "bcd", "abcd" }));
            Assert.Equal(0, finder.FindMaxLengthOfTwoWordsWhichAreUnique(new string[] { "a", "aa", "aaa", "aaaa" }));
        }

        [Fact]
        public void TEST_FindMaxProduct()
        {
            // Find a pair of unique words -> abc and cba are not unique
            // All are lower cases
            // return 0 if no such words exist

            var finder = new FindMaxProduct();
            Assert.Equal(0, finder.MaxProduct(new string[] { }));
            Assert.Equal(16, finder.MaxProduct(new string[] { "abcw", "baz", "foo", "bar", "xtfn", "abcdef" }));
            Assert.Equal(35, finder.MaxProduct(new string[] { "hello", "world", "any", "item", "thing", "welcome" }));
            Assert.Equal(0, finder.MaxProduct(new string[] { "gajani", "ramba", "urvasi", "menaka", "thamanna", "charmi" }));
            Assert.Equal(4, finder.MaxProduct(new string[] { "a", "ab", "abc", "d", "cd", "bcd", "abcd" }));
            Assert.Equal(0, finder.MaxProduct(new string[] { "a", "aa", "aaa", "aaaa" }));
        }
    }
}
