using ExerFixEnum.Entities.Enums;
using System.Text;
using System.Globalization;

namespace ExerFixEnum.Entities
{
    public class Pedido
    {
       
        
        public DateTime Momento { get; set; }
        public StatusPedido Status { get; set; }
        public Cliente? Cliente { get; set; }
        public List <ItensPedido> Itens  { get; set; } = new List<ItensPedido>();

        public Pedido(){

        }
        public Pedido(StatusPedido status, Cliente cliente, DateTime momento){
            Status = status;
            Cliente = cliente;
            Momento = momento;
        }

         public void AddItem(ItensPedido item){
            Itens.Add(item);
        }
        public void RemoveItem(ItensPedido item){
            Itens.Remove(item);
        }


        public double Total(){
            double soma = 0.0;
            foreach(ItensPedido item in Itens){
                soma += item.SubTotal();
            }
            return soma;
        }
        

        public override string ToString()
        {
             StringBuilder sbPedido = new StringBuilder();
             sbPedido.AppendLine("Momento do pedido: " + Momento.ToString("dd/MM/yyyy HH:mm:ss"));
             sbPedido.AppendLine("Status do pedido: " + Status);
             sbPedido.AppendLine("Cliente: " + Cliente);
             sbPedido.AppendLine("Itens do pedido:");
             foreach (ItensPedido itens in Itens){
                sbPedido.AppendLine(itens.ToString());
             }
             sbPedido.AppendLine("Valor total: r$ " + Total().ToString("F2", CultureInfo.InvariantCulture));

             return sbPedido.ToString();
        }
    }
}