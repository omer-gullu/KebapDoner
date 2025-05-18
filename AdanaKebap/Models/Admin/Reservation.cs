using AdanaKebap.Models.WebUI;
using System.Reflection.Metadata.Ecma335;

namespace AdanaKebap.Models.Admin
{
    public class Reservation
    {
        public int ReservationID { get; set; }
        public string FullName { get; set; }
        public int Phone { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public string Description { get; set; }
        public int BookingID { get; set; }
        public List<Booking> Bookings { get; set; }
    }
}
