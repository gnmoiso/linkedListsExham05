namespace linkedListsExham05;

public class DoublyLinkedList<T>
{
    private DoublyNode<T>? _head;
    private DoublyNode<T>? _tail;

    public DoublyLinkedList()
    {
        _head = null;
        _tail = null;
    }

    public void PrintList()
    {
        var current = _head;
        while (current != null)
        {
            Console.Write(current.Data + " ");
            current = current.Next;
        }
        Console.WriteLine();
    }

    public void InsertAtBeginning(T data)
    {
        var newNode = new DoublyNode<T>(data);
        if (_head == null)
        {
            _head = newNode;
            _tail = newNode;
        }
        else
        {
            newNode.Next = _head;
            _head.Prev = newNode;
            _head = newNode;
        }
    }

    public void InsertAtEnd(T data)
    {
        var newNode = new DoublyNode<T>(data);
        if (_tail == null)
        {
            _head = newNode;
            _tail = newNode;
        }
        else
        {
            _tail.Next = newNode;
            newNode.Prev = _tail;
            _tail = newNode;
        }
    }

    public void DisplayForward()
    {
        var current = _head;
        while (current != null)
        {
            Console.Write(current.Data + " ");
            current = current.Next;
        }
        Console.WriteLine();
    }

    public void DisplayBackward()
    {
        var current = _tail;
        while (current != null)
        {
            Console.Write(current.Data + " ");
            current = current.Prev;
        }
        Console.WriteLine();
    }

    public void SortDescending()
    {
        if (_head == null) return;
        bool swapped;
        do
        {
            swapped = false;
            var current = _head;
            while (current.Next != null)
            {
                if (Comparer<T>.Default.Compare(current.Data, current.Next.Data) < 0)
                {
                    T temp = current.Data;
                    current.Data = current.Next.Data;
                    current.Next.Data = temp;
                    swapped = true;
                }
                current = current.Next;
            }
        } while (swapped);
    }

    public List<T?> GetFashion()
    {
        var modes = new List<T?>();
        if (_head == null)
        {
            Console.WriteLine("The list is empty.");
        }

        var counts = new Dictionary<T, int>();
        var current = _head;
        while (current != null)
        {
            if (current.Data != null)
            {
                if (counts.ContainsKey(current.Data))
                {
                    counts[current.Data]++;
                }
                else
                {
                    counts[current.Data] = 1;
                }
            }
            current = current.Next;
        }

        if (counts.Count == 0)
        {
            Console.WriteLine("The list contains only null values.");
        }

        int maxCount = counts.Values.Max();

        foreach (var pair in counts)
        {
            if (pair.Value == maxCount)
            {
                modes.Add(pair.Key);
            }
        }

        return modes;
    }

    public void ShowFashions()
    {
        var modes = GetFashion();
        if (modes.Count == 0)
        {
            Console.WriteLine("No mode found.");
            return;
        }
        Console.WriteLine("Mode(s) of the list:");
        foreach (var mode in modes)
        {
            Console.WriteLine(mode);
        }
    }

    public void ShowGraphicalFashion()
    {
        var modes = GetFashion();
        if (modes.Count == 0)
        {
            Console.WriteLine("No mode found.");
            return;
        }
        Console.WriteLine("Graphical representation of mode(s):");
        foreach (var mode in modes)
        {
            Console.Write(mode + ": ");
            var count = 0;
            var current = _head;
            while (current != null)
            {
                if (EqualityComparer<T>.Default.Equals(current.Data, mode))
                {
                    count++;
                }
                current = current.Next;
            }
            for (int i = 0; i < count; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    public void ExistsOnList(T data)
    {
        var current = _head;
        while (current != null)
        {
            if (EqualityComparer<T>.Default.Equals(current.Data, data))
            {
                Console.WriteLine($"The element {data} exists in the list.");
                return;
            }
            current = current.Next;
        }
        Console.WriteLine($"The element {data} does not exist in the list.");
    }

    public void DeleteOcurrences(T data)
    {
        var current = _head;
        while (current != null)
        {
            if (EqualityComparer<T>.Default.Equals(current.Data, data))
            {
                if (current.Prev != null)
                {
                    current.Prev.Next = current.Next;
                }
                else
                {
                    _head = current.Next;
                }
                if (current.Next != null)
                {
                    current.Next.Prev = current.Prev;
                }
                else
                {
                    _tail = current.Prev;
                }
            }
            current = current.Next;
        }
    }

    public void DeleteAllOccurrences()
    {
        _head = null;
        _tail = null;
    }
}