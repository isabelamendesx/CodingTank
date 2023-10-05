namespace Desafio3;


public class Program
{
    public static void Main()
    {
        do{
            Console.Clear();
           
            double contaRestaurante = LerNumero("Digite o valor total da sua conta no restaurante");
            double porcentagemGorjeta = LerNumero("Digite a porcentagem de gorjeta desejada");

            double gorjeta = contaRestaurante * (porcentagemGorjeta / 100);
            double contaTotal = contaRestaurante + gorjeta;
            
            Console.WriteLine($"GORJETA: R${gorjeta:F2}");
            Console.WriteLine($"TOTAL A SER PAGO: R${contaTotal:F2300}");
            
            Console.WriteLine("\nDeseja calcular outra conta? (Digite 's' para sim ou qualquer outra tecla para sair)");
                    
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

            if (!numValido)
            {
                Console.WriteLine("Você não digitou um número válido. Tente novamente.");
            }
        } while (!numValido);

        return numero;
    }



}