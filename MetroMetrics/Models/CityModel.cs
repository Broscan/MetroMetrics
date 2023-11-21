using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MetroMetrics.Models
{

    [Table("Cities")]
    public class CityModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]

        [Column("id")]
        public int CityId { get; set; }
        public string? Name { get; set; }
        [Column("country_id")]
        public int CountryId { get; set; }
        public CountryModel? Country { get; set; }
        [Column("latitude", TypeName = "decimal(12, 10)")]
        public decimal Latitude { get; set; }
        [Column("longitude", TypeName = "decimal(12, 10)")]
        public decimal Longitude { get; set; }

    }
}
