namespace Desafio2;

/*
 * Desafio 2: Calculadora de Idade
   
   Objetivo: Escrever um programa que solicite ao usuário o ano atual e o ano de nascimento 
   e calcule a idade.
   
   Instruções:
   
   Solicite ao usuário que insira o ano atual.
   Solicite ao usuário que insira o ano de nascimento.
   Calcule a idade subtraindo o ano de nascimento do ano atual.
   Exiba a idade no console.
   
   Dica: Use variáveis para armazenar os valores de entrada e os resultados intermediários.
 */

public class Program
{
    public static void Main()
    {
        int idade;
        do
        {
            do
            {
                Console.Clear();

                int anoAtual = LerNumero("Digite o ano em que estamos");
                int anoNascimento = LerNumero("Digite o ano em que você nasceu");

                idade = calculaIdade(anoAtual, anoNascimento);
                
            } while (idade == 0);

            Console.WriteLine($"Sua idade é: {idade}");
            
            Console.WriteLine("\nDeseja calcular outra idade? (Digite 's' para sim ou qualquer outra tecla para sair)");
                    
        } while (Console.ReadLine().ToLower() == "s");
        

    }

    public static int calculaIdade(int anoAtual, int anoNascimento)
    {
        if (anoAtual < anoNascimento)
        {
            Console.WriteLine("O ano de nascimento deve ser menor que o ano atual");
            return 0;
        }
        else
        {
            return anoAtual - anoNascimento;
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