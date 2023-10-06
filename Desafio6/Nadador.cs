namespace Desafio6;

public class Nadador
{
    private string nome;
    private int idade;
    private string categoria;

    public Nadador(string nome, int idade)
    {
        this.nome = nome;
        this.idade = idade;
        this.categoria = ClassificarCategoria();
    }
    
    public string ClassificarCategoria()
    {
        if (idade >= 5 && idade <= 7)
        {
            return "Infantil A";
        }
        else if (idade >= 8 && idade <= 11)
        {
            return "Infantil B";
        }
        else if (idade >= 12 && idade <= 13)
        {
            return "Juvenil A";
        }
        else if (idade >= 14 && idade <= 17)
        {
            return "Juvenil B";
        }
        else if (idade >= 18)
        {
            return "Adultos";
        }
        else
        {
            return "Idade fora das categorias";
        }
    }

    public override string ToString()
    {
        return $"- NOME: {nome}\n- IDADE: {idade}\n- CATEGORIA: {categoria}\n";
    }
}