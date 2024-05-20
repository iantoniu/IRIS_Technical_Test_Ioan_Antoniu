namespace Single_Number
{
    public class SingleNumberFinder
    {
        public static int FindSingleNumber(int[] nums)
        {
            int single = 0;
            foreach (int num in nums)
            {
                // using xor for a number with itself is zero and with zero gives the number
                single ^= num;
            }
            return single;
        }
    }
}
