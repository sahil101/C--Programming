using System;
using System.Collections;
using System.Threading;
namespace c__programming
{
public  class multithreading
{
public static void counter()
{
  try{
    int n = 10;
    for(int i = 0;i<n;i++)
    {
      Thread.Sleep(500);
      Console.WriteLine(i);
    }
  }
  catch(ThreadAbortException e)
  {
    Console.WriteLine(e.Message);
  }
}
public static void Main()
{
  ThreadStart n2 = new ThreadStart(counter);
  Console.WriteLine("main thread begins");
  Thread first = new Thread(n2);
  first.Start();
  Thread.Sleep(1000);
  Console.WriteLine("Main Thread stops");
  first.Abort();
  Console.ReadKey();
}
}
}