using Moq;
using SistemaRoteamento.Models;
using SistemaRoteamento.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PedidoServiceTests
{
    public class PedidoServiceTests
    {
        private readonly PedidoService _pedidoService;

        public PedidoServiceTests()
        {
            _pedidoService = new PedidoService();
        }

        [Fact]
        public void ProcessarPedido_Frito_DeveEscreverNoConsoleCorretamente()
        {
            // Arrange
            var pedido = new Pedido { Id = 1, Descricao = "Batata Frita", Tipo = "fritos" };

            // Captura a saída do Console
            var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);

            // Act
            _pedidoService.ProcessarPedido(pedido);

            // Assert - Verifica se o texto foi escrito no console corretamente
            var expectedOutput = $"Pedido Batata Frita foi roteado para fritos{Environment.NewLine}";
            Assert.Equals(expectedOutput, consoleOutput.ToString());
        }
    }
}
