public IList<int> MajorityElement(int[] nums)
{
    Dictionary<int, int> numbers = new Dictionary<int, int>();

    for (int i = 0; i < nums.Length; i++)
    {
        int number = nums[i];

        if (numbers.ContainsKey(number))
        {
            numbers[number]++;
        }
        else
        {
            numbers.Add(number, 1);
        }
    }

    List<int> results = new List<int>();

    for (int i = 0; i < numbers.Count; i++)
    {   
        KeyValuePair<int, int> pair = numbers.ElementAt(i);

        if (pair.Value > nums.Length / 3)
        {
            results.Add(pair.Key);
        }
    }

    return results;
}