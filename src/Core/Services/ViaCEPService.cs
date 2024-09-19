using Newtonsoft.Json.Linq;

namespace Core.Services
{
    public class ViaCEPService
    {
        public async Task<string> GetAddressByCEP(string cep)
        {
            // TODO: Implement logic to interact with ViaCEP service and retrieve address by CEP
            // You can use HttpClient to make HTTP requests to the ViaCEP API

            // Example code to make a GET request using HttpClient
            using (HttpClient client = new HttpClient())
            {
                string url = $"https://viacep.com.br/ws/{cep}/json/";
                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    // TODO: Parse the JSON response and return the address details
                    return jsonResponse;
                }
                else
                {
                    // TODO: Handle the error case appropriately
                    return null;
                }
            }
        }

        // Example method to parse the JSON response from ViaCEP
        private string ParseAddressFromJson(string jsonResponse)
        {
            // Use a JSON library like Newtonsoft.Json to deserialize the JSON response
            JObject json = JObject.Parse(jsonResponse);

            // Extract the address details from the JSON object
            // Extract the address details from the JSON object
            string address = (string?)json["logradouro"] ?? "Unknown";
            string neighborhood = (string?)json["bairro"] ?? "Unknown";
            string city = (string?)json["localidade"] ?? "Unknown";
            string state = (string?)json["uf"] ?? "Unknown";
            string cep = (string?)json["cep"] ?? "Unknown";

            // Construct the formatted address string
            string formattedAddress = $"{address}, {neighborhood}, {city} - {state}, {cep}";

            return formattedAddress;
        }
    }
}
