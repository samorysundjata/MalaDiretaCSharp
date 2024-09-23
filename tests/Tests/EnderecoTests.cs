namespace Core.Entities.Tests
{
    public class EnderecoTests
    {
        [Fact]
        public void Endereco_Properties_SetCorrectly()
        {
            // Arrange
            var endereco = new Endereco("Rua A", "123", "São Paulo", "SP", "12345-678");

            // Act
            // Properties are already set via constructor

            // Assert
            Assert.Equal("Rua A", endereco.Logradouro);
            Assert.Equal("123", endereco.Numero);
            Assert.Equal("São Paulo", endereco.Cidade);
            Assert.Equal("SP", endereco.Estado);
            Assert.Equal("12345-678", endereco.CEP);
        }
    }
}
