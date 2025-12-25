Console.WriteLine("Hello!");
var toDoList = new List<string>();

do {    
    Console.WriteLine("What do you want to do?");
    Console.WriteLine("[S]ee all to-dos");
    Console.WriteLine("[A]dd a to-do");
    Console.WriteLine("[R]emove a to-do");
    Console.WriteLine("[E]xit");

    string choice = Console.ReadLine() ?? String.Empty;
    if (choice == "")
    {
        Console.WriteLine("Please enter a choice.");
        continue;
    }
    switch (choice.ToUpper())
    {
        case "S":
            Console.WriteLine("You chose to see all to-dos.");
            DisplayToDos(toDoList);
            break;
        case "A":
            Console.WriteLine("Please enter a description for your to-do.");
            var description = Console.ReadLine() ?? String.Empty;
            while (description == "")
            {
                Console.WriteLine("You must enter a description.");
                description = Console.ReadLine() ?? String.Empty;
            }
            toDoList.Add(description);
            break;
        case "R":
            Console.WriteLine("Here is your current list of to-dos.");
            DisplayToDos(toDoList);
            Console.WriteLine("Enter the number of the to-do you want to remove.");
            bool isInt = int.TryParse(Console.ReadLine(), out int toRemove);
            if (isInt && toRemove > 0 && toRemove <= toDoList.Count)
            {
                toDoList.RemoveAt(toRemove - 1);
                Console.WriteLine("To-do removed.");
            }
            else
            {
                Console.WriteLine("Invalid number. No to-do removed.");
            }
            break;
        case "E":
            Console.WriteLine("Exiting the application. Goodbye!");
            return;
        default:
            Console.WriteLine("Invalid choice. Please try again.");
            break;
    }
} while (true);

void DisplayToDos(List<string> toDoList)
{
    if (toDoList.Count == 0)
    {
        Console.WriteLine("Your to-do list is empty.");
    }
    else
    {
        Console.WriteLine("Your to-dos:");
        for (int i = 0; i < toDoList.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {toDoList[i]}");
        }
    }
}

