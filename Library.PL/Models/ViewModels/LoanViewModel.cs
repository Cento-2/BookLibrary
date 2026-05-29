using Library.BLL.Models;
using Library.DAL.Entities;

namespace Library.PL.Models.ViewModels
{
    public class LoanViewModel
    {
        public int Id { get; set; }
        public DateTime LoanDate { get; set; }
        public double TicketPrice { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
        public int MemberId { get; set; }
        public Member Member { get; set; }
    }
}
