// DelegateExample.cs

using System;
using UnityEngine;

public class DelegateExample
{
    // Declare the delegate
    delegate int MathOperation(int a, int b);
   
    public static void Main()
    {
        // Instantiate the delegate with the Add method
        MathOperation op = Add;

        // Use the delegate to invoke the Add method;
        int result = op(10, 5);
        Debug.Log($"10 + 5 = {result}");
    }

    // Method matching the delegate signature
    static int Add( int x, int y)
    {
        return x + y;
    }
}