using BubbleSortVetorString;

Console.WriteLine("Array de string não ordenado: ");
Console.WriteLine(" ");

string[] arrNumbers =
    new string[] {"Ana", "Luana", "Rafael", "Joao", "Eduardo", "Maria", "Beatriz", "Carlos"};

foreach (var number in arrNumbers)
    Console.Write($"[{number}] ");

var arrOrdered = BubbleSortOrder.Sort<string>(arrNumbers);

Console.WriteLine(" ");
Console.WriteLine("*****************************");
Console.WriteLine("Array de string ordenado: ");
Console.WriteLine(" ");

foreach (var number in arrOrdered)
    Console.Write($"[{number}] ");
