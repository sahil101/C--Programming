using System;
using System.Collections;
namespace  c__programming
{
internal class Node
{
  internal int data;
  internal Node next;
  public Node(int data)
  {
    this.data = data;
    next = null;
  }
}
internal class LinkedList
{
 internal Node head;
  public LinkedList()
  {
    head = null;
  }
  public void insertfront(int data)
  {
      Node temp = new Node(data);
    if (head == null)
      head = temp;
    else
      {
        temp.next = head;
        head = temp;
      }
  }
  public void deletefront()
  {
    if(head.next == null)
    head  = null;
    else
    {
      Node p = head.next;
      head = p;
    }
  }
  public void insertlast(int data)
  {
    Node temp = new Node(data);
    if(head == null)
    head = temp;
    else
    {
        Node p = head;
        while(p.next!=null)
          p = p.next;
        p.next = temp;
    }
  }
  public void display()
  {
    Node p = head;
    while(p.next!=null)
    {
      Console.Write(p.data+"->");
      p = p.next;
    }
    Console.WriteLine(p.data);
  }

}
public class  program
{
  public static void Main()
  {
    LinkedList list = new LinkedList();
    list.insertfront(10);
    list.insertfront(20);
    list.insertfront(30);
    list.insertfront(40);
    list.insertfront(50);
    list.deletefront();
    list.deletefront();
    list.insertfront(60);
    list.insertlast(70);
    list.display();
  }
}
}