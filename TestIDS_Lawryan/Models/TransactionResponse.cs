namespace TestIDS_Lawryan.Models
{
    public class TransactionResponse
    {
        public List<TrTransaction> Data { get; set; }

        public List<MsStatus> Status { get; set; }
    }
}