using System.Runtime.Intrinsics.X86;

Console.WriteLine(
    "Invertendo palavras com pilhas (Stacks)"
);

Stack<char> chars = new Stack<char>();
foreach (var c in "KAUANNY")
    chars.Push(c);

while (chars.Count > 0)
    Console.WriteLine(chars.Pop());

Console.WriteLine("");