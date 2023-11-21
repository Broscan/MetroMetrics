using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MetroMetrics.Models
{
    [Table("Countries")]
    public class CountryModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        [Column("id")]
        public int CountryId { get; set; }
        [Column("numeric_Code")]
        public int NumericCode { get; set; }
        [Column("phone_Code")]
        public string? PhoneCode { get; set; }
        public string? Capital { get; set; }
        public string? Currency { get; set; }
        [Column("currency_name")]
        public string? CurrencyName { get; set; }
        public string? Nationality { get; set; }
        public string? TimeZones { get; set; }
    }
}
