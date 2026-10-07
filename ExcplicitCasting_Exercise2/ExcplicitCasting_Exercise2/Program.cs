using System;

class ExcplicitCasting_Exercise2
{
    static void Main(string[] args)
    {
        float myFloat = 123.456f;
        byte myByte = (byte)myFloat; //parenthesis() and the Specified target 

        Console.WriteLine(myByte); // outputs 123 resulting in data Loss
    }
}