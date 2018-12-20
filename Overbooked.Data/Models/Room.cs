﻿namespace Overbooked.Data.Models
{
    public class Room
    {
        public int Id { get; set; }

        public int? HotelId { get; set; }

        public Hotel Hotel { get; set; }

        public RoomType Type { get; set; }
    }
}
