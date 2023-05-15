// Para ler e escrever dados em C#, utilizamos os seguintes métodos da classe Console:
// - Console.ReadLine: lê UMA linha com dado(s) de Entrada (Inputs) do usuário;
// - Console.WriteLine: imprime um texto de Saída (Output) e pulando uma linha.

using System;

public class Program
{
    public static void Main()
    {
        string numero = Console.ReadLine();

        if (numero.Contains("13"))
        {
            Console.WriteLine("13 es de Mala Suerte");
        }
        else
        {
            Console.WriteLine($"{numero} NO es de Mala Suerte");
        }
        //TODO: Descubra e imprima se o número é azarado.
        //Dica: O método "Contains" pode ser útil neste desafio.
    }
}