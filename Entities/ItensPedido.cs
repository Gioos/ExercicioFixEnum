using System.Globalization;

namespace ExerFixEnum.Entities
{
    public class ItensPedido
    {
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public Produto? Produto { get; set; }

        public ItensPedido(){  
        }
        
        public ItensPedido(int quantidade, double preco, Produto produto){
            Quantidade = quantidade;
            Preco = preco;
            Produto = produto;
        }

        public double SubTotal(){
            return Preco * Quantidade;
        }

        public override string ToString(){
            return Produto!.NomeProduto + ", r$" + Preco.ToString("F2", CultureInfo.InvariantCulture)
            +", Quantidade: " + Quantidade + ", Subtotal: r$ "
            + SubTotal().ToString("F2", CultureInfo.InvariantCulture); 
        } 
    }
}