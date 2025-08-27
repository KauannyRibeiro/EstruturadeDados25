using System;
using System.Collections.Generic;

namespace Jogo_da_Velha
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] matriz = new string[3, 3];

            List<string> indexNumeros = new List<string>();

            int index = 1;

            ImprimirTituloJogo();

            index = AlimentarMatriz(matriz, indexNumeros, index);

            ImprimirMatriz(matriz);

            string resultado = VerificarVitoria(matriz);

            Console.WriteLine(resultado);

            Console.ReadLine();
        }

        private static void ImprimirTituloJogo()
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("   JOGO DA VELHA   ");
            Console.WriteLine("-------------------\n");
        }

        private static int AlimentarMatriz(string[,] matriz, List<string> indexNumeros, int index)
        {
            string turno = "X";
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = turno;
                    indexNumeros.Add(index.ToString());
                    index++;
                    turno = (turno == "X") ? "O" : "X";
                }
            }
            return index;
        }

        private static void ImprimirMatriz(string[,] matriz)

        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($" [{matriz[i, j]}] ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private static string VerificarVitoria(string[,] matriz)
        {
            // Linhas
            for (int i = 0; i < 3; i++)
            {
                if (matriz[i, 0] == matriz[i, 1] && matriz[i, 1] == matriz[i, 2])
                    return $"Vitória na linha {i + 1} com {matriz[i, 0]}";
            }

            // Colunas
            for (int j = 0; j < 3; j++)
            {
                if (matriz[0, j] == matriz[1, j] && matriz[1, j] == matriz[2, j])
                    return $"Vitória na coluna {j + 1} com {matriz[0, j]}";
            }

            // Diagonal principal
            if (matriz[0, 0] == matriz[1, 1] && matriz[1, 1] == matriz[2, 2])
                return $"Vitória na diagonal principal com {matriz[0, 0]}";

            // Diagonal secundária
            if (matriz[0, 2] == matriz[1, 1] && matriz[1, 1] == matriz[2, 0])
                return $"Vitória na diagonal secundária com {matriz[0, 2]}";

            return "Nenhum vencedor!!";
        }
    }
}
