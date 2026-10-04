# Ecommerce Checkout - Sistema de Pedidos

Este projeto foi desenvolvido como parte da lista de exercícios da disciplina de **Gestão e Qualidade de Software**. O objetivo é aplicar conceitos de qualidade de software, implementando regras de negócio e validando-as através de testes unitários automatizados.

## Tecnologias Utilizadas
- .NET 10
- C# (Console Application)
- xUnit (Framework de Testes)

## Regras de Negócio Implementadas

A classe `PedidoService.cs` contém os seguintes métodos:

1. **`GerarCodigoRastreio(string regiao, int numeroPedido)`:** Recebe o nome de uma região e um número de pedido. Retorna o código de rastreio formatado com a região em letras maiúsculas seguida de um hífen e o número do pedido com 4 dígitos (ex: `SUDESTE-0042`).
2. **`CalcularPontosFidelidade(int valorTotal)`:** Calcula os pontos de fidelidade do cliente. A cada R$ 10,00 gastos, o cliente recebe 2 pontos.
3. **`TemDireitoAFreteGratis(int valorTotal, bool eClienteVIP)`:** Retorna `true` se o cliente tiver direito a frete grátis. O frete é gratuito para compras com valor total igual ou superior a R$ 200,00, ou se o comprador for um cliente VIP.

## Cobertura de Testes

O projeto inclui uma suíte de testes unitários (`PedidoServiceTests.cs`) utilizando o framework **xUnit**. A cobertura garante que 100% dos cenários exigidos na lista foram validados:

- Verificação exata da máscara de rastreio usando `Assert.Equal`.
- Verificação do cálculo matemático de pontos usando `Assert.Equal`.
- Verificação da regra de frete grátis usando `Assert.True` (para VIPs abaixo de R$ 200) e `Assert.False` (para não VIPs abaixo de R$ 200).

## Como Executar os Testes

Para rodar a suíte de testes e verificar as validações, siga os passos abaixo:

1. Abra o terminal na raiz da solução ou dentro da pasta do projeto de testes.
2. Execute o seguinte comando:
   ```bash
   dotnet test
3. O console exibirá o resultado da execução confirmando que todos os cenários foram aprovados.

Desenvolvido por: Maria Luísa do Carmo Cardoso
RA: 325116932
