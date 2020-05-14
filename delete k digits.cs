using System;

namespace c__programming
{
    class loweststring
    {
        static String res = "";
       static  public string lowestnumber(String str,int k)
        {
            if (str.Length <=k)
            return "0";
            while(true)
            {
            if (k == 0)
            {
                res = res + str;
                break;
            }
            int len  = str.Length;
            if(k>=len)
                break;
            int minindex = 0;
            for(int i = 1;i<=k;i++)
            if(str[minindex] > str[i] )
            minindex = i;
            res = res + str[minindex];
            String new_str = str.Substring(minindex+1);
            str = new_str;
            k = k - minindex;
        }
        int l = 0;
        while(true)
        {
            if(res[l]!='0')
                break;
            l++;
            if( l == res.Length)
                break;
        }
        if(l == res.Length)
            return "0";
        return res.Substring(l);
        }
        public static void Main(string[] args)
        {
            String s = Console.ReadLine();
            int k = Convert.ToInt32(Console.ReadLine());
            string s1 = lowestnumber(s,k);
            Console.WriteLine(s1);
        }
    }
}
