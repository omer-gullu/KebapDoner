using AdanaKebap.Models.Admin;

namespace AdanaKebap.Models.WebUI
{
    public class Booking
    {
        public int BookingID { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public DateTime Date { get; set; }
        public int PersonCount { get; set; }
        public string Message { get; set; }

      
    }
}
