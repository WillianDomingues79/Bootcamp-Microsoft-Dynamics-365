// Para ler e escrever dados em C#, utilizamos os seguintes métodos da classe Console:
// - Console.ReadLine: lê UMA linha com dado(s) de Entrada (Inputs) do usuário;
// - Console.WriteLine: imprime um texto de Saída (Output) e pulando uma linha.

using System;

public class Program
{

    public static void Main(string[] args)
    {
        string[] entrada = Console.ReadLine().Split();
        int participantes = int.Parse(entrada[0]);
        int cachorrosQuentes = int.Parse(entrada[1]);

        //TODO: Calcular a média de cachorros-quentes consumidos pelos participantes.

        //TODO: Imprimir a média com duas casas decimais.
        //Dica: Pesquise sobre o método "ToString".
        double media = ((double)participantes / cachorrosQuentes);
        Console.WriteLine(media.ToString("F2"));

        //OUTRA SOLUÇÃO
        /*double result = ((double)participantes / cachorrosQuentes);
        double resultado = Math.Round(result, 2);
        Console.WriteLine(resultado);*/
    }
}

