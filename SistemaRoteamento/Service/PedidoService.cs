using SistemaRoteamento.Models;
using SistemaRoteamento.Service.Interface;

namespace SistemaRoteamento.Service
{
    public class PedidoService : IPedidoService
    {
        public void ProcessarPedido(Pedido pedido)
        {
            switch (pedido.Tipo.ToLower())
            {
                case "fritos":
                    // Lógica para enviar pedido para a área de fritos
                    break;
                case "grelhados":
                    // Lógica para enviar pedido para a área de grelhados
                    break;
                case "saladas":
                    // Lógica para enviar pedido para a área de saladas
                    break;
                case "bebidas":
                    // Lógica para enviar pedido para a área de bebidas
                    break;
                case "sobremesas":
                    // Lógica para enviar pedido para a área de sobremesas
                    break;
                default:
                    throw new ArgumentException("Tipo de pedido inválido");
            }
        }
    }
}
