// Given a List of words, return the words that can be typed using letters of alphabet on only one row's of American keyboard.(Qwerty)
using System;
using System.Collections;
namespace  c__programming
{
public class Solution
{
    public static string[] FindWords(string[] words)
    {
    ArrayList ad = new ArrayList();
    char[] a = new char[]{'A','S','D','F','G','H','J','K','L','a','s','d','f','g','h','j','k','l'};
    char[] b = new char[]{'Q','W','E','R','T','Y','U','I','O','P','q','w','e','r','t','y','u','i','o','p'};
    char[] c = new char[]{'Z','X','C','V','B','N','M','z','x','c','v','b','n','m'};
    for(int i = 0;i<words.Length;i++)
    {
        char[] flag;
        bool sign = false;
        int j = 0;
        if(Array.IndexOf(a,words[i][j])!=-1)
            flag = a;
        else if(Array.IndexOf(b,words[i][j])!=-1)
            flag = b;
        else
            flag = c;
       for(j = 1;j<words[i].Length;j++)
           if(Array.IndexOf(flag,words[i][j])==-1)
           {
               sign = true;
               break;
           }
        if(sign == false)
            ad.Add(i);
    }
    int n = ad.Count;
        String[] s = new String[n];
        int k = 0;
        foreach(int i in ad)
        {
            s[k] = words[i];
            k++;
        }
        return s;
    }
    public static void Main()
    {
        Console.WriteLine("Enter number the Elements");
        int n = Convert.ToInt32(Console.ReadLine());
        String[] words = new String[n];
        Console.WriteLine("enter the words");
        for(int i = 0;i<n;i++)
        words[i] = Console.ReadLine();
        Console.WriteLine("Words================Words");
        String[] s1 = FindWords(words);
        foreach(string j in  s1)
        Console.WriteLine(j);
        Console.ReadKey();
    }
}
}