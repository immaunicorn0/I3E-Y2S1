using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoComponent : MonoBehaviour
{
    // Declare the variables for Task 1
    public int a;
    public int b;

    // Task 1: Function to check if two integers are equal
    void IntCompare()
    {
        if (a == b)
        {
            Debug.Log("The numbers are equal.");
        }
        else
        {
            int larger = a > b ? a : b;
            Debug.Log($"The numbers are not equal. The larger number is {larger}.");
        }
    }

    // Task 2: Function to print numbers 1 to 10 in a single line using a for loop
    void LoopNums()
    {
        string numbers = "";
        for (int i = 1; i <= 10; i++)
        {
            numbers += i + " "; // Append each number with a space for readability
        }
        Debug.Log(numbers.Trim()); // Trim to remove trailing spaces
    }

    // Task 3: Function to print "Hello World" 10 times using a while loop
    void PrintHelloWorld()
    {
        int count = 0;
        while (count < 10)
        {
            Debug.Log("Hello World");
            count++;
        }
    }

    void Update()
    {
        // Check for key presses to call different functions
        if (Input.GetKeyDown(KeyCode.E)) // 'E' key for IntCompare()
        {
            IntCompare();
        }

        if (Input.GetKeyDown(KeyCode.L)) // 'L' key for LoopNums()
        {
            LoopNums();
        }

        if (Input.GetKeyDown(KeyCode.H)) // 'H' key for PrintHelloWorld()
        {
            PrintHelloWorld();
        }
    }
}
