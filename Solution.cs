public class Solution 
{
    public int[] TwoSum(int[] nums, int target) 
    {
        List<int> mycollection = new List<int>();
        List<string> mystringcollection = new List<string>();
        var output = new int[]{};
        for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (j > i)
                    {
                        if(nums[i]+nums[j]==target)
                        {
                        var data = (""+ i + ","+ j + "");
                        output = Array.ConvertAll(data.Split(','), int.Parse);
                        }
                    }
                }
            }
        return output;
        }
}