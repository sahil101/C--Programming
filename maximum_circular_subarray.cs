using System;
namespace c__programming
{

  public class Solution
  {
    public int MaxSubarraySumCircular(int[] A)
    {
      int n = A.Length;
      int cmasum = 0;
      int maxsum = int.MinValue;
      int cmisum = 0;
      int minsum = int.MaxValue;
      int sum = 0;
      for (int i = 0; i < n; i++)
      {
        cmasum = Math.Max(cmasum + A[i], A[i]);
        maxsum = Math.Max(maxsum, cmasum);
        cmisum = Math.Min(cmisum + A[i], A[i]);
        minsum = Math.Min(minsum, cmisum);
        sum = sum + A[i];
      }
      return maxsum > 0 ? Math.Max(maxsum, sum - minsum) : maxsum;
    }
  }
}