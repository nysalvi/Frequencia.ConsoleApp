using System;

namespace Frequencia.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args) {
            int[] numeros = new int[2000];
            int numeroAtual;
            string input;
            while (true) {
                Console.WriteLine("Digite um número entre 1 e 2000 :\n\tOu digite 's' para sair...");
                input = Console.ReadLine();
                if (int.TryParse(input, out numeroAtual) && numeroAtual > 0 && numeroAtual < 2001)
                    numeros[numeroAtual - 1]++;
                else if (input.ToLower().Equals("s"))
                    break;
            }            
            for (int i = 0;  i < numeros.Length; i++) {
                if (numeros[i] > 0)
                    Console.WriteLine(i + 1 + "aparece " + numeros[i] + "vez(es).");
            }
            Console.ReadLine();
        }
    }
}
