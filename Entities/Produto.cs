
namespace ExerFixEnum.Entities
{
    public class Produto
    {
        public string? NomeProduto { get; set; }
        public double? PrecoProduto { get; set; }

        public Produto(){
        }

        public Produto( string nomeProduto, double precoProduto){
            NomeProduto = nomeProduto;
            PrecoProduto = precoProduto;
        }
    }
}