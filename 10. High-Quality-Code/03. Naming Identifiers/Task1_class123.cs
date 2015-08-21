using System;

public class Tools
{
    private const int MaxCount = 6;

    public static void Main()
    {
        Tools.BoolClass newBool = new Tools.BoolClass();
        newBool.BoolToString(true);
    }

    public class BoolClass
    {
        public void BoolToString(bool b)
        {
            string boolAsString = b.ToString();
            Console.WriteLine(boolAsString);
        }
    }
}