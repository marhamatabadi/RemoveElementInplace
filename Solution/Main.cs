namespace Solution
{
    public static class Main
    {
        public static int RemoveElement(ref int[] nums, int val)
        {

            int writeIndex = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[writeIndex] = nums[i];
                    writeIndex++;
                }

            }
            nums = nums[0..writeIndex];
            return writeIndex;
        }
    }
}
