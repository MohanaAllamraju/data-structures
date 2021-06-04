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
            Assert.Equal(finder.FindMaxLengthOfTwoWordsWhichAreUnique(new string[] { }), 0);
            Assert.Equal(finder.FindMaxLengthOfTwoWordsWhichAreUnique(new string[] { "abcw", "baz", "foo", "bar", "xtfn", "abcdef" }), 16);
            Assert.Equal(finder.FindMaxLengthOfTwoWordsWhichAreUnique(new string[] { "hello", "world", "any", "item", "thing", "welcome" }), 35);
            Assert.Equal(finder.FindMaxLengthOfTwoWordsWhichAreUnique(new string[] { "gajani", "ramba", "urvasi", "menaka", "thamanna", "charmi" }), 0);
            Assert.Equal(finder.FindMaxLengthOfTwoWordsWhichAreUnique(new string[] { "a", "ab", "abc", "d", "cd", "bcd", "abcd" }), 4);
            Assert.Equal(finder.FindMaxLengthOfTwoWordsWhichAreUnique(new string[] { "a", "aa", "aaa", "aaaa" }), 0);
        }

        [Fact]
        public void TEST_FindMaxProduct()
        {
            // Find a pair of unique words -> abc and cba are not unique
            // All are lower cases
            // return 0 if no such words exist

            var finder = new FindMaxProduct();
            Assert.Equal(finder.MaxProduct(new string[] { }), 0);
            Assert.Equal(finder.MaxProduct(new string[] { "abcw", "baz", "foo", "bar", "xtfn", "abcdef" }), 16);
            Assert.Equal(finder.MaxProduct(new string[] { "hello", "world", "any", "item", "thing", "welcome" }), 35);
            Assert.Equal(finder.MaxProduct(new string[] { "gajani", "ramba", "urvasi", "menaka", "thamanna", "charmi" }), 0);
            Assert.Equal(finder.MaxProduct(new string[] { "a", "ab", "abc", "d", "cd", "bcd", "abcd" }), 4);
            Assert.Equal(finder.MaxProduct(new string[] { "a", "aa", "aaa", "aaaa" }), 0);
        }
    }
}
