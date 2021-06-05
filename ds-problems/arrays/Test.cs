using Xunit;

namespace ds_problems.arrays
{
    public class AddOneToArrayTest
    {
        [Fact]
        public void AddOneToArrayTest_Should_Pass()
        {
            var addOneToarray = new AddOneToArray();
            Assert.Equal(addOneToarray.AddNumberToArray(new int[] { }), new int[] { });
            Assert.Equal(addOneToarray.AddNumberToArray(new int[] { 5, 8, 9 }), new int[] { 5, 9, 0 });
            Assert.Equal(addOneToarray.AddNumberToArray(new int[] { 9, 9, 9 }), new int[] { 1, 0, 0, 0 });
        }
    }
}
