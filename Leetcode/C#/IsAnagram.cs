public bool IsAnagram(string s, string t)
{
    if (s.Length != t.Length)
    {
        return false;
    }

    Dictionary<char, int> set = new Dictionary<char, int>();

    for (int i = 0; i < s.Length; i++)
    {
        char c = s[i];

        if (set.ContainsKey(c))
        {
            set[c]++;
        }
        else
        {
            set.Add(c, 1);
        }            
    }

    for (int i = 0; i < t.Length; i++)
    {
        char c = t[i];

        if (set.ContainsKey(c) && set[c] > 0)
        {
            set[c]--;
        }
        else
        {
            return false;
        } 
    }

    return true;
}
