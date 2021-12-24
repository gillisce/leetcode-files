 namespace leetcode.array_problems
 {
     public class ContainsDuplicate{

         public bool ContainsDuplicates(int [] nums){
             var set = new HashSet<int>(nums.Length);
             foreach(int i in nums){
                 if(set.Contains(i)) return true;
                 set.Add(i);
             }
            return false;
         }


         public bool ContainsNearbyDuplicate(int[] nums, int k){
            if(nums.Length < 2){
                return false;
            }

            var dic = new Dictionary<int,int>();
            for(int i = 0; i < nums.Length; i++)
            {
                if(dic.ContainsKey(nums[i]) && Math.Abs(dic[nums[i]] - i ) <= k) return true;
                dic[nums[i]] = i;
            }
            return false;
         }

         public bool ContainsNearbyAlmostDuplicate(int[] nums, int k, int t){
            if(t < 0) return false;
            var dic = new Dictionary<long,long>();
            for(int i = 0; i < nums.Length; i++){
                var key = (int)Math.Floor((double)nums[i]/(t+1));

                if(dic.ContainsKey(key)) return true;
                if(dic.ContainsKey(key-1) && Math.Abs(nums[i] - dic[key-1]) <= t) return true;
                if(dic.ContainsKey(key+1) && Math.Abs(nums[i] - dic[key+1]) <= t) return true;
                
                dic[key] = nums[i];
                
                if(i >= k ) dic.Remove((int)Math.Floor((double)nums[i - k] / (t + 1)));
            }
            return false;
         }

         private long GetIds(long val, long x){
             return val < 0 ? (val+1)/ (x-1) : val/x;

         }
     }
 }