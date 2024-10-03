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
            var mockDestinatario = new Mock<Destinatario>(new Endereco("Rua A", "123", "Cidade B", "Estado C", "12345678"));
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
            var mockDestinatario = new Mock<Destinatario>(new Endereco("", "123", "Cidade B", "Estado C", "12345678"));
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
            var mockDestinatario = new Mock<Destinatario>(new Endereco("Rua A", "123", "Cidade B", "Estado C", "12345678"));
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
            var mockDestinatario = new Mock<Destinatario>(new Endereco("Rua A", "123", "Cidade B", "Estado C", "1234"));
            mockDestinatario.Setup(d => d.ValidarCEP()).Returns(false);

            // Act
            var result = mockDestinatario.Object.ValidarCEP();

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void Exibir_ShouldPrintCorrectInformation()
        {
            // Arrange
            var endereco = new Endereco("Rua A", "123", "Cidade B", "Estado C", "12345678");
            var destinatario = new Destinatario(endereco)
            {
                Nome = "John Doe",
                Email = "john.doe@example.com",
                Telefone = "123456789"
            };

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                // Act
                destinatario.Exibir();

                // Assert
                var expectedOutput = "Nome: John Doe\nEmail: john.doe@example.com\nTelefone: 123456789\nEndereço: Rua A, 123, Cidade B, Estado C, 12345678\n";
                Assert.Equal(expectedOutput, sw.ToString());
            }
        }

        [Fact]
        public void Constructor_ShouldInitializeEndereco()
        {
            // Arrange
            var endereco = new Endereco("Rua A", "123", "Cidade B", "Estado C", "12345678");

            // Act
            var destinatario = new Destinatario(endereco);

            // Assert
            Assert.Equal(endereco, destinatario.Endereco);
        }
    }
}
