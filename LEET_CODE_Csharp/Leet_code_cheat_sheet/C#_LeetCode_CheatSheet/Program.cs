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

        // =================== C# Cheat Sheet List and Array Methods ===================
        //===========Sections==============
        // ========== LIST METHODS ==========
        // ========== ARRAY CREATION: CHAR ==========
        // ========== CHAR TO DIGIT TRICK ==========
        // ========== ARRAY CREATION: INT ==========
        // ========== ARRAY CREATION: STRING ==========
        // ========== ARRAY CREATION: 2D ARRAYS ==========
        // ========== ARRAY PROPERTIES ==========
        // ========== ARRAY STATIC METHODS ==========
        // ========== CONVERSION METHODS ==========
        // ========== STRINGBUILDER METHODS ==========
        // ========== STRING PROPERTIES ==========
        // ========== STRING SEARCHING ==========
        // ========== STRING MODIFYING ==========
        // ========== STRING SPLITTING / JOINING ==========
        // ========== STRING COMPARISON ==========
        // ========== CHAR CHECKING METHODS ==========
        // ========== STRING USEFUL TRICKS ==========
        // ========== DICTIONARY DECLARATION ==========
        // ========== DICTIONARY ADDING / UPDATING ==========
        // ========== DICTIONARY ACCESSING ==========
        // ========== DICTIONARY REMOVING ==========
        // ========== DICTIONARY PROPERTIES ==========
        // ========== DICTIONARY ITERATING ==========
        // ========== DICTIONARY FREQUENCY COUNT PATTERN ==========
        // ========== STACK METHODS ==========
        // ========== STACK VALID PARENTHESES PATTERN ==========
        // ========== QUEUE METHODS ==========
        // ========== QUEUE BFS PATTERN ==========
        // ========== HASHSET METHODS ==========
        // ========== HASHSET SET OPERATIONS ==========
        // ========== HASHSET CONTAINS DUPLICATE PATTERN ==========
        // ========== PRIORITYQUEUE METHODS ==========
        // ========== PRIORITYQUEUE MIN-HEAP ==========
        // ========== PRIORITYQUEUE MAX-HEAP ==========
        // ========== PRIORITYQUEUE K CLOSEST / K LARGEST PATTERN ==========

        // ========== LIST DECLARATION ==========
        // List<int> my_list = new List<int>();

        // ========== LIST METHODS ==========
        // my_list.Add(1);                  // Adds 1 to the end of the list
        // my_list.Remove(1);               // Removes the first occurrence of value 1
        // my_list.RemoveAt(1);             // Removes the element at index 1
        // my_list.Insert(index, value);    // Inserts value at the specified index
        // my_list.IndexOf(item);           // Returns the index of item (-1 if not found)
        // my_list.Contains(item);          // Returns true if item exists in the list
        // my_list.Count;                   // Returns the number of elements (property)
        // my_list.Sort();                  // Sorts the list in ascending order
        // my_list.Reverse();               // Reverses the list in place
        // my_list.Clear();                 // Removes all elements from the list
        // my_list.ToArray();               // Converts the list to an array
        // my_list.AddRange(otherList);     // Adds all elements from another collection
        // my_list.RemoveAll(x => x > 5);  // Removes all elements matching a condition
        // my_list.Find(x => x > 5);       // Returns the first element matching a condition
        // my_list.FindAll(x => x > 5);    // Returns a list of all elements matching a condition
        // my_list.FindIndex(x => x > 5);  // Returns the index of the first match (-1 if not found)
        // my_list.ForEach(x => Console.WriteLine(x)); // Performs an action on each element

        // ========== LIST CONVERSION ==========
        // List<string> my_str = my_list.ConvertAll(i => i.ToString()); // Convert List<int> to List<string>

        // ========== ARRAY CREATION: CHAR ==========
        // char[] cArr = name.ToCharArray();              // String to char array
        // char[] cArr = name[i].ToString().ToCharArray(); // Single char at index i to char array
        // char[] cArr = new char[5];                     // Declare empty char array of size 5
        // char[] cArr = { 'h', 'e', 'l', 'l', 'o' };   // Declare and initialize char array
        // string n_str = new string(cArr);               // Char array back to string

        // ========== CONVERT CLASS ==========
        // Convert.ToInt32(cArr[i]);       // char → ASCII int       e.g., 'a' → 97
        // Convert.ToChar(97);             // int  → char            e.g., 97  → 'a'
        // Convert.ToString(cArr[i]);      // char → string          e.g., 'a' → "a"
        // Convert.ToDouble(cArr[i]);      // char → double (ASCII)  e.g., 'a' → 97.0

        // ========== CHAR TO DIGIT TRICK ==========
        // int n = c - '0';               // char digit → int   e.g., '7' → 7
        //                                 // Works because: ASCII('7') - ASCII('0') = 55 - 48 = 7
        //                                 // NOTE: It's '0' (digit zero), NOT 'O' (letter O)

        // ========== ARRAY CREATION: INT ==========
        // int[] nums = new int[5];                       // Declare empty int array of size 5 (all default to 0)
        // int[] nums = { 1, 2, 3, 4, 5 };               // Declare and initialize int array
        // int[] nums = new int[] { 1, 2, 3, 4, 5 };     // Declare and initialize (explicit)
        // int[] nums = new int[5] { 1, 2, 3, 4, 5 };    // Declare with size and initialize

        // ========== ARRAY CREATION: STRING ==========
        // string[] names = new string[3];                          // Declare empty string array of size 3 (all default to null)
        // string[] names = { "Alice", "Bob", "Charlie" };          // Declare and initialize string array
        // string[] names = new string[] { "Alice", "Bob", "Charlie" }; // Declare and initialize (explicit)
        // string[] names = new string[3] { "Alice", "Bob", "Charlie" }; // Declare with size and initialize
        // string[] words = sentence.Split(' ');                    // Split a string into a string array by delimiter
        // string joined = string.Join(", ", names);                // Join a string array back into a single string

        // ========== ARRAY CREATION: 2D ARRAYS ==========
        // int[,] grid = new int[3, 3];                            // Declare a 3x3 2D array (all default to 0)
        // int[,] grid = { {1,2,3}, {4,5,6}, {7,8,9} };           // Declare and initialize a 2D array
        // grid[0, 1];                                             // Access row 0, column 1 → 2
        // grid.GetLength(0);                                      // Number of rows → 3
        // grid.GetLength(1);                                      // Number of columns → 3

        // ========== ARRAY PROPERTIES ==========
        // cArr.Length;                                    // Returns the number of elements (property)

        // ========== ARRAY STATIC METHODS ==========
        // Array.IndexOf(cArr, 'a');                       // Returns the index of 'a' (-1 if not found)
        // Array.LastIndexOf(cArr, 'a');                   // Returns the LAST index of 'a' (-1 if not found)
        // Array.Exists(cArr, e => e == 'a');              // Returns true if 'a' exists in the array
        // Array.Find(cArr, e => e == 'a');                // Returns the first element matching a condition
        // Array.FindAll(cArr, e => e > 'a');              // Returns an array of all matching elements
        // Array.FindIndex(cArr, e => e == 'a');           // Returns the index of the first match (-1 if not found)
        // Array.FindLast(cArr, e => e == 'a');            // Returns the last element matching a condition
        // Array.FindLastIndex(cArr, e => e == 'a');       // Returns the index of the last match (-1 if not found)
        // Array.Sort(cArr);                               // Sorts the array in ascending order
        // Array.Reverse(cArr);                            // Reverses the array in place
        // Array.Clear(cArr, 0, cArr.Length);              // Sets all elements to default value (startIndex, length)
        // Array.Copy(source, dest, length);               // Copies elements from one array to another
        // Array.Resize(ref cArr, 10);                     // Resizes the array to a new size
        // Array.TrueForAll(cArr, e => e > 'a');           // Returns true if ALL elements match a condition
        // Array.ConvertAll(cArr, c => c.ToString());      // Converts all elements using a converter function
        // Array.Fill(nums, 0);                            // Fills the entire array with a value (.NET Core+)
        // Fills the entire array with a value (.NET Core+)

        // ========== STRINGBUILDER DECLARATION ==========
        // StringBuilder sb = new StringBuilder();          // Empty
        // StringBuilder sb = new StringBuilder("hello");   // Initialize with string
        // StringBuilder sb = new StringBuilder(100);       // Initialize with capacity (optimization)

        // ========== STRINGBUILDER METHODS ==========
        // sb.Append("world");            // Appends "world" to the end
        // sb.Append('!');                 // Appends a single character
        // sb.AppendLine("text");         // Appends "text" + newline
        // sb.Insert(0, "start");         // Inserts "start" at index 0
        // sb.Remove(0, 5);               // Removes 5 characters starting at index 0
        // sb.Replace("old", "new");      // Replaces all occurrences of "old" with "new"
        // sb.Replace('a', 'b');          // Replaces all occurrences of char 'a' with 'b'
        // sb.Clear();                    // Removes all characters
        // sb.ToString();                 // Converts StringBuilder to string
        // sb.Length;                     // Returns the current length (property)
        // sb[i];                         // Access character at index i
        // sb[i] = 'x';                  // Set character at index i

        // ========== WHY USE STRINGBUILDER? ==========
        // string s = "";
        // for (int i = 0; i < 10000; i++)
        //     s += "a";                  // BAD — O(n) each time → O(n²) total
        //
        // StringBuilder sb = new StringBuilder();
        // for (int i = 0; i < 10000; i++)
        //     sb.Append("a");            // GOOD — O(1) amortized → O(n) total
        // string result = sb.ToString();

        // ========== COMMON LEETCODE PATTERN: REVERSE STRING ==========
        // StringBuilder sb = new StringBuilder(str);
        // int left = 0, right = sb.Length - 1;
        // while (left < right)
        // {
        //     char temp = sb[left];
        //     sb[left] = sb[right];
        //     sb[right] = temp;
        //     left++;
        //     right--;
        // }
        // return sb.ToString();

        // ========== STRING PROPERTIES ==========
        // str.Length;                              // Returns length of string (property)

        // ========== SEARCHING ==========
        // str.Contains("abc");                    // Returns true if "abc" is found in str
        // str.StartsWith("abc");                  // Returns true if str starts with "abc"
        // str.EndsWith("abc");                    // Returns true if str ends with "abc"
        // str.IndexOf("abc");                     // Returns first index of "abc" (-1 if not found)
        // str.LastIndexOf("abc");                 // Returns last index of "abc" (-1 if not found)

        // ========== MODIFYING (returns new string — strings are immutable!) ==========
        // str.ToUpper();                          // "hello" → "HELLO"
        // str.ToLower();                          // "HELLO" → "hello"
        // str.Trim();                             // Removes leading/trailing whitespace
        // str.TrimStart();                        // Removes leading whitespace
        // str.TrimEnd();                          // Removes trailing whitespace
        // str.Replace("old", "new");             // Replaces all occurrences of "old" with "new"
        // str.Replace('a', 'b');                 // Replaces all occurrences of char 'a' with 'b'
        // str.Remove(startIndex);                // Removes everything from startIndex to end
        // str.Remove(startIndex, count);         // Removes count characters starting at startIndex
        // str.Substring(startIndex);             // Returns substring from startIndex to end
        // str.Substring(startIndex, length);     // Returns substring of given length
        // str.PadLeft(10, '0');                  // Pads left with '0' to total length 10: "42" → "0000000042"
        // str.PadRight(10, '.');                 // Pads right with '.' to total length 10

        // ========== SPLITTING / JOINING ==========
        // string[] words = str.Split(' ');        // Splits by space into array
        // string[] words = str.Split(',', ' ');   // Splits by multiple delimiters
        // string joined = string.Join(" ", words);// Joins array into string with separator
        // string concat = string.Concat(words);   // Joins array with no separator

        // ========== COMPARISON ==========
        // str.Equals("other");                   // Case-sensitive comparison
        // str.Equals("other", StringComparison.OrdinalIgnoreCase); // Case-insensitive
        // string.Compare(str1, str2);            // Returns -1, 0, or 1
        // string.IsNullOrEmpty(str);             // Returns true if null or ""
        // string.IsNullOrWhiteSpace(str);        // Returns true if null, "", or only whitespace

        // ========== CHAR CHECKING METHODS (on individual characters) ==========
        // char.IsLetter(c);                      // Returns true if c is a letter (a-z, A-Z)
        // char.IsDigit(c);                       // Returns true if c is a digit (0-9)
        // char.IsLetterOrDigit(c);               // Returns true if c is a letter or digit
        // char.IsUpper(c);                       // Returns true if c is uppercase
        // char.IsLower(c);                       // Returns true if c is lowercase
        // char.IsWhiteSpace(c);                  // Returns true if c is a whitespace character
        // char.ToUpper(c);                       // Converts c to uppercase
        // char.ToLower(c);                       // Converts c to lowercase

        // ========== USEFUL TRICKS ==========
        // str.ToCharArray();                      // Converts string to char array
        // new string(charArray);                  // Converts char array back to string
        // $"Hello {name}, you are {age}";        // String interpolation
        // int.Parse("123");                       // String to int — throws if invalid
        // int.TryParse("123", out int num);      // Safe string to int — returns true/false
        // num.ToString();                         // Int to string

        // ========== DICTIONARY DECLARATION ==========
        // Dictionary<string, int> dict = new Dictionary<string, int>();
        // Dictionary<char, int> freq = new Dictionary<char, int>();    // Common for frequency counting

        // ========== ADDING / UPDATING ==========
        // dict["apple"] = 5;                      // Adds or overwrites key "apple" with value 5
        // dict.Add("banana", 3);                  // Adds key "banana" — throws exception if key already exists
        // dict.TryAdd("banana", 3);              // Adds only if key doesn't exist — returns true/false

        // ========== ACCESSING ==========
        // int val = dict["apple"];                // Gets value for key "apple" — throws if key not found
        // dict.TryGetValue("apple", out int val); // Safe access — returns true/false, stores value in val
        // dict.ContainsKey("apple");              // Returns true if key exists
        // dict.ContainsValue(5);                  // Returns true if value exists (slow — O(n))

        // ========== REMOVING ==========
        // dict.Remove("apple");                   // Removes key "apple" — returns true/false
        // dict.Remove("apple", out int val);      // Removes and outputs the value
        // dict.Clear();                           // Removes all key-value pairs

        // ========== PROPERTIES ==========
        // dict.Count;                             // Returns the number of key-value pairs
        // dict.Keys;                              // Returns a collection of all keys
        // dict.Values;                            // Returns a collection of all values

        // ========== ITERATING ==========
        // foreach (KeyValuePair<string, int> kvp in dict) { }  // Loop through key-value pairs
        // foreach (var kvp in dict) { }                         // Same thing with var
        // foreach (string key in dict.Keys) { }                 // Loop through keys only
        // foreach (int val in dict.Values) { }                  // Loop through values only

        // ========== COMMON LEETCODE PATTERN: FREQUENCY COUNT ==========
        // foreach (char c in str)
        // {
        //     if (dict.ContainsKey(c))
        //         dict[c]++;
        //     else
        //         dict[c] = 1;
        // }
        //
        // // OR shorter with TryGetValue:
        // foreach (char c in str)
        // {
        //     dict.TryGetValue(c, out int count);  // count defaults to 0 if key not found
        //     dict[c] = count + 1;
        // }


        // ========== STACK DECLARATION LIFO - Last In, First Out ==========
        // Stack<int> stack = new Stack<int>();
        // Stack<char> stack = new Stack<char>();

        // ========== STACK METHODS ==========
        // stack.Push(1);                  // Pushes 1 onto the top of the stack
        // stack.Pop();                    // Removes and returns the top element — throws if empty
        // stack.Peek();                   // Returns the top element WITHOUT removing it — throws if empty
        // stack.Contains(1);              // Returns true if 1 exists in the stack
        // stack.Count;                    // Returns the number of elements (property)
        // stack.Clear();                  // Removes all elements from the stack
        // stack.TryPop(out int val);     // Safe pop — returns true/false, stores value in val
        // stack.TryPeek(out int val);    // Safe peek — returns true/false, stores value in val
        // stack.ToArray();                // Converts stack to array (top of stack = index 0)
        // stack.ToList();                 // Converts stack to list

        // ========== COMMON LEETCODE PATTERN: VALID PARENTHESES ==========
        // Stack<char> stack = new Stack<char>();
        // foreach (char c in s)
        // {
        //     if (c == '(' || c == '[' || c == '{')
        //         stack.Push(c);
        //     else
        //     {
        //         if (stack.Count == 0) return false;
        //         char top = stack.Pop();
        //         if (c == ')' && top != '(') return false;
        //         if (c == ']' && top != '[') return false;
        //         if (c == '}' && top != '{') return false;
        //     }
        // }
        // return stack.Count == 0;

        // ========== QUEUE DECLARATION FIFO - First In, First Out ==========
        // Queue<int> queue = new Queue<int>();
        // Queue<string> queue = new Queue<string>();

        // ========== QUEUE METHODS ==========
        // queue.Enqueue(1);               // Adds 1 to the end of the queue
        // queue.Dequeue();                // Removes and returns the front element — throws if empty
        // queue.Peek();                   // Returns the front element WITHOUT removing it — throws if empty
        // queue.Contains(1);              // Returns true if 1 exists in the queue
        // queue.Count;                    // Returns the number of elements (property)
        // queue.Clear();                  // Removes all elements from the queue
        // queue.TryDequeue(out int val); // Safe dequeue — returns true/false, stores value in val
        // queue.TryPeek(out int val);    // Safe peek — returns true/false, stores value in val
        // queue.ToArray();                // Converts queue to array (front = index 0)
        // queue.ToList();                 // Converts queue to list

        // ========== COMMON LEETCODE PATTERN: BFS ==========
        // Queue<int> queue = new Queue<int>();
        // HashSet<int> visited = new HashSet<int>();
        // queue.Enqueue(startNode);
        // visited.Add(startNode);
        // while (queue.Count > 0)
        // {
        //     int node = queue.Dequeue();
        //     foreach (int neighbor in graph[node])
        //     {
        //         if (!visited.Contains(neighbor))
        //         {
        //             visited.Add(neighbor);
        //             queue.Enqueue(neighbor);
        //         }
        //     }
        // }


        // ========== HASHSET DECLARATION ==========
        // HashSet<int> set = new HashSet<int>();
        // HashSet<string> set = new HashSet<string>();
        // HashSet<int> set = new HashSet<int>(myList);   // Initialize from a list/collection

        // ========== HASHSET METHODS ==========
        // set.Add(1);                     // Adds 1 to the set — returns false if already exists
        // set.Remove(1);                  // Removes 1 from the set — returns true/false
        // set.Contains(1);                // Returns true if 1 exists — O(1) lookup!
        // set.Count;                      // Returns the number of elements (property)
        // set.Clear();                    // Removes all elements from the set

        // ========== SET OPERATIONS ==========
        // set.UnionWith(otherSet);        // Adds all elements from otherSet (OR)
        // set.IntersectWith(otherSet);    // Keeps only elements that exist in BOTH sets (AND)
        // set.ExceptWith(otherSet);       // Removes all elements that exist in otherSet (MINUS)
        // set.SymmetricExceptWith(otherSet); // Keeps only elements in ONE set but not both (XOR)
        // set.IsSubsetOf(otherSet);       // Returns true if all elements are in otherSet
        // set.IsSupersetOf(otherSet);     // Returns true if set contains all elements of otherSet
        // set.Overlaps(otherSet);         // Returns true if any elements are shared
        // set.SetEquals(otherSet);        // Returns true if both sets have the exact same elements

        // ========== CONVERSION ==========
        // set.ToArray();                  // Converts set to array
        // set.ToList();                   // Converts set to list

        // ========== COMMON LEETCODE PATTERN: CONTAINS DUPLICATE ==========
        // HashSet<int> seen = new HashSet<int>();
        // foreach (int num in nums)
        // {
        //     if (seen.Contains(num))
        //         return true;             // Duplicate found!
        //     seen.Add(num);
        // }
        // return false;
        //
        // // OR one-liner:
        // return nums.Length != new HashSet<int>(nums).Count;

        // ========== PRIORITYQUEUE DECLARATION ==========
        // PriorityQueue<string, int> pq = new PriorityQueue<string, int>();  // Min-heap by default
        // PriorityQueue<int, int> pq = new PriorityQueue<int, int>();        // Element and priority can be same type

        // ========== PRIORITYQUEUE METHODS ==========
        // pq.Enqueue("task", 3);          // Adds "task" with priority 3 (lower number = higher priority)
        // pq.Dequeue();                   // Removes and returns the element with the LOWEST priority value
        // pq.Peek();                      // Returns the element with the lowest priority WITHOUT removing
        // pq.TryDequeue(out string elem, out int priority); // Safe dequeue — returns true/false
        // pq.TryPeek(out string elem, out int priority);    // Safe peek — returns true/false
        // pq.Count;                       // Returns the number of elements (property)
        // pq.Clear();                     // Removes all elements
        // pq.EnqueueDequeue("task", 3);  // Enqueue then immediately dequeue min — more efficient than doing both

        // ========== MIN-HEAP (default behavior) ==========
        // PriorityQueue<int, int> minHeap = new PriorityQueue<int, int>();
        // minHeap.Enqueue(5, 5);          // priority 5
        // minHeap.Enqueue(1, 1);          // priority 1
        // minHeap.Enqueue(3, 3);          // priority 3
        // minHeap.Dequeue();              // Returns 1 (lowest priority value first)

        // ========== MAX-HEAP (use custom comparer) ==========
        // PriorityQueue<int, int> maxHeap = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => b - a));
        // maxHeap.Enqueue(5, 5);          // priority 5
        // maxHeap.Enqueue(1, 1);          // priority 1
        // maxHeap.Enqueue(3, 3);          // priority 3
        // maxHeap.Dequeue();              // Returns 5 (highest priority value first)

        // ========== COMMON LEETCODE PATTERN: K CLOSEST / K LARGEST ==========
        // // Find the k largest elements
        // PriorityQueue<int, int> minHeap = new PriorityQueue<int, int>();
        // foreach (int num in nums)
        // {
        //     minHeap.Enqueue(num, num);
        //     if (minHeap.Count > k)
        //         minHeap.Dequeue();       // Remove smallest, keeping k largest
        // }
        // return minHeap.Dequeue();       // The kth largest element

    }



}