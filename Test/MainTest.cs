using Solution;

namespace Test
{
    public class MainTest
    {
        [Theory]
        [InlineData([0, new int[] { 0, 1, 2, 0, 4, 5, 0, 1 }, new int[] { 1, 2, 4, 5, 1 }, 5])]
        [InlineData([1, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 1, 1, 9, 5, 1, 2, 1, 1 }, new int[] { 2, 3, 4, 5, 6, 7, 8, 9, 5, 2 }, 10])]
        public void Solution_AnswerTest(int val, int[] nums, int[] expectednums, int ecpectedval)
        {
            int actual = Main.RemoveElement(ref nums, val);
            Assert.Equal(actual, ecpectedval);

            Assert.Equal(nums, expectednums);
        }
    }
}