using Newtonsoft.Json;

namespace Core.Services
{
    public sealed class ViaCepResult
    {
        [JsonProperty("cep")]
        public string ZipCode { get; set; }

        [JsonProperty("logradouro")]
        public string Street { get; set; }

        [JsonProperty("complemento")]
        public string Complement { get; set; }

        [JsonProperty("bairro")]
        public string Neighborhood { get; set; }

        [JsonProperty("localidade")]
        public string City { get; set; }

        [JsonProperty("uf")]
        public string StateInitials { get; set; }

        [JsonProperty("unidade")]
        public string Unit { get; set; }

        [JsonProperty("ibge")]
        public int IBGECode { get; set; }

        [JsonProperty("gia")]
        public int? GIACode { get; set; }
    }
}
