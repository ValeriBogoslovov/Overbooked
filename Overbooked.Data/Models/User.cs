namespace Overbooked.Data.Models
{
    using Microsoft.AspNetCore.Identity;
    // Add profile data for application users by adding properties to the User class
    public class User : IdentityUser
    {
        public int? HotelId { get; set; }
        public Hotel Hotel { get; set; }

        public string MailClient { get; set; }
    }
}
