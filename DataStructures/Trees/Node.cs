using System;

public class Node<T>
{
   public T Data { get; set; }

   public Node<T> LeftChild { get; set; }
   public Node<T> RightChild { get; set; }

   public Node(T data)
   {
      Data = data;
   }

   public Node(T data, Node<T> leftChild, Node<T> rightChild)
   {
      Data = data;
      LeftChild = leftChild;
      RightChild = rightChild;
   }
}