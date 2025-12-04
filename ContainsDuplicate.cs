public class Solution {
    public bool ContainsDuplicate(int[] nums) {
       List<int> seen = new List<int>();
       foreach(int n in nums){
            if (seen.Contains(n)){
                return true;
            }
            seen.Add(n);
       }
       return false;
    }
}

