public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var map = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++) {
            var x = nums[i];
            var y = target - x;
            if (map.ContainsKey(y)) {
                return [map[y], i];
            }
            map[x] = i;
        }
        return [0,1]; 
    }
}
