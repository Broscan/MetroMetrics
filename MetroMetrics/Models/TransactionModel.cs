using System.ComponentModel.DataAnnotations;

namespace MetroMetrics.Models
{

    public class TransactionModel
    {
        [Key]
        public int TransactionId { get; set; }
        public DateTime TimeStamp { get; set; }
        public long DurationInMs { get; set; }
        public string? Assignment { get; set; }
    }
}
