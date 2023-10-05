namespace Desafio1;

public class Program
{
    public static void Main()
    {

        do
        {
            Console.Clear();
            
            int numero1 = LerNumero("Número 1");
            int numero2 = LerNumero("Número 2");
            int operacao, resultado;
            
            Console.WriteLine($"Você digitou o número {numero1}");
            Console.WriteLine($"Você digitou o número {numero2}\n");

                    do
                    {
                        Console.WriteLine("Digite o número da operação que deseja realizar:\n" + "1. Soma\n" + "2. Subtração\n" +
                                          "3. Divisão\n" + "4. Multiplicação");
                        operacao = LerNumero("Operação");
                        resultado = Calculadora(numero1, numero2, operacao);
                    } while (resultado == 0);

                    Console.WriteLine($"\nO resultado da sua operação é {resultado}"); 
                    
                    Console.WriteLine("\nDeseja realizar outra operação? (Digite 's' para sim ou qualquer outra tecla para sair)");
                    
        } while (Console.ReadLine().ToLower() == "s");

    }

    public static int Calculadora(int numero1, int numero2, int operacao)
    {
        switch (operacao)
        {
            case 1:
                return numero1 + numero2;
            case 2:
                return numero1 - numero2;
            case 3:
                if (numero2 != 0)
                {
                    return numero1 / numero2;
                }
                else
                {
                    Console.WriteLine("Não é possível dividir um número por 0\n");
                    return 0;
                }
            case 4:
                return numero1 * numero2;
            default:
                Console.WriteLine("Digite uma operação válida\n");
                return 0;
        }
    }
    
    public static int LerNumero(string prompt)
    {
        int numero;
        bool numValido = false;

        do
        {
            Console.Write($"{prompt}: ");
            numValido = int.TryParse(Console.ReadLine(), out numero);

            if (!numValido)
            {
                Console.WriteLine("Você não digitou um número válido. Tente novamente.");
            }
        } while (!numValido);

        return numero;
    }
    

}