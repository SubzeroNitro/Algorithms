public int LengthOfLongestSubstring(string s)
{
    int largestSubstringLength = 0;
    int leftIndex = 0;
    int rightIndex = 0;

    HashSet<char> substring = new HashSet<char>();

    while (rightIndex < s.Length)
    {
        char c = s[rightIndex];

        if (substring.Contains(c))
        {
            substring.Remove(s[leftIndex]);
            leftIndex++;
        }
        else
        {
            substring.Add(c);
            rightIndex++;

            largestSubstringLength = Math.Max(largestSubstringLength, substring.Count);
        }
    }

    return largestSubstringLength;
}
