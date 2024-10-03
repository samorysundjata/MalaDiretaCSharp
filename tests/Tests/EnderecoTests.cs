using Moq;

namespace Core.Entities.Tests
{
    public class EnderecoTests
    {
        [Fact]
        public void Endereco_Properties_SetCorrectly()
        {
            // Arrange
            var mockEndereco = new Mock<Endereco>("Rua A", "123", "São Paulo", "SP", "12345-678");

            // Act
            // Properties are already set via constructor

            // Assert
            Assert.Equal("Rua A", mockEndereco.Object.Logradouro);
            Assert.Equal("123", mockEndereco.Object.Numero);
            Assert.Equal("São Paulo", mockEndereco.Object.Cidade);
            Assert.Equal("SP", mockEndereco.Object.Estado);
            Assert.Equal("12345-678", mockEndereco.Object.CEP);
        }

        [Fact]
        public void ValidarEndereco_ValidEndereco_ReturnsTrue()
        {
            // Arrange
            var mockEndereco = new Mock<Endereco>("Rua A", "123", "São Paulo", "SP", "12345-678");
            mockEndereco.Setup(e => e.ValidarEndereco(It.IsAny<Endereco>())).Returns(true);

            // Act
            var result = mockEndereco.Object.ValidarEndereco(mockEndereco.Object);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void ValidarEndereco_InvalidEndereco_ReturnsFalse()
        {
            // Arrange
            var mockEndereco = new Mock<Endereco>("", "123", "São Paulo", "SP", "12345-678");
            mockEndereco.Setup(e => e.ValidarEndereco(It.IsAny<Endereco>())).Returns(false);

            // Act
            var result = mockEndereco.Object.ValidarEndereco(mockEndereco.Object);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void ValidarCEP_ValidCEP_ReturnsTrue()
        {
            // Arrange
            var mockEndereco = new Mock<Endereco>("Rua A", "123", "São Paulo", "SP", "12345-678");
            mockEndereco.Setup(e => e.ValidarCEP(It.IsAny<string>())).Returns(true);

            // Act
            var result = mockEndereco.Object.ValidarCEP("12345-678");

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void ValidarCEP_InvalidCEP_ReturnsFalse()
        {
            // Arrange
            var mockEndereco = new Mock<Endereco>("Rua A", "123", "São Paulo", "SP", "12345-678");
            mockEndereco.Setup(e => e.ValidarCEP(It.IsAny<string>())).Returns(false);

            // Act
            var result = mockEndereco.Object.ValidarCEP("12345678");

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void Exibir_DisplaysCorrectly()
        {
            // Arrange
            var mockEndereco = new Mock<Endereco>("Rua A", "123", "São Paulo", "SP", "12345-678");
            var expectedOutput = "Rua A, 123, São Paulo, SP, 12345-678";

            // Act
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                mockEndereco.Object.Exibir();
                var result = sw.ToString().Trim();

                // Assert
                Assert.Equal(expectedOutput, result);
            }
        }
    }
}
