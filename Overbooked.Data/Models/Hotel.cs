using System.Collections.Generic;

namespace Overbooked.Data.Models
{

    public class Hotel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string UserId { get; set; }
        public User User { get; set; }

        public List<Room> Rooms { get; set; } = new List<Room>();
    }
}
