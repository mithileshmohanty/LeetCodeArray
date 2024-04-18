//naive approach solve
/*public class Solution {
    public int[] BuildArray(int[] nums) {
        int[] output = new int[nums.Length];
        for(int i=0; i<nums.Length; i++)
        {
           output[i] = nums[nums[i]];
        }
        return output;
    }
}*/

public class Solution {
    public int[] BuildArray(int[] nums) {
        int[] output = new int[nums.Length];
        for(int i=0; i<nums.Length; i++)
        {
           output[i] = nums[nums[i]];
        }
        return output;
    }
}