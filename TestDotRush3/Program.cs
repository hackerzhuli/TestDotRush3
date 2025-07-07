﻿namespace TestDotRush3;

class Program
{
    /// <summary>
    /// Adds two numbers <br/>
    /// Similiar to <see cref="Add3"/> but only add 2 numbers <br/>
    /// </summary>
    /// <param name="a">The first number, see <see cref="Console.WriteLine"/> from <see cref="Console"/></param>
    /// <param name="b">The second number</param>
    /// <returns>The sum of the two numbers</returns>
    /// <remarks>
    /// This method adds two numbers and returns the sum. <br/>
    /// Some other important note: <br/>
    /// This method is similiar to <see cref="Add3"/> but only add 2 numbers.
    /// </remarks>
    private static int Add(int a, int b){
        return a + b;
    }

    /// <summary>
    /// Adds three numbers <br />
    /// Similiar to <see cref="Add(int, int)"/> but only add 3 numbers <br/>
    /// </summary>
    private static int Add(int a, int b, int c){
        return a + b + c;
    }

    /// <summary>
    /// Adds two numbers <br />
    /// Similiar to <see cref="Add3"/> but only add 2 numbers <br/>
    /// </summary>
    /// <param name="a">The first number</param>
    /// <param name="b">The second number</param>
    /// <returns>The sum of the two numbers</returns>
    private static int Add2(int a, int b){
        return a + b;
    }

    /// <summary>
    /// Adds three numbers
    /// </summary>
    /// <param name="a">The first number</param>
    /// <param name="b">The second number</param>
    /// <param name="c">The third number</param>
    /// <returns>The sum of the three numbers</returns>
    /// <remarks>
    /// This method adds three numbers and returns the sum.
    /// </remarks>
    private static int Add3(int a, int b, int c)
    {
        return a + b + c;
    }

    static void Main(string[] args)
    {
        Add(1, 2);
        Add2(1, 2);
        Add3(1, 2, 3);
        Console.WriteLine("Hello, World!");
    }
}