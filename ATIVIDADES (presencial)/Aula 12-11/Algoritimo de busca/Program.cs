/* Para um vetor de String contendo 10 nomes, escreva um 
algoritmo de busca que solicite ao usuário a entrada desses dados, um por vez, a ser pesquisado depois pelo 
usuário e efetue uma busca no vetor, caso encontrado uma ocorrência válida,
retorne em que posição numero do vetor nao ordenado se encontra, do contrário exiba uma mensagem informando 
'não encontrado'. */

using System;
using System.Collections.Generic;

class Program
{  static void Main(string[] args)
    {
        // Cria um vetor para armazenar os 10 nomes
        string[] nomes = new string[10];

        // Solicita ao usuário a entrada dos 10 nomes
        for (int i = 0; i < nomes.Length; i++)
        {
            Console.WriteLine($" ");
            Console.WriteLine($"Digite o nome {i + 1}: ");
            nomes[i] = Console.ReadLine()!;

        }

        // Solicita ao usuário o nome a ser pesquisado
        Console.WriteLine($"================================");
        Console.WriteLine("Digite o nome que deseja encontrar: ");
        string nomeProcurado = Console.ReadLine()!;

        int posicao = -1;
        int contador = 0;

        // Percorre o vetor para buscar o nome
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

        // Verifica se o nome foi encontrado e exibe o resultado da busca

        if (posicao == -1)
        {
            Console.WriteLine("Não encontrado.");
        
        }
        else
        {
            Console.WriteLine($"{nomeProcurado} encontrado na posição: {contador}");}
    }
}