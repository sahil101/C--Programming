using System;
// Anonymous method  has no return tyoe
//no name
//used with delegates
// instance of a delegate only take parameter as a function which has the same function declaration and signature.
delegate void NumberChanger(int n);
namespace c__programming
{
  class TestDelegate
  {
    static int num = 10;

    public static void AddNum(int p)
    {
      num += p;
      Console.WriteLine("Named Method: {0}", num);
    }
    public static void SubNum(int r)
    {
      num -= r;
      Console.WriteLine("NamedMethod : {1}", num);
    }
    public static void MultNum(int q)
    {
      num *= q;
      Console.WriteLine("Named Method: {0}", num);
    }
    public static int getNum()
    {
      return num;
    }
    static void Main(string[] args)
    {
      NumberChanger nc = delegate (int x)
      {
        Console.WriteLine("Anonymous Method: {0}", x);
      };
      nc(10);
      nc = new NumberChanger(AddNum);
      nc(5);
      nc = new NumberChanger(MultNum);
      nc(2);
      nc = new NumberChanger(SubNum);
      nc(20);
      Console.ReadKey();
    }
  }
}