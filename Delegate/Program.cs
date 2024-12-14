// From the .NET Core library
using System;

namespace Delegate;

// Define the delegate type (it though appear as a variable, but its a type)
public delegate int Comparison<in T>(T left, T right);

class Program
{
    
    
    // Declare an instance of that type, this is a "delegate variable"
    // Like all variables in C#, you cannot declare delegate instances directly in a namespace, or in the global namespace.
    // public static Comparison<T> comparator;
    
    //Suppose you wanted to sort a list of strings by their length. Your comparison function might be the following:
    private static int CompareLength(string left, string right) =>
        left.Length.CompareTo(right.Length);
    
    static void Main()
    {
        //Example from Microsoft docs
        if (false)
        {
            int left = 9;
            int right = 12;
        
            //invoke the delegate
            // int result = comparator(left, right);
        }

        Calculator calculator = new Calculator();
        calculator.DelegateExample();
    }
    
    
}

public delegate int MathOperation(int x, int y);
public class Calculator
{
    // Methods that match the delegate signature
    public int Add(int x, int y) => x + y;
    public int Subtract(int x, int y) => x - y;

    public void DelegateExample()
    {
        // Create delegate instances and point them to methods
        MathOperation addDelegate = Add;
        MathOperation subtractDelegate = Subtract;
            
        // Using lambda expressions to create delegate instances:
        MathOperation multiplyDelegate = (x, y) => x * y;
        
        // Multicast delegates (combining delegates):
        MathOperation multiDelegate = addDelegate + subtractDelegate; // Combine "add" and "subtract"
 
        // Invoke the delegates
        int sum = addDelegate(5, 3);
        Console.WriteLine($"Sum: {sum}");        // Output: Sum: 8
            
        int difference = subtractDelegate(5, 3);
        Console.WriteLine($"Difference: {difference}"); // Output: Difference: 2
            
        int product = multiplyDelegate(5, 3);
        Console.WriteLine($"Product: {product}"); // Output: Product: 15
 
        // Invoking a multicast delegate calls all assigned methods in sequence
        int multiResult = multiDelegate(5, 3); // addDelegate(5,3) then subtractDelegate(5,3)
        Console.WriteLine($"Multicast Result: {multiResult}"); // Output: Multicast Result: 2 (8 then 2, but only the last result is returned in this example)
 
        // To get all results from a multicast delegate, use GetInvocationList():
        System.Delegate[] delegates = multiDelegate.GetInvocationList();
        foreach (MathOperation del in delegates)
        {
            Console.WriteLine($"Result of {del.Method.Name}: {del(5, 3)}");
        }
        // Output:
        // Result of Add: 8
        // Result of Subtract: 2
    }
}