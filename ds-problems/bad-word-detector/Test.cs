using Xunit;

namespace ds_problems.badworddetector
{
    public class BADWORD_DETECTOR
    {
        [Fact]
        public void BADWORDDETECTOR_RETURNFALSE()
        {
            var validator = new BadWordValidator();
            Assert.False(validator.DetectBadWord("myworld@domain.com"));
            Assert.False(validator.DetectBadWord("any@domain.com"));
            Assert.False(validator.DetectBadWord("world@domain.com"));
            Assert.False(validator.DetectBadWord("in@domain.com"));
            Assert.False(validator.DetectBadWord("doit@domain.com"));
            Assert.False(validator.DetectBadWord("income@domain.com"));
        }

        [Fact]
        public void BADWORDDETECTOR_RETURNTRUE()
        {
            var validator = new BadWordValidator();
            Assert.True(validator.DetectBadWord("ass@domain.com"));
            Assert.True(validator.DetectBadWord("kickmyass@domain.com"));
            Assert.True(validator.DetectBadWord("bastardbabai@domain.com"));
            Assert.True(validator.DetectBadWord("Iambitch@domain.com"));
            Assert.True(validator.DetectBadWord("cockcooker@domain.com"));
            Assert.True(validator.DetectBadWord("whatthecrap@domain.com"));
        }
    }
}
