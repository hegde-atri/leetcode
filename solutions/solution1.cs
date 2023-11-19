namespace solution1;

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        var dic = new Dictionary<int, int>();
        for (var i = 0; i < nums.Length; i++)
        {
            var complement = target - nums[i];
            if (dic.TryGetValue(complement, out var value))
                return new[] { i, value };
            dic[nums[i]] = i;
        }
        return Array.Empty<int>();
    }
}