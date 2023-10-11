namespace Desafio14;

/*
 * Some os números de 1 a 100 a imprima o valor.
 */

public class Class1
{
    public static void Main()
    {
        Console.Write(somaInteiros(100));
    }

    public static int somaInteiros(int n)
    {
        if (n == 0)
        {
            return 0;
        }
        else
        {
            return n + somaInteiros(n - 1);
        }
    }
}