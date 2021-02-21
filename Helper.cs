using System;

namespace LeetAddArraySum{
    public static class Helper{ 
        public static int[] TwoSum(int[] nums, int target) {
        for(int i=0;i<nums.Length;i++){
            for(int j=i+1;j<nums.Length; j++){
                if(nums[j] == target - nums[i]){
                    return new int[]{i,j};
                }
            }
        }
        throw new Exception("No two sum solution");
    }
    }
}