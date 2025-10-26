using linkedListsExham05;

var list = new DoublyLinkedList<string>();
var opc = "0";

do
{
    opc = Menu();
    switch (opc)
    {
        case "1":
            Console.Write("Enter a Item to insert at beginning: ");
            var fashionBegin = Console.ReadLine()!;
            list.InsertAtBeginning(fashionBegin);
            break;

        case "2":
            Console.Write("Enter a Item to insert at end: ");
            var fashionEnd = Console.ReadLine()!;
            list.InsertAtEnd(fashionEnd);
            break;

        case "3":
            Console.WriteLine("List Forward:");
            list.DisplayForward();
            break;

        case "4":
            Console.WriteLine("List Backward:");
            list.DisplayBackward();
            break;

        case "5":
            Console.WriteLine("List Descending:");
            list.SortDescending();
            list.PrintList();
            break;

        case "6":
            Console.WriteLine("Fashions in the list:");
            list.ShowFashions();
            break;

        case "7":
            Console.WriteLine("Graphical Fashion Graphics:");
            list.ShowGraphicalFashion();
            break;

        case "8":
            Console.WriteLine("Enter a Item to check if it exists on the list: ");
            var itemExist = Console.ReadLine()!;
            list.ExistsOnList(itemExist);
            break;

        case "9":
            Console.Write("Enter a Item to remove an occurrence: ");
            var itemRemove = Console.ReadLine()!;
            list.DeleteOcurrences(itemRemove);
            Console.WriteLine();
            Console.WriteLine($"Removed one occurrence of {itemRemove} from the list.");
            break;

        case "10":
            Console.Write("Deleting all occurrences: ");
            list.DeleteAllOccurrences();
            Console.WriteLine();
            Console.WriteLine("All occurrences have been deleted.");
            break;
    }
}
while (opc != "0");

string Menu()
{
    Console.WriteLine();
    Console.WriteLine("1.  Insert at Beginning");
    Console.WriteLine("2.  Insert at End");
    Console.WriteLine("3.  Show List Forward");
    Console.WriteLine("4.  Show List Bacward");
    Console.WriteLine("5.  Show Descending");
    Console.WriteLine("6.  Show Fashions");
    Console.WriteLine("7.  Show Graphical Fashion");
    Console.WriteLine("8.  Exist on list");
    Console.WriteLine("9.  Remove an Ocurrency");
    Console.WriteLine("10. Delete all ocurrencys");
    Console.WriteLine("0.  Exit");
    Console.WriteLine();
    Console.Write("Choose an option: ");
    Console.WriteLine();
    return Console.ReadLine()!;
}