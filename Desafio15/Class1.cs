namespace Desafio15;

/*
 * Faça um algoritmo que leia números até o usuário digitar 0, após
   finalizar, mostre quantos números lidos, a soma e quantos são pares
 */

public class Class1
{
    public static void Main()
    {
        do
        {
            Console.WriteLine("Este programa cria lê N números até que o usuário digite 0 e retorna a soma e os números pares.\n");
            
            double[] vetorLido = new double[0];
            double[] vetorPares = new double[0];
            int aux = 1;
            int aux2 = 0;
            double soma = 0.00;
            
            while(true){
                double numero = LerNumeroDouble("Informe o número", aux);
                if (numero == 0)
                {
                    break;
                }

                Array.Resize(ref vetorLido, vetorLido.Length + 1);
                vetorLido[vetorLido.Length - 1] = numero;
                soma += numero;

                if (numero % 2 == 0)
                {
                    Array.Resize(ref vetorPares, vetorPares.Length + 1);
                    vetorPares[vetorPares.Length - 1] = numero;
                }

                aux++;
  
            }
            string vetorLido_str = string.Join(", ", vetorLido);
            string vetorPares_str = string.Join(", ", vetorPares);

            Console.WriteLine("\nNÚMEROS LIDOS = {" + vetorLido_str + "}");
            Console.WriteLine("NÚMEROS PARES = {" + vetorPares_str + "}");
            Console.WriteLine("SOMA DOS NÚMEROS = " + soma);
            
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
}