using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.BLL.Models
{
    public class BookModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Location { get; set; }
        public DateTime BookDate { get; set; }
        public int AvailableCopies { get; set; }

        public ICollection<LoanModel> Loans { get; set; } = new List<LoanModel>();
    }
}
