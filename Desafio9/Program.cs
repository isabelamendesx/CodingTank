namespace Desafio9;

public class Program
{
    public static void Main()
    {
        
        do{
            Console.Clear();
            Console.WriteLine("Escolha um curso:");
            Console.WriteLine("1 - Curso de Programação em C#");
            Console.WriteLine("2 - Curso de Desenvolvimento Web");
            Console.WriteLine("3 - Curso de Ciência de Dados");
            Console.WriteLine("4 - Curso de Segurança da Informação\n");

            int escolha = LerInteiro("Digite o número do curso desejado: ");

            switch (escolha)
                    {
                        case 1:
                            Console.WriteLine("Você escolheu o Curso de Programação em C#.");
                            EscolherTurma();
                            break;
                        case 2:
                            Console.WriteLine("Você escolheu o Curso de Desenvolvimento Web.");
                            EscolherTurma();
                            break;
                        case 3:
                            Console.WriteLine("Você escolheu o Curso de Ciência de Dados.");
                            EscolherTurma();
                            break;
                        case 4:
                            Console.WriteLine("Você escolheu o Curso de Segurança da Informação");
                            EscolherTurma();
                            break;
                        default:
                            Console.WriteLine("Opção inválida. Por favor, escolha um número válido.");
                            break;
                    }

            Console.WriteLine("\nObrigado por se matricular!");
            
            Console.WriteLine("\nDeseja realizar outra operação? (Digite 's' para sim ou qualquer outra tecla para sair)");
                    
    } while (Console.ReadLine().ToLower() == "s");
        
        
    }

    static void EscolherTurma()
    {
        Console.WriteLine("\nEscolha uma turma:");
        Console.WriteLine("A - Turma da Manhã");
        Console.WriteLine("B - Turma da Tarde");
        Console.WriteLine("C - Turma da Noite");

        char escolha = LerChar("Digite a letra da turma desejada: ");

        switch (Char.ToUpper(escolha))
        {
            case 'A':
                Console.WriteLine("Você escolheu a Turma da Manhã.");
                break;
            case 'B':
                Console.WriteLine("Você escolheu a Turma da Tarde.");
                break;
            case 'C':
                Console.WriteLine("Você escolheu a Turma da Noite.");
                break;
            default:
                Console.WriteLine("Opção inválida. Por favor, escolha uma turma válida.");
                EscolherTurma();
                break;
        }
    }

    static int LerInteiro(string mensagem)
    {
        Console.Write(mensagem);
        if (int.TryParse(Console.ReadLine(), out int valor))
        {
            return valor;
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor, insira um número válido.");
            return LerInteiro(mensagem);
        }
    }

    static char LerChar(string mensagem)
    {
        Console.Write(mensagem);
        char valor = Console.ReadKey().KeyChar;
        Console.WriteLine(); // Adiciona uma quebra de linha após a entrada do caractere.
        return valor;
    }

}