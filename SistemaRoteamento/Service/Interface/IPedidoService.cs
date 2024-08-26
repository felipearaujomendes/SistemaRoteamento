using SistemaRoteamento.Models;

namespace SistemaRoteamento.Service.Interface
{
    public interface IPedidoService
    {
        void ProcessarPedido(Pedido pedido);
    }
}
