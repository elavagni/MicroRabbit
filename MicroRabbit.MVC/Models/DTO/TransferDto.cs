namespace MicroRabbit.MVC.Models.DTO
{
    public class TransferDto
    {
        public string TransferNotes { get; set; }
        public int FromAccount { get; set; }
        public int ToAccount { get; set; }
        public decimal TransferAmount { get; set; }
    }
}
