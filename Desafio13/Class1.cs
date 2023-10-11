namespace Desafio13;

/*
 * Crie um programa que peça 10 números inteiros
   e apresente a média, a soma e o menor.
 */

public class Class1
{
    public static void Main()
    {
        do
        {
            Console.WriteLine("Este programa solicita 10 números inteiros ao usuário e retorna a média, a soma e o menor deles.\n");
            
            
            int[] vetorOriginal = new int[10];
            int soma = 0;
            double média = 0.00;
            int menor = 0;


            for (int i = 0; i < 10 ; i++)
            { 
                vetorOriginal[i] = LerNumeroInt("Informe o número", i + 1 );
                soma += vetorOriginal[i];
                if (i == 0 || vetorOriginal[i] < menor)
                {
                    menor = vetorOriginal[i];
                }
            }

            média = (double)soma / 10;
            
            string vetorOriginalStr = string.Join(", ", vetorOriginal);
            Console.WriteLine("\nVOCÊ DIGITOU OS NÚMEROS = {" + vetorOriginalStr + "}");
            Console.WriteLine($"A MÉDIA DOS NÚMEROS É {média:F2}");
            Console.WriteLine($"A SOMA DOS NÚMEROS É {soma}");
            Console.WriteLine($"O MENOR DOS NÚMEROS É {menor}");

            
            Console.WriteLine("\nDeseja calcular novamente? (Digite 's' para sim ou qualquer outra tecla para sair)");
                    
        } while (Console.ReadLine().ToLower() == "s");
    }
    
    public static int LerNumeroInt(string prompt, int i)
    {
        int numero;
        bool numValido = false;

        do
        {
            Console.Write($"{prompt} {i}1: ");
            numValido = int.TryParse(Console.ReadLine(), out numero);

            if (!numValido)
            {
                Console.WriteLine("Você não digitou um número válido. Tente novamente.\n");
            }
        } while (!numValido);

        return numero;
    }
}