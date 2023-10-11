namespace Desafio8;

/*
 * DESAFIO 08:
   
   Um aluno realizou três provas de uma determinada disciplina. Levando em consideração o
   critério apresentado a seguir, faça um programa que mostre se ele ficou para exame final,
   e caso positivo, que nota o aluno precisará obter para passar de ano.
   
   "Média = (Prova 1 + Prova 2 + Prova 3) / 3"
   
   A média deve ser igual ou maior que 7,0. Caso o aluno não consiga, a nova média deve ser:
   
   "Final = (Média + Exame) / 2"
   
   media + exame / 2 = 5
   media + exame = 10
   exame = 10 - media
   
   A média final para a aprovação deve ser igual ou maior que 5,0.
 */

public class Program
{
    public static void Main()
    {

        do
        {
            Console.Clear();
            double nota1 = LerNota("Digite a primeira nota");
            double nota2 = LerNota("Digite a segunda nota");
            double nota3 = LerNota("Digite a terceira nota");

            double media = CalculaMedia(nota1, nota2, nota3);
            Console.WriteLine(foiAprovado(media));

            Console.WriteLine("\nDeseja calcular mais uma vez? (Digite 's' para sim ou qualquer outra tecla para sair)");
                    
        } while (Console.ReadLine().ToLower() == "s");
        
    }
    
    public static double LerNota(string prompt)
    {
        double numero;
        bool numValido = false;

        do
        {
            Console.Write($"{prompt}: ");
            numValido = double.TryParse(Console.ReadLine(), out numero);

            if (!numValido || numero < 0.00 || numero > 10.00)
            {
                Console.WriteLine("Você não digitou uma nota válida. Tente novamente.");
            }
        } while (!numValido || numero < 0.00 || numero > 10.00);

        return numero;
    }

    public static double CalculaMedia(double nota1, double nota2, double nota3)
    {
        return (nota1 + nota2 + nota3) / 3;
    }

    public static string foiAprovado(double media)
    {
        if (media >= 7.00)
        {
            return $"Aluno aprovado com média {media:F2}, Parabéns!\n";
        }
        else
        {
            double notaExame = 10 - media;
            return $"Que pena :(\nA média foi {media:F2}, aluno na Prova Final\nNota que precisa obter no exame: {notaExame:F2}\n";
        }
    }
}