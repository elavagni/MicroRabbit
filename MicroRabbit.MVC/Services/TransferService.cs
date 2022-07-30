using MicroRabbit.MVC.Models.DTO;
using Newtonsoft.Json;

namespace MicroRabbit.MVC.Services
{
    public class TransferService : ITransferService
    {
        private readonly HttpClient _apiClient;

        public TransferService(HttpClient apiClient) 
        { 
            _apiClient = apiClient;
        }


        public async Task<HttpResponseMessage> Transfer(TransferDto transferDto)
        {
            var uri = "http://localhost:5151/api/banking";
            var transferContent = new StringContent(JsonConvert.SerializeObject(transferDto), System.Text.Encoding.UTF8, "application/json");
            var response = await _apiClient.PostAsync(uri, transferContent);
            return response.EnsureSuccessStatusCode();
        }
    }
}
