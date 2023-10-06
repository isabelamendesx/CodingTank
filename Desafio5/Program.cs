namespace Aula2;

/*
 *DESAFIO 05:
   
   Sr. José, pescador, comprou um microcomputador para
   controlar o rendimento diário de seu trabalho. Toda vez que ele traz um peso de
   peixes maior que o estabelecido pelo regulamento de pesca do estado de São Paulo
   (50 quilos) deve pagar uma multa de R$4,00 por quilo excedente. Sr. José, precisa que
   você faça programa que leia o peso de peixes e verifique se há excesso.
   Se houver, gravar o Excesso e o valor da multa que Sr. José
   deverá pagar. Caso contrário mostrar os valores com o conteúdo ZERO. 
   Apresentar as mensagens no console
 * 
 */

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Olá Sr. José");
        List<PescaDiaria> dias = new List<PescaDiaria>();
        
        do
        {
            Console.Clear();
            int contador = 1;
            double totalEmMulta = 0.00;
            double kilosPescados = LerNumero("\nDigite quantos quilos de peixe o Sr. pescou");
            PescaDiaria pescaDiaria = new PescaDiaria(kilosPescados);
            dias.Add(pescaDiaria);
            
            Console.WriteLine("Sua lista de pescas:\n");
            foreach(PescaDiaria p in dias)
            {
                Console.WriteLine("DIA " + contador);
                Console.WriteLine(p);
                contador++;
                totalEmMulta += p.ExcessoDiario;
            }
            
            Console.WriteLine($"TOTAL DEVIDO EM MULTA: {totalEmMulta:F2}\n");
            
            Console.WriteLine("Deseja adiconar mais uma pesca a lista? (Digite 's' para sim ou qualquer outra tecla para sair)");

        } while (Console.ReadLine().ToLower() == "s");

    }
    
    public static double LerNumero(string prompt)
    {
        double numero;
        bool numValido = false;

        do
        {
            Console.Write($"{prompt}: ");
            numValido = double.TryParse(Console.ReadLine(), out numero);

            if (!numValido || numero < 0)
            {
                Console.WriteLine("Você não digitou um número válido. Tente novamente.\n");
            }
            else if (numero != Math.Floor(numero)) // Verifica se o número não é inteiro
            {
                Console.WriteLine($"Peso arredondado para: {Math.Ceiling(numero)} para melhor cálculo da multa\n");
                return Math.Ceiling(numero); // Retorna o número arredondado para cima
            }
        } while (!numValido || numero < 0);

        return numero;
    }
    
    
}