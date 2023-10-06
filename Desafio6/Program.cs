namespace Desafio6;

/*
 * DESAFIO 06:
   
   Elabore um algoritmo que dada a idade de um nadador, classifique-o em uma das 
   seguintes categorias:
   Infantil A = 5 a 7 anos.
   Infantil B = 8 a 11 anos.
   Juvenil A = 12 a 13 anos.
   Juvenil B = 14 a 17 anos.
   Adultos = Maiores de 18 anos.
   Apresentar as mensagens no console com a classificação.
 */

public class Program
{
    public static void Main()
    {
        
        Console.WriteLine("BEM VINDO AO CADASTRO DE NADADORES");
        List<Nadador> nadadores = new List<Nadador>();

        do
        {
            Console.Clear();
            int contador = 1;
            string nome = LerNome("Digite o nome do nadador");
            int idade = LerIdade("Digite a idade do nadador");
            Nadador nadador = new Nadador(nome, idade);
            nadadores.Add(nadador);
            
            Console.WriteLine("\nLISTA DE NADADORES:\n");
            foreach(Nadador n in nadadores)
            {
                Console.WriteLine("NADADOR " + contador);
                Console.WriteLine(n);
                contador++;
            }
            

            Console.WriteLine("Deseja cadastrar mais algum nadador? (Digite 's' para sim ou qualquer outra tecla para sair)");

        } while (Console.ReadLine().ToLower() == "s");
        
        
        
        
    }
    
    public static int LerIdade(string prompt)
    {
        int numero;
        bool numValido = false;

        do
        {
            Console.Write($"{prompt}: ");
            numValido = int.TryParse(Console.ReadLine(), out numero);

            if (!numValido || numero < 0)
            {
                Console.WriteLine("Você não digitou uma idade válida. Tente novamente.\n");
            }
        } while (!numValido || numero < 0);

        return numero;
    }
    
    public static string LerNome(string prompt)
    {
        string nome;

        do
        {
            Console.Write($"{prompt}: ");
            nome = Console.ReadLine().Trim();

            if (string.IsNullOrWhiteSpace(nome))
            {
                Console.WriteLine("O nome não pode estar em branco. Tente novamente.\n");
            }
        } while (string.IsNullOrWhiteSpace(nome));

        return nome;
    }
}