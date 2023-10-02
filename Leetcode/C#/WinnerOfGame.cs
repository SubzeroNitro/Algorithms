public bool WinnerOfGame(string colors)
{
    if (colors.Length < 3)
    {
        return false;
    }

    char previous = colors[0];

    int sequenceLength = 1;
    int aliceMoves = 0;
    int bobMoves = 0;

    for (int i = 1; i < colors.Length; i++)
    {
        char current = colors[i];

        if (previous != current)
        {
            previous = current;
            sequenceLength = 1;

            continue;
        }

        if (++sequenceLength < 3)
        {
            continue;
        }

        if (current == 'A')
        {
            aliceMoves++;
        }
        else
        {
            bobMoves++;
        }
    }

    return aliceMoves > bobMoves;
}
