using MicroRabbit.MVC.Models.DTO;

namespace MicroRabbit.MVC.Services
{
    public interface ITransferService
    {
        Task<HttpResponseMessage> Transfer(TransferDto transferDto);
    }
}
