using System.ComponentModel.DataAnnotations;

namespace TestIDS_Lawryan.Models
{
    public class TrTransaction
    {
        [Key]
        public int ID { get; set; }
        public string ProductID { get; set; }
        public string? ProductName { get; set; }
        public long Amount { get; set; }
        public string? CustomerName { get; set; }
        public int StatusID { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string? CreateBy { get; set; }
        public DateTime? CreateOn { get; set; }
    }
}