using System;

namespace DataStructures.UseCases.Factory
{
   /// <summary>
   /// Creates linked lists for data structure use cases.
   /// </summary>
   public class LinkedListFactory
   {
      #region Singly Linked List 

      public static Core.LinkedLists.LinkedList<T> CreateSinglyLinkedList<T>()
      {
         return new Core.LinkedLists.LinkedList<T>();
      }

      public static Core.LinkedLists.LinkedList<T> CreateSinglyLinkedList<T>(T headvalue)
      {
         return new Core.LinkedLists.LinkedList<T>(headvalue);
      }

      #endregion
   }
}