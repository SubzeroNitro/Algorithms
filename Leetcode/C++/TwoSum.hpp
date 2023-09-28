#include <vector>
#include <unordered_map>

std::vector<int32_t> twoSum(const std::vector<int32_t>& nums, const int32_t target) 
{
    std::unordered_map<int32_t, int32_t> map;
    
    for (int32_t i = 0; i < nums.size(); i++)
    {
        const auto it = map.find(target - nums[i]);    

        if (it != map.end())
        {
            return { i, it->second };
        }
        
        map[nums[i]] = i;    
    }  

    return {}; 
}