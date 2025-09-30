// See https://aka.ms/new-console-template for more information

Console.WriteLine("Digite uma palavra para descobrir se é ou não um políndromo: ");
string? palavra = Console.ReadLine();

//cria uma pilha
Stack<char> pilha = new Stack<char>();

//Percorre todas as chars do nome.
foreach (var c in palavra)
    pilha.Push(c);

string arvalap = "";

while (pilha.Count > 0)
    arvalap += pilha.Pop();

if (arvalap.ToLower() == palavra.ToLower())

    Console.WriteLine("É UM PALINDROMO!! :D ");

else

    Console.WriteLine("NÃO É UM PALINDROMO :p ");


