namespace Desafio4;


public class Program
{
    public static void Main()
    {
        do{
            Console.Clear();
            
            double moedaConversao;
            double valorConvertido;
            double valorReais = LerNumero("Insira um valor em reais");

                do
                {
                    Console.WriteLine("Para qual moeda deseja converter?\n1. Dólar\n2. Euro");
                    moedaConversao = LerNumero("Digite a opção");
                    valorConvertido = converteMoeda(valorReais, moedaConversao);
                } while (valorConvertido == 0);
            
            Console.WriteLine($"{valorConvertido:F2}");
                
            Console.WriteLine("Deseja calcular mais uma vez? (Digite 's' para sim ou qualquer outra tecla para sair)");
                        
        } while (Console.ReadLine().ToLower() == "s");
    }

    public static double converteMoeda(double valorInicial, double moeda)
    {
        switch (moeda)
        {
            // DOLAR
            case 1:
                Console.Write("VALOR EM DÓLAR: ");
                return valorInicial / 5.50;
            // EURO
            case 2:
                Console.Write("VALOR EM EUROS: ");
                return valorInicial / 6.50;
            default:
                Console.WriteLine("Digite uma opção válida");
                return 0;
        }
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