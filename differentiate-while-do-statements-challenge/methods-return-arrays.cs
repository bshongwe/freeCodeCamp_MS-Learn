int[,] TwoCoins(int[] coins, int target) 
{
    int[,] result = {{-1,-1},{-1,-1},{-1,-1},{-1,-1},{-1,-1}};
    int count = 0;

    for (int curr = 0; curr < coins.Length; curr++) 
    {
        for (int next = curr + 1; next < coins.Length; next++) 
        {
            if (coins[curr] + coins[next] == target) 
            {
                result[count, 0] = curr;
                result[count, 1] = next;
                count++;
            }
            if (count == result.GetLength(0)) 
            {
                return result;
            }
        }
    }
    return (count == 0) ? new int[0,0] : result;
}