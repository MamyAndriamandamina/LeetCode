public class Solution 
{
    public int[] TwoSum(int[] nums, int target) 
    {
        List<int> mycollection = new List<int>();
        List<string> mystringcollection = new List<string>();
        for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (j > i)
                    {
                        mycollection.Add(nums[i] + nums[j]);
                        mystringcollection.Add(""+ i + ","+ j + "");
                    }
                }
            }
        int[] input = mycollection.ToArray();
        string[] inputstring = mystringcollection.ToArray();
        int setpoint = target;
            //ascending sort
        var itemMoved = false;
            do
            {
                itemMoved = false;
                for (int i = 0; i < input.Count() - 1; i++)
                {
                    if (input[i] > input[i + 1])
                    {
                        var lowerValue = input[i + 1];
                        var lowerString  = inputstring[i + 1];
                        input[i + 1] = input[i];
                        inputstring[i + 1] = inputstring[i];
                        input[i] = lowerValue;
                        inputstring[i] = lowerString;
                        itemMoved = true;
                    }
                }
            } while (itemMoved);
            //find the maximum value that is less than K
            var K = setpoint;
            var Output = new int[] {};
            List<int> myoutput = new List<int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (Int32.Parse(input[i].ToString()) == K)
                {
                    var data = inputstring[i].ToString();
                    Output = Array.ConvertAll(data.Split(','), int.Parse);
                }
            }
        return Output;
        }
}