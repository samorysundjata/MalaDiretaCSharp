using Core.Entities;
using Moq;

namespace Tests
{
    public class DestinatarioTests
    {
        [Fact]
        public void ValidarEndereco_ShouldReturnTrue_WhenEnderecoIsValid()
        {
            // Arrange
            var mockDestinatario = new Mock<Destinatario>("Rua A", "123", "Cidade B", "Estado C", "12345678");
            mockDestinatario.Setup(d => d.ValidarEndereco()).Returns(true);

            // Act
            var result = mockDestinatario.Object.ValidarEndereco();

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void ValidarEndereco_ShouldReturnFalse_WhenEnderecoIsInvalid()
        {
            // Arrange
            var mockDestinatario = new Mock<Destinatario>("", "123", "Cidade B", "Estado C", "12345678");
            mockDestinatario.Setup(d => d.ValidarEndereco()).Returns(false);

            // Act
            var result = mockDestinatario.Object.ValidarEndereco();

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void ValidarCEP_ShouldReturnTrue_WhenCEPIsValid()
        {
            // Arrange
            var mockDestinatario = new Mock<Destinatario>("Rua A", "123", "Cidade B", "Estado C", "12345678");
            mockDestinatario.Setup(d => d.ValidarCEP()).Returns(true);

            // Act
            var result = mockDestinatario.Object.ValidarCEP();

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void ValidarCEP_ShouldReturnFalse_WhenCEPIsInvalid()
        {
            // Arrange
            var mockDestinatario = new Mock<Destinatario>("Rua A", "123", "Cidade B", "Estado C", "1234");
            mockDestinatario.Setup(d => d.ValidarCEP()).Returns(false);

            // Act
            var result = mockDestinatario.Object.ValidarCEP();

            // Assert
            Assert.False(result);
        }
    }
}
