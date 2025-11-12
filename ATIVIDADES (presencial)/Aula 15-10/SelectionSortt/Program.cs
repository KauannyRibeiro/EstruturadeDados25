int[] integerValues = { -11, 12, -42, 0, 1, 90, 68, 6, -9 };
SelectionSortt.SelectionSort.Sort(integerValues);

Console.WriteLine("Vetor de inteiros");
Console.WriteLine(string.Join(",", integerValues));

Console.WriteLine("********************************");

Console.WriteLine("Vetor de nomes");
string[] stringValues = { "Bozonaro", "LombrigaBR", "Virginia", "Juliana", "Mc Lan", "Ze Felipe", "Luan Pereira" };
SelectionSortt.SelectionSort.Sort(stringValues);
Console.WriteLine(string.Join(",", stringValues));
