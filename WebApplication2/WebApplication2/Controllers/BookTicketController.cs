using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookTicketController : Controller
    {
        List<BookTicket> listobj = new List<BookTicket>();
        [HttpPost]
        public IActionResult addticket(BookTicket ticket)
        {
            BookTicket obj = new BookTicket();
            obj.Id = ticket.Id;
            obj.personName = ticket.personName;
            obj.personEmail = ticket.personEmail;
            obj.movieDate = ticket.movieDate;
            obj.movieName = ticket.movieName;
            obj.ticketCount = ticket.ticketCount;

            listobj.Add(obj);
            Console.WriteLine(obj);
            return Ok(obj);
        }
    }
}
