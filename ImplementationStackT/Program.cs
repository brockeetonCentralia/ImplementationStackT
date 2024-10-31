using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Stack<string> editorActions = new Stack<string>();

        // Simulate user actions in the text editor
        editorActions.Push("Typed 'Hello'");
        editorActions.Push("Deleted 'Hello'");
        editorActions.Push("Typed 'World'");

        Console.WriteLine("Current Stack:");
        PrintStack(editorActions);

        // Undo the last action
        Console.WriteLine("\nUndo last action: " + editorActions.Pop());

        Console.WriteLine("\nCurrent Stack after undo:");
        PrintStack(editorActions);

        // Peek at the next action to undo
        Console.WriteLine("\nNext action to undo: " + editorActions.Peek());

        editorActions.Pop();
        Console.WriteLine(editorActions.Peek());

        // Check how many actions are in the stack
        Console.WriteLine("\nNumber of actions in stack: " + editorActions.Count);
    }

    // Helper function to print the stack contents
    static void PrintStack(Stack<string> stack)
    {
        foreach (var action in stack)
        {
            Console.WriteLine(action);
        }
    }
}