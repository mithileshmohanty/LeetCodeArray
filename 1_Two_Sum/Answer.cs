//This is naive solution with O(n^2) complexity
/*public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] output = {-1,-1};
        for(int i=0; i<nums.Length; i++)
        {
            for(int j=0; j<nums.Length; j++)
            {
                if(i==j)
                    continue;
                if(nums[i]+nums[j] == target)
                {
                    output[0]=i;
                    output[1]=j;
                }
            }
        } 
        return output;
    }
}*/
//This is solution with O(n) complexity by using Dictionary
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] output = {-1,-1};
        Dictionary<int,int> valuesDict = new Dictionary<int,int>();
        for(int i=0; i<nums.Length; i++)
        {
            int remainder = target - nums[i];
            valuesDict[remainder] = i ;
        }
        for(int i=0; i<nums.Length; i++)
        {
            if(valuesDict.ContainsKey(nums[i]))
            {
                if(i==valuesDict[nums[i]])
                    continue;
                output[0]=i;
                output[1]=valuesDict[nums[i]];   
                break;
            }
        }
        return output;
    }
}