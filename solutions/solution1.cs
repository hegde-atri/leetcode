namespace solution1
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (dic.ContainsKey(complement))
                {
                    return new int[] { i, dic[complement] };
                }
                else
                {
                    dic[nums[i]] = i;
                }
            }
            return new int[] { };

        }
    }
}
