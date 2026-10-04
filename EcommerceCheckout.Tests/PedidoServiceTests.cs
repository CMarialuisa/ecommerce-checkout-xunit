namespace EcommerceCheckout.Tests;
using Xunit;
using EcommerceCheckout.App;

public class PedidoServiceTests
{
    [Fact]
    public void Teste1_GerarCodigoRastreio()
        {
            var service = new PedidoService();
            var resultado = service.GerarCodigoRastreio("sudeste", 42);
            Assert.Equal("SUDESTE-0042", resultado);
        }

        [Fact]
        public void Teste2_CalcularPontosFidelidade()
        {
            var service = new PedidoService();
            var resultado = service.CalcularPontosFidelidade(150);
            Assert.Equal(30, resultado);
        }

        [Fact]
        public void Teste3_CompraVipAbaixoDe200()
        {
            var service = new PedidoService();
            var resultado = service.TemDireitoAFreteGratis(150, true);
            Assert.True(resultado);
        }

        [Fact]
        public void Teste4_CompraNaoVipAbaixoDe200()
        {
            var service = new PedidoService();
            var resultado = service.TemDireitoAFreteGratis(150, false);
            Assert.False(resultado);
        }
}
