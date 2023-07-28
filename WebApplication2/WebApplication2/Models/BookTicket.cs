namespace WebApplication2.Models
{
    public class BookTicket
    {
        public int Id { get; set; }
        public string personName { get; set; }
        public string personEmail { get; set; }
        public string movieName { get; set; }
        public DateTime movieDate { get; set; }

        public int ticketCount { get; set; }
    }
}
