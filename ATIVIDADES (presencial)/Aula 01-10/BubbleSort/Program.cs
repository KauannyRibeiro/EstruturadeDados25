using BubbleSort;

Console.WriteLine("Array não ordenado: ");
Console.WriteLine(" ");

int[] arrNumbers =
    new int[] { 99, 50, -24, 0, 1 };

foreach (var number in arrNumbers)
{
    Console.Write($"[{number}] ");
}

var arrOrdered = BubbleSortOrder.Sort<int>(
        arrNumbers
        );

Console.WriteLine(" ");
Console.WriteLine("********");
Console.WriteLine(" ");
Console.WriteLine("Array Ordenado: ");
Console.WriteLine(" ");

foreach (var number in arrOrdered)
{
    Console.Write($"[{number}] ");
}