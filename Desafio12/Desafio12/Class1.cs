namespace Desafio12;

/*
 * Faça um algoritmo que construa dois vetores A e B de 10 elementos e,
   a partir deles, crie um vetor C, composto pela somados elementos, sendo: 
   
   C[1] = A[1] + B[9], C[2] = A[2] + B[9], C[3] = A[3] + B[8], etc.
 */

public class Class1
{
    public static void Main()
    {
        do
        {
            Console.WriteLine("Este programa cria dois vetores A e B, realiza operações nos elementos e armazena o resultado em um vetor C.\n");
            
            int size = LerNumeroInt("Informe o tamanho dos vetores A e B");
            
            double[] vetorA = new double[size];
            double[] vetorB = new double[size];
            double[] vetorC = new double[size];

            for (int i = 0; i < size; i++)
            { 
                vetorA[i] = LerNumeroDouble("Informe o valor do vetor A na posição", i + 1);
            }
            
            Console.WriteLine();
            
            for (int i = 0; i < size; i++)
            {
                vetorB[i] = LerNumeroDouble("Informe o valor do vetor B na posição", i + 1);
            }
            
            for (int i = 0; i < size; i++)
            {
                vetorC[i] = vetorA[i] + vetorB[size - 1 - i];
            }
            
            string vetorA_str = string.Join(", ", vetorA);
            string vetorB_str = string.Join(", ", vetorB);
            string vetorC_str = string.Join(", ", vetorC);
            Console.WriteLine("\nVETOR A = {" + vetorA_str + "}");
            Console.WriteLine("VETOR B = {" + vetorB_str + "}");
            Console.WriteLine("VETOR C = {" + vetorC_str + "}");
            
            Console.WriteLine("\nDeseja calcular novamente? (Digite 's' para sim ou qualquer outra tecla para sair)");
                    
        } while (Console.ReadLine().ToLower() == "s");

    }
    
    public static double LerNumeroDouble(string prompt, int i)
    {
        double numero;
        bool numValido = false;

        do
        {
            Console.Write($"{prompt} {i}: ");
            numValido = double.TryParse(Console.ReadLine(), out numero);

            if (!numValido)
            {
                Console.WriteLine("Você não digitou um número válido. Tente novamente.\n");
            }
        } while (!numValido);

        return numero;
    }
    
    public static int LerNumeroInt(string prompt)
    {
        int numero;
        bool numValido = false;

        do
        {
            Console.Write($"{prompt}: ");
            numValido = int.TryParse(Console.ReadLine(), out numero);

            if (!numValido)
            {
                Console.WriteLine("Você não digitou um número válido. Tente novamente\n.");
            }
        } while (!numValido);

        return numero;
    }
    
    
    
}