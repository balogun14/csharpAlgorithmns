// namespace arrayClass
// {
//     public class DoublyLinkedListImplementation<T>
//     {
//         public static int length;
//         private Node<T>? head;
//         public DoublyLinkedListImplementation()
//         {
//             length = 0;
//             this.head = null;
//         }
//         public static void Prepend(T item)
//         {
//             var node = new Node(item);
//         }
//         public T Get(int index)
//         {

//         }

//         public static void InsertAt(T item, int index)
//         {

//         }
//         public static void Append(T item)
//         {

//         }
//         public static void Remove(T item)
//         {

//         }
//         /// <summary>
//         /// This removes element at a particular index
//         /// </summary>
//         /// <param name="index">index to remove item from</param>
//         /// <exception cref="IndexOutOfRangeException"></exception>
//         public static void RemoveAt(int index)
//         {
//             if (index > length)
//             {
//                 throw new IndexOutOfRangeException("Undefined");
//             }
//         }
//     }

//     internal class Node<T>
//     {
//         public required T value;
//         public Node<T>? prev;
//         public Node<T>? next;
//         public Node(T item){
//             this.value = item;
//             this.next = this.prev = null;
//         }
//     }
// }