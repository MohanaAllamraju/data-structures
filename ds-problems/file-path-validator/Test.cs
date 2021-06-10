using ds_problems.badworddetector;
using Xunit;

namespace ds_problems.filepath_validator
{
    public class STRINGSTUFF_TEST
    {
        [Fact]
        public void SHOULD_HAVE_LENGTH_20_POST_STUFFING()
        {
            // should be 20 digits length
            // should be unique
            // should include characters from given string
            var validator = new FilePathValidator();
            Assert.Equal(20, validator.GetValidFilePath("").Length);
            Assert.Equal(20, validator.GetValidFilePath("hello").Length);
            Assert.Equal(20, validator.GetValidFilePath("I Mean").Length);
            Assert.Equal(20, validator.GetValidFilePath("I AM A BAD BOY").Length);
            Assert.Equal(20, validator.GetValidFilePath("I KNOW DO NOT KNOW HOW THIS IS GONNA TO WORK BUT I DONT GIVE UP").Length);
        }

        [Fact]
        public void SHOULD_BE_UNIQUE()
        {
            // should be 20 digits length
            // should be unique
            // should include characters from given string
            var validator = new FilePathValidator();
            var firstCallOutput = validator.GetValidFilePath("");
            var secondCallOutput = validator.GetValidFilePath("");
            Assert.NotEqual(firstCallOutput, secondCallOutput);

            var str1 = validator.GetValidFilePath("I KNOW DO NOT KNOW HOW THIS IS GONNA TO WORK BUT I DONT GIVE UP");
            var str2 = validator.GetValidFilePath("I KNOW DO NOT KNOW HOW THIS IS GONNA TO WORK BUT I DONT GIVE UP");
            Assert.NotEqual(str1, str2);
        }
    }
}
