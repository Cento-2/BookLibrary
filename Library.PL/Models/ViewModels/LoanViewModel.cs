using Library.BLL.Models;

namespace Library.PL.Models.ViewModels
{
    public class LoanViewModel
    {
        public int Id { get; set; }
        public DateTime LoanDate { get; set; }
        public double TicketPrice { get; set; }
        public int BookId { get; set; }
        public BookModel Book { get; set; }
        public int MemberId { get; set; }
    }
}
