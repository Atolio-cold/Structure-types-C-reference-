using System;

public record Coords(double X, double Y);  // Używamy 'record' zamiast 'struct'

class Program
{
    public static void Main()
    {
        var p1 = new Coords(0, 0);
        Console.WriteLine(p1);  // output: Coords { X = 0, Y = 0 }

        var p2 = p1 with { X = 3 };
        Console.WriteLine(p2);  // output: Coords { X = 3, Y = 0 }

        var p3 = p1 with { X = 1, Y = 4 };
        Console.WriteLine(p3);  // output: Coords { X = 1, Y = 4 }
    }
}


[System.Runtime.CompilerServices.InlineArray(10)]
public struct CharBuffer
{
    private char _firstElement;
}
