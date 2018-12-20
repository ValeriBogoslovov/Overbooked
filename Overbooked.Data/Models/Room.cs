using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Overbooked.Data.Models
{
    public class Room
    {
        public int Id { get; set; }

        [Range(0, 10000)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        public int? HotelId { get; set; }

        public Hotel Hotel { get; set; }

        public RoomType Type { get; set; }
    }
}
