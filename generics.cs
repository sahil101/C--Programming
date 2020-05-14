using System;
using System.Collections;
using System.Threading;
using System.Collections.Generic;
namespace c__programming
{
  public class Node<T>
  {
    public Node<T> left;
    public Node<T> right;
    public T data;
     public Node(T data)
    {
      this.data  = data;
      left= null;
      right = null;
    }
  }
  public class Doubly<T>
  {
    Node<T> head;
    public Doubly()
    {
      head = null;
    }
    public void insertfront(T data)
    {
      Node<T> temp = new Node<T>(data);
      if(head == null)
      head = temp;
      else
      {
        head.left = temp;
        temp.right = head;
        head = temp;
      }
    }
    public void deletefront()
    {
      if(head.right == null)
      head= null;
      else
      {
      head = head.right;
      head.left = null;
    }
    }
    public int length()
    {
      Node<T> p = head;
      int count = 0;
      while(p!=null)
      {
      p = p.right;
      count++;
      }
      return count;
    }
    public void insertatposition(int k,T data)
    {
      Node<T> temp = new Node<T>(data);
      if(k > length())
        Console.WriteLine("list out of Bound");
      else if(k == 1)
      {
        temp.right = head;
        head = temp;
      }
      else
      {
      Node<T> p =head;;
      for(int i = 0;i<k-1;i++)
        p = p.right;
      temp.right = p;
      temp.left =  p.left;
      p.left = temp;
      }
    }
    public void display()
    {
      Node<T> p = head;
      while(p.right!=null)
      {
        Console.Write(p.data+"->");
        p = p.right;
      }
      Console.WriteLine(p.data);
    }
    public void insertrear(T data)
    {
      Node<T> temp = new Node<T>(data);
      if(head == null)
      head = temp;
      else
      {
        Node<T> p = head;
        while(p.right !=null)
        p = p.right;
        p.right = temp;
      }
    }
  }
  public class c__programming{
    public static void Main()
    {
      Doubly<char> d = new Doubly<char>();
      d.insertfront('a');
      d.insertfront('b');
      d.insertfront('c');
      d.deletefront();
      d.insertatposition(1,'f');
      d.insertfront('e');
      Console.WriteLine(d.length());
      d.display();
    }
  }
}