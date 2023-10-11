namespace Desafio7C;

public class Produto
{
        private int codigo;
        private string nome;
        private double preço;
        private int quantidadeVendida;

        public Produto(int codigo, string nome, double preço)
                 {
                     this.codigo = codigo;
                     this.nome = nome;
                     this.preço = preço;
                     quantidadeVendida = 0;
                 }

        public int Codigo
        {
            get => codigo;
            set => codigo = value;
        }

        public int QuantidadeVendida
        {
            get => quantidadeVendida;
            set => quantidadeVendida = value;
        }

        public double ValorDaVenda()
        {
            return preço * quantidadeVendida;
        }
    
        public override string ToString()
        {
            if(quantidadeVendida == 0){
                return $"- NOME: {nome}\n- CODIGO: {codigo}\n- PREÇO UNITÁRIO: R${preço:F2}\n";
            }
            else
            { 
                return $"- NOME: {nome}\n- CODIGO: {codigo}\n- PREÇO UNITÁRIO: R${preço:F2}\n- QUANTIDADE VENDIDA: {quantidadeVendida}\n- VALOR TOTAL VENDIDO: R${ValorDaVenda():F2}\n";
            }
        }
    
    
    
}