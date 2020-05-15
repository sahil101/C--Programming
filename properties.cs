using System;
namespace c__programming
{
  class properties
  {
    private string name = "Sahil";
    private string branch = "CSE";
    private int gpa = 9;

    public int Gpa
    {
      get
      {
        return gpa;
      }
      set
      {
        gpa = value;
      }
    }
    public String Name
    {
      get
      {
        return name;
      }
      set
      {
        name = value;
      }
    }
    public string Branch
    {
      get
      {
        return branch;
      }
      set
      {
        branch = value;
      }
    }
  }
  class handler
  {
    public static void Main()
    {
      properties p = new properties();
      Console.WriteLine("Name : {0} Branch : {1} gpa : {2}", p.Name, p.Branch, p.Gpa);
    }
  }
}