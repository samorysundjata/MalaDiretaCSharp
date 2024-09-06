namespace Core.Entities.Tests
{
    public class EnderecoTests
    {
        [Fact]
        public void Endereco_Properties_SetCorrectly()
        {
            // Arrange
            var endereco = new Endereco();

            // Act
            endereco.Logradouro = "Rua A";
            endereco.Numero = "123";
            endereco.Cidade = "São Paulo";
            endereco.Estado = "SP";
            endereco.CEP = "12345-678";

            // Assert
            Assert.Equal("Rua A", endereco.Logradouro);
            Assert.Equal("123", endereco.Numero);
            Assert.Equal("São Paulo", endereco.Cidade);
            Assert.Equal("SP", endereco.Estado);
            Assert.Equal("12345-678", endereco.CEP);
        }
    }
}
