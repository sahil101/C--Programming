using System;
namespace c__programming
{
  internal class Node
  {
    internal Node left;
    internal Node right;
    internal int data;
    public Node(int data)
    {
      left = null;
      right = null;
      this.data = data;
    }
  }
  internal class BST
  {
    internal Node root;
    BST()
    {
      root = null;
    }
    public void insert(int val)
    {
      Node temp = new Node(val);
      if (root == null)
        root = temp;
      else
      {
        Node p = root;
        Node q = null;
        while (p != null)
        {
          q = p;
          if (val == p.data)
            return;
          else if (val < p.data)
            p = p.left;
          else
            p = p.right;
        }
        if (val < q.data)
          q.left = temp;
        else
          q.right = temp;
      }
    }
    public bool searchele(int key)
    {
      if (root == null)
        return false;
      else
      {
        Node p = root;
        while (p != null)
        {
          if (key == p.data)
            return true;
          else if (key > p.data)
            p = p.left;
          else
            p = p.right;
        }
        return false;
      }

    }
    public void inorder(Node p)
    {
      if (p != null)
      {
        inorder(p.left);
        Console.Write(p.data + "->");
        inorder(p.right);
      }
    }
    public void preorder(Node p)
    {
      if (p != null)
      {
        Console.Write(p.data + "->");
        preorder(p.left);
        preorder(p.right);
      }
    }
    public void postorder(Node p)
    {
      if (p != null)
      {
        postorder(p.left);
        postorder(p.right);
        Console.Write(p.data + "->");
      }
    }
    public int height(Node p)
    {
      int x = 0, y = 0;
      if (p == null)
        return 0;
      x = height(p.left);
      y = height(p.right);
      if (x > y)
        return x + 1;
      else
        return y + 1;
    }
    public static void Main()
    {
      BST b = new BST();
      b.insert(10);
      b.insert(20);
      b.insert(5);
      b.insert(7);
      b.insert(6);
      b.insert(15);
      b.insert(16);
      Node p = b.root;
      b.inorder(p);
      Console.WriteLine();
      Console.WriteLine(b.height(p));
      b.postorder(p);
      Console.WriteLine();
      b.preorder(p);
    }
  }
}