using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

class TodoList
{
    static void Main()
    {
        Todo todo = new Todo("Finish .net");

        Console.WriteLine(todo.name);
        List<Todo> pendingList = new List<Todo>();
        List<Todo> completedList = new List<Todo>();
        while (true)
        {
            Console.WriteLine("Select an Option: ");
            Console.WriteLine("1. Add new Item");
            Console.WriteLine("2. Complete an Item");
            Console.WriteLine("3. List of Items");
            Console.WriteLine("q. Quit");
            string? input = Console.ReadLine();
            if (input == "1")
            {
                Console.WriteLine();
                Console.Write("Name the item: ");
                string? name = Console.ReadLine();
                Console.WriteLine();
                if (name == null || name == " ")
                {
                    Console.WriteLine("Invalid Input");
                    continue;
                }
                pendingList.Add(new Todo(name));
                Console.WriteLine("Todo Added");
            }
            else if (input == "2")
            {
                Console.WriteLine();
                Console.WriteLine("Enter Todo number: ");
                int i = 0;
                while (i < pendingList.Count)
                {
                    Console.WriteLine($"{i + 1}. {pendingList[i].name}");
                    i++;
                }
                int index = Int32.Parse(Console.ReadLine());
                if (0 <= index - 1 && index - 1 <= pendingList.Count)
                {
                    completedList.Add(pendingList[index - 1]);
                    pendingList.RemoveAt(index - 1);
                }
                Console.WriteLine("Todo Item Completed.");
            }
            else if (input == "3")
            {
                Console.WriteLine();
                int i = 0;
                Console.WriteLine("Pending Todos: ");
                while (i < pendingList.Count)
                {
                    Console.WriteLine(pendingList[i].name);
                    i++;
                }
                i = 0;
                Console.WriteLine();
                Console.WriteLine("Completed Todos: ");
                while (i < completedList.Count)
                {
                    Console.WriteLine(completedList[i].name);
                    i++;
                }
            }
            else if (input == "q")
            {
                Console.WriteLine("Quit successful");
                break;
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}