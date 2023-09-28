#include <vector.h>

std::vector<int32_t> sortArrayByParity(std::vector<int32_t>& nums)
{
    std::vector<int32_t> results(nums.size());

    uint16_t evenIndex = 0;
    uint16_t oddIndex = nums.size() - 1;

    for (const int32_t num : nums)
    {
        if (num & 1)
        {
            results[oddIndex--] = num; 
        }
        else
        {
            results[evenIndex++] = num;
        }
    }        

    return results;
}