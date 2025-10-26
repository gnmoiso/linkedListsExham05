namespace linkedListsExham05;

public class DoublyNode<T>
{
    public DoublyNode(T data)
    {
        Data = data;
        Prev = null;
        Next = null;
    }

    public DoublyNode<T>? Prev { get; set; }
    public T Data { get; set; }
    public DoublyNode<T>? Next { get; set; }
}