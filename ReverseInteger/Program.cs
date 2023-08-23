public class Solution
{
    public int Reverse(int x)
    {
        int ret =0;
        while(x!=0) 
        { 
            int digit = x % 10;
            int tmp = ret * 10;
            if (tmp / 10 != ret)
                return 0;
            tmp += digit;
            ret = tmp;
            x = x / 10;
        }
        return ret;
    }
}