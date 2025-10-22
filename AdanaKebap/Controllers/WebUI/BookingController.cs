using Microsoft.AspNetCore.Mvc;
using AdanaKebap.Context;
using AdanaKebap.Models.WebUI;


namespace AdanaKebap.Controllers.WebUI
{
    public class BookingController : Controller
    {
        private readonly AppDbContext _context;

        public BookingController(AppDbContext context)
        {
            _context = context;
        }

        [Route("rezervasyon-yap")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("rezervasyon-onay")]
        public IActionResult Submit()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Submit(BookingForModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
        

            var booking = new Booking
            {

                FullName = model.Name,
                Phone = model.Phone,
                Date = model.Date,
                PersonCount = model.PersonCount,
                Message = model.Message

            };
            _context.Bookings.Add(booking);
            _context.SaveChanges();

            return RedirectToAction("Submit", "Booking");
        }
    }
}
