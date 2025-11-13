using System;
using System.Collections.Generic;

class Program
{  static void Main(string[] args)
    {
    
        string[] nomes = new string[10];

        for (int i = 0; i < nomes.Length; i++)
        {
            Console.WriteLine($" ");
            Console.WriteLine($"Digite o nome {i + 1}: ");
            nomes[i] = Console.ReadLine()!;

        }

        Console.WriteLine($"================================");
        Console.WriteLine("Digite o nome que deseja encontrar: ");
        string nomeProcurado = Console.ReadLine()!;

        int posicao = -1;
        int contador = 0;

        for (int i = 0; i < nomes.Length; i++)
        {
            // Compara o nome atual com o nome procurado (ignorando maiúsculas/minúsculas)
            if (nomes[i].Equals(nomeProcurado, StringComparison.OrdinalIgnoreCase))
            {
                posicao = i;
                contador = i++;
                break;
            }
        }

        if (posicao == -1)
        {
            Console.WriteLine("Não encontrado.");
        
        }
        else
        {
            Console.WriteLine($"{nomeProcurado} encontrado na posição: {contador}");}
    }
}