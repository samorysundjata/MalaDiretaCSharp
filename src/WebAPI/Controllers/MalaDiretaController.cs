using Core.Entities;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MalaDiretaController : ControllerBase
    {
        private readonly ILogger<MalaDiretaController> _logger;

        public MalaDiretaController(ILogger<MalaDiretaController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetDestinatario")]
        public IEnumerable<Destinatario> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new Destinatario
            {
                Id = index,
                Nome = "Nome " + index,
                Email = "email" + index + "@gmail.com",
                Telefone = "9999999999",
                Endereco = new Endereco
                {
                    Logradouro = "Rua " + index,
                    Numero = index.ToString(),
                    Cidade = "Cidade " + index,
                    Estado = "Estado " + index,
                    CEP = "99999-999"
                }
            })
            .ToArray();
        }
    }
}
