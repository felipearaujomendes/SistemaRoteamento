using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaRoteamento.Models;
using SistemaRoteamento.Service.Interface;

namespace SistemaRoteamento.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PedidoController : ControllerBase
    {
        private readonly IPedidoService _pedidoService;

        public PedidoController(IPedidoService pedidoService)
        {
            _pedidoService = pedidoService;
        }

        [HttpPost]
        public IActionResult EnviarPedido([FromBody] Pedido pedido)
        {
            _pedidoService.ProcessarPedido(pedido);
            return Ok("Pedido recebido e roteado.");
        }
    }
}
