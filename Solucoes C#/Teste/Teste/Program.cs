// Para ler e escrever dados em C#, utilizamos os seguintes métodos da classe Console:
// - Console.ReadLine: lê UMA linha com dado(s) de Entrada (Inputs) do usuário;
// - Console.WriteLine: imprime um texto de Saída (Output) e pulando uma linha.

using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1 = int.Parse(Console.ReadLine());
            int valor2 = int.Parse(Console.ReadLine());
            int valor3 = int.Parse(Console.ReadLine());
            int valor4 = int.Parse(Console.ReadLine());
            int valor5 = int.Parse(Console.ReadLine());

            int quantidadePares = 0;
            int quantidadeImpares = 0;
            int quantidadePositivos = 0;
            int quantidadeNegativos = 0;

            //TODO: Crie as condições necessárias para calcular cada uma das quantidades.
            //Observação: Caso queira usar um array uma lista para seus valores, fique à vontade...
            if (valor1 % 2 == 0)
                quantidadePares++;
            else
                quantidadeImpares++;

            if (valor1 > 0)
                quantidadePositivos++;
            else if (valor1 < 0)
                quantidadeNegativos++;

            if (valor2 % 2 == 0)
                quantidadePares++;
            else
                quantidadeImpares++;

            if (valor2 > 0)
                quantidadePositivos++;
            else if (valor2 < 0)
                quantidadeNegativos++;

            if (valor3 % 2 == 0)
                quantidadePares++;
            else
                quantidadeImpares++;

            if (valor3 > 0)
                quantidadePositivos++;
            else if (valor3 < 0)
                quantidadeNegativos++;

            if (valor4 % 2 == 0)
                quantidadePares++;
            else
                quantidadeImpares++;

            if (valor4 > 0)
                quantidadePositivos++;
            else if (valor4 < 0)
                quantidadeNegativos++;

            if (valor5 % 2 == 0)
                quantidadePares++;
            else
                quantidadeImpares++;

            if (valor5 > 0)
                quantidadePositivos++;
            else if (valor5 < 0)
                quantidadeNegativos++;

            Console.WriteLine("{0} par(es)", quantidadePares);
            Console.WriteLine("{0} impar(es)", quantidadeImpares);
            Console.WriteLine("{0} positivo(s)", quantidadePositivos);
            Console.WriteLine("{0} negativo(s)", quantidadeNegativos);

            
            //OUTRA SOLUÇÃO
            /*List<int> quantidas = new List<int>();

            quantidas.Add(valor1);
            quantidas.Add(valor2);
            quantidas.Add(valor3);
            quantidas.Add(valor4);
            quantidas.Add(valor5);

            foreach (int i in quantidas)
            {
                if (i == 0)
                {
                    quantidadePares++;
                }
                if (i < 0)
                {
                    quantidadeNegativos++;
                    int novo = Math.Abs(i);
                    Console.WriteLine(novo);
                    if (novo % 2 == 1)
                    {
                        quantidadeImpares++;
                    }
                    else
                    {
                        quantidadePares++;
                    }

                }
                else if (i > 0) 
                { 
                    quantidadePositivos++;
                    if (i % 2 == 1)
                    {
                        quantidadeImpares++;
                    }
                    else
                    {
                        quantidadePares++;
                    }
                }
            }


            Console.WriteLine($"Total de Pares: {quantidadePares}");
            Console.WriteLine($"Total de Impares: {quantidadeImpares}");
            Console.WriteLine($"Total de Positivos: {quantidadePositivos}");
            Console.WriteLine($"Total de Negativos: {quantidadeNegativos}");*/
        }
    }
}