using System.ComponentModel.DataAnnotations;

namespace TestIDS_Lawryan.Models
{
    public class MsStatus
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
    }
}