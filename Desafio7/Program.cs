namespace Desafio7C;

/*
* DESAFIO 07:

Uma loja de produtos eletrônicos com vendas regulares opta por contratar uma equipe
para a organização de um sistema de gerenciamento de vendas. Elabore um algoritmo que,
a partir de dados fornecidos pelo usuário, calcule o valor da venda de um produto,
exibindo uma saída em vídeo contendo o código do produto, o nome, a quantidade
comprada, o valor unitário e o valor total.
*/

public class Program
{
    
    public static void Main()
    {
        int contador;
        List<Produto> produtos = new List<Produto>();
        List<Produto> produtosVendidos = new List<Produto>();
        
        produtos.Add(new Produto(0001, "Microondas", 450.00));
        produtos.Add(new Produto(0002, "Geladeira", 3500.00));
        produtos.Add(new Produto(0003, "Televisão", 2499.00));
        produtos.Add(new Produto(0004, "Liquidificador", 99.99));
        produtos.Add(new Produto(0005, "Aspirador de Pó", 250.00));

        do{
                do
                {
                    contador = 1;
                    Console.Clear();
                    Console.WriteLine("------------ CATÁLOGO DE PRODUTOS -----------");
                    
                    foreach (Produto p in produtos)
                    {
                        Console.WriteLine("PRODUTO " + contador);
                        Console.WriteLine(p);
                        contador++;
                    }

                    int codigo = LerCódigo("Digite o código do produto vendido");
                    int quantidade = LerQuantidade("Digite a quantidade do produto");
                    
                    Produto produtoVendido = produtos.Find(p => p.Codigo == codigo);
                    produtoVendido.QuantidadeVendida = quantidade;
                    produtosVendidos.Add(produtoVendido);
                    
                    
                    Console.WriteLine("Deseja adicionar mais algum produto a essa venda? (Digite 's' para sim ou qualquer outra tecla para exibir a nota fiscal)");

                } while (Console.ReadLine().ToLower() == "s");

        double valorTotal = 0.00;
        contador = 1;
        Console.WriteLine("------ NOTA FISCAL -------");
        foreach (Produto p in produtosVendidos)
        {
            valorTotal += p.ValorDaVenda();
            Console.WriteLine("PRODUTO " + contador);
            Console.WriteLine(p);
            contador++;
        }
        
        Console.WriteLine($"VALOR TOTAL DA VENDA: R${valorTotal}");
        
        Console.WriteLine("Deseja cadastrar uma nova venda? (Digite 's' para sim ou qualquer outra tecla para sair)");

        } while (Console.ReadLine().ToLower() == "s");
    }
    
    public static int LerCódigo(string prompt)
    {
        int numero;
        bool numValido = false;

        do
        {
            Console.Write($"{prompt}: ");
            numValido = int.TryParse(Console.ReadLine(), out numero);

            if (!numValido || numero < 0 || numero > 5)
            {
                Console.WriteLine("Você não digitou um código válido. Tente novamente.\n");
            }
        } while (!numValido || numero < 0);

        return numero;
    }


    public static int LerQuantidade(string prompt)
    {
        int numero;
        bool numValido = false;

        do
        {
            Console.Write($"{prompt}: ");
            numValido = int.TryParse(Console.ReadLine(), out numero);

            if (!numValido || numero < 0)
            {
                Console.WriteLine("Você não digitou uma quantidade válida. Tente novamente.\n");
            }
        } while (!numValido || numero < 0);

        return numero;
    }
}

