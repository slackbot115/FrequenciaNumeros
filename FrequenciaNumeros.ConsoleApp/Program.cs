using System;
using System.Linq;

namespace FrequenciaNumeros.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Não está funcionando corretamente :(
            int[] numerosDigitados;
            string numerosRepetidos = "";
            Console.WriteLine("Frequência de Números!");
            Console.Write("\nDigite a quantidade de números que serão digitados: ");
            int qtNumerosDigitados = int.Parse(Console.ReadLine());
            numerosDigitados = new int[qtNumerosDigitados];
            for (int i = 0; i < numerosDigitados.Length; i++)
            {
                Console.Write("Digite o numero {0}: ", i + 1);
                numerosDigitados[i] = int.Parse(Console.ReadLine());
                numerosRepetidos += numerosDigitados[i];
            }
            string controleNumerosRepetidos = "";
            for (int i = 0; i < numerosDigitados.Length; i++)
            {
                int menorValor = numerosDigitados[i];

                for (int j = 0; j < numerosDigitados.Length; j++)
                {
                    if (menorValor > numerosDigitados[j])
                    {
                        menorValor = numerosDigitados[j];
                    }
                }
                numerosDigitados = numerosDigitados.Where(val => val != menorValor).ToArray();
                string num = menorValor.ToString();
                //if (controleNumerosRepetidos.Contains(num))
                //{
                //    continue;
                //}
                //else
                //{
                controleNumerosRepetidos += num;
                int repeticoes = numerosRepetidos.Split(num).Length - 1;
                Console.WriteLine($"O numero {menorValor} aparece {repeticoes} vez(es)");
                //}
            }
        }
    }
}
