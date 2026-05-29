using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.BLL.Models
{
    public class LoanModel
    {
        public int Id { get; set; }
        public DateTime LoanDate { get; set; }
        public double TicketPrice { get; set; }
        public int BookId { get; set; }
        public BookModel Book { get; set; }
        public int MemberId { get; set; }
        public MemberModel Member { get; set; }
    }
}
