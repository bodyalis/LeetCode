namespace LeetCode.Problems._7._Reverse_Integer;

public class ReverseInteger
{
    public int Reverse(int x)
    {
        if (x / 10 == 0)
        {
            return x;
        }
        try
        {
            int result = 0;
            checked
            {
                bool isNegative = x < 0;
                x *= isNegative ? -1 : 1;
                while (x > 0)
                {
                    int temp = x % 10;
                    x /= 10;
                    result = result * 10 + temp;
                }
                
                result *= isNegative ? -1 : 1;
            }
            return result;
        }
        catch 
        {
            return 0;
        }
    }
}
