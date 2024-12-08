using System;

namespace Assignment_01_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {



            //#region Question 1
            //// Write a program that allows the user to enter a number then print it.
            //Console.WriteLine("Enter a number:");
            //int userInput = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"You entered: {userInput}");
            //#endregion


            //------------------------------------------------------------------------------------------------------------------------------------------

            //#region Question 2
            //// Write a program that converts a string to an integer, but the string contains non-numeric characters. And mention what will happen
            //string nonNumericString = "123"; // جربنا دي و نفعت تمام 
            ////string nonNumericString = "123abc"; //جربنا دي ومنفعتش 
            //try
            //try
            //{
            //    int result = Convert.ToInt32(nonNumericString);
            //    Console.WriteLine($"Converted result: {result}");
            //}
            //catch (FormatException ex)
            //{
            //    // Handle the exception when conversion fails
            //    Console.WriteLine($"Error: {ex.Message} (Error because the string contains non-numeric characters)");
            //}
            //#endregion





            //-------------------------------------------------------------------------------------------------------------------------------------


            #region Question 3
            // Write a program that performs a simple arithmetic operation with floating-point numbers and mention what will happen
            float a = 5.5f, b = 2.2f;
            float sum = a + b;
            Console.WriteLine($"Sum of {a} and {b} is: {sum} (Floating-point operations may have precision errors)");
            #endregion



            //-------------------------------------------------------------------------------------------------------------------------------





            //#region Question 4
            //// Write a program that extracts a substring from a given string
            //string mainString = "Hello, World!";
            //string substring = mainString.Substring(7, 5);
            //Console.WriteLine($"Extracted substring: {substring}");
            //#endregion



            //-------------------------------------------------------------------------------------------------------------------------------


            //#region Question 5
            //// Write a program that assigns one value type variable to another and modifies the value of one variable and mention what will happen
            //int x = 10, y = x;
            //y = 20;
            //Console.WriteLine($"Original value: {x}, Modified value: {y} (Value types are copied by value, so modifying one doesn't affect the other)");
            //#endregion



            //----------------------------------------------------------------------------------------------------------------------------------


            //#region Question 6
            //// Write a program that assigns one reference type variable to another and modifies the object through one variable and mention what will happen
            //int[] arr1 = { 1, 2, 3 };
            //int[] arr2 = arr1;
            //arr2[0] = 100;
            //Console.WriteLine($"arr1[0]: {arr1[0]}, arr2[0]: {arr2[0]} (Reference types share the same memory, so changes affect both)");
            //#endregion



            //------------------------------------------------------------------------------------------------------------------------------------


            //#region Question 7
            //// Write a program that takes two string variables and prints them as one variable
            //string str1 = "Hello";
            //string str2 = "World";
            //string combinedString = str1 + " " + str2;
            //Console.WriteLine($"Combined string: {combinedString}");
            //#endregion



            //---------------------------------------------------------------------------------------------------------------------------------------


            //#region Question 8
            //// Which of the following statements is correct about the given C# code snippet?
            //// int d; 
            //// d = Convert.ToInt32(!(30 < 20));
            //int d;
            //d = Convert.ToInt32(!(30 < 20)); // Result: true (1)
            //Console.WriteLine($"Value of d: {d} (1 will be assigned to d)");
            //#endregion





            //-----------------------------------------------------------------------------------------------------------------------------------------


            //#region Question 9
            //// What is the correct output for the C# code given below?
            //// Console.WriteLine(13 / 2 + " " + 13 % 2);
            //Console.WriteLine($"Output: {13 / 2} {13 % 2} (6 1)");
            //#endregion




            //---------------------------------------------------------------------------------------------------------------------------------------------



            //#region Question 10
            //// What will be the output of the C# code given below?
            //// int num = 1, z = 5;
            //// if (!(num <= 0))
            ////     Console.WriteLine(++num + z++ + " " + ++z);
            //// else
            ////     Console.WriteLine(--num + z-- + " " + --z);
            //int num = 1, z = 5;
            //if (!(num <= 0))
            //    Console.WriteLine($"{++num + z++} {++z} (7 7)");
            //else
            //    Console.WriteLine($"{--num + z--} {--z}");
            ////#endregion
        }
    }
}



