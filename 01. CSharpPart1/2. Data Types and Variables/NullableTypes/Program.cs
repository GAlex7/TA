//Problem 12. Null Values Arithmetic

//Create a program that assigns null values to an integer and to a double variable.
//Try to print these variables at the console.
//Try to add some number or the null literal to these variables and print the result.

using System;

class NullableTypes
{
    static void Main()
    {
        int? nullAbleInteger = null;
        double? nullAbleDouble = null;
        bool nullCheck = nullAbleInteger == null && nullAbleDouble == null;

        Console.WriteLine("Integer with value Null: " + nullAbleInteger);
        Console.WriteLine("Double with value Null: " + nullAbleDouble);
        Console.WriteLine("nullAbleInteger = null & nullAbleDouble = null --> is " + nullCheck);

        nullAbleInteger += 1;
        nullAbleDouble += 1.5;

        Console.WriteLine("Integer + 1 = " + nullAbleInteger);
        Console.WriteLine("Double + 1,5 = " + nullAbleDouble);
    }
}