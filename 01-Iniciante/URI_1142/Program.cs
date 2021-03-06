﻿using System;

namespace URI_1142
{
    class Program
    {
        /*
        Escreva um programa que leia um valor inteiro N. Este N é a quantidade de linhas de saída que serão apresentadas na execução do programa.
        Entrada: O arquivo de entrada contém um número inteiro positivo N.
        Saída: Imprima a saída conforme o exemplo fornecido.
        Exemplo de Entrada 	Exemplo de Saída
        7                   1 2 3 PUM
                            5 6 7 PUM
                            9 10 11 PUM
                            13 14 15 PUM
                            17 18 19 PUM
                            21 22 23 PUM
                            25 26 27 PUM
         */

        static void Main( string[] args )
        {
            int n, cont = 1;
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= (n * 4); i++)
            {
                if (cont < 4)
                {
                    Console.Write($"{i} ");
                    cont++;
                }
                else
                {
                    Console.Write("PUM\n");
                    cont = 1;
                }
            }
        }
    }
}
