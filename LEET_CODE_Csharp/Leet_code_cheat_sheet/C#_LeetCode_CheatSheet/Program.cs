using System; // Needed for Console.WriteLine, etc
using System.Collections.Generic; // Needed for List<T>

// Abstract base class demonstrating OOP concepts
public abstract class Animal
{
    // Protected property: accessible in this class and subclasses (but not outside)
    protected string Name { get; set; }

    // Constructor: sets the Name property
    public Animal(string name) => Name = name;

    // Abstract method: must be implemented by subclasses
    public abstract void Speak();

    // Virtual method: has a default implementation, but can be overridden
    public virtual void Describe() => Console.WriteLine($"I am an animal named {Name}");
}

// Interface definition: guarantees Fly() method but provides no implementation
public interface IFlyable
{
    void Fly();
}

// Bird class shows: inheritance from Animal, implements IFlyable, encapsulates data
public class Bird : Animal, IFlyable
{
    // Private field: wingSpan is only available within Bird class (encapsulation)
    private int wingSpan;

    // Constructor: passes name up to Animal, sets wingSpan
    public Bird(string name, int span) : base(name) => wingSpan = span;

    // Implements Speak() from Animal as required (polymorphism)
    public override void Speak() => Console.WriteLine($"{Name} says Chirp!");

    // Overrides Describe() from Animal, providing its own specific version
    public override void Describe() => Console.WriteLine($"I'm a bird named {Name} with wingspan {wingSpan}");

    // Implements Fly() from IFlyable
    public void Fly() => Console.WriteLine($"{Name} is flying!");
}

// Dog class inherits from Animal
public class Dog : Animal
{
    // Just calls Animal's constructor with name
    public Dog(string name) : base(name) { }

    // Implements Speak() from Animal
    public override void Speak() => Console.WriteLine($"{Name} says Woof!");
}

// Utility class for common list and string/array tasks (great for LeetCode)
public class CheatSheet
{
    public void ListExamples()
    {
        // List Creation Examples:
        List<int> emptyList = new List<int>(); // Creates a new empty list of integers
        List<int> copyList = new List<int>(emptyList); // Makes a new list, copying another
        List<int> initializedList = new List<int> { 1, 2, 3, 4 }; // List initialized with numbers

        // Basic List Operations:
        initializedList.Add(3);        // Add 3 to the end of the list
        initializedList.Remove(3);     // Remove the first occurrence of 3
        initializedList.RemoveAt(0);   // Remove element at index 0
        initializedList.Sort();        // Sort the list in ascending order
        initializedList.Reverse();     // Reverse the list in-place

        bool contains = initializedList.Contains(3); // Check if 3 is in list (returns true/false)
        int idx = initializedList.IndexOf(3);        // Returns index of first 3, or -1 if not found
        int count = initializedList.Count;           // Number of items in the list

        // Convert list of ints to list of strings:
        List<string> stringList = initializedList.ConvertAll(i => i.ToString());

        // --- String and Char Array operations (common for LeetCode) ---
        string name = "Lisa";

        char[] cArr = name.ToCharArray();  // Split a string into array of characters

        Array.Sort(cArr);      // Sort the char array alphabetically
        Array.Reverse(cArr);   // Reverse the order of the char array

        string newStr = new string(cArr);  // Combine char array into a new string
    }

    public static void Main()
    {
        // Create instances of Bird and Dog to demonstrate OOP concepts
        Bird myBird = new Bird("Tweety", 5);
        Dog myDog = new Dog("Rex");

        myBird.Describe(); // Polymorphism: calls Bird's Describe()
        myBird.Speak();    // Polymorphism: calls Bird's Speak()
        myBird.Fly();      // Calls Fly() from IFlyable

        myDog.Describe();  // Polymorphism: calls Animal's Describe() since Dog doesn't override it
        myDog.Speak();     // Polymorphism: calls Dog's Speak()

        // Demonstrate list and string/array operations
        CheatSheet cheatSheet = new CheatSheet();
        cheatSheet.ListExamples();

        Console.WriteLine("Cheat sheet examples executed successfully!");
    }



}