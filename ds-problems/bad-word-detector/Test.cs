using ds_problems.badworddetector;
using System;
using Xunit;

namespace ds_problems
{
    public class BADWORD_DETECTOR
    {
        [Fact]
        public void BADWORDDETECTOR_RETURNFALSE()
        {
            var validator = new BadWordValidator();
            Assert.False(validator.DetectBadWord("myworld@gmail.com"));
        }
    }
}
