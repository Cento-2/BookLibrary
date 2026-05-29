using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DAL.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Location { get; set; }
        public DateTime BookDate { get; set; }
        public int AvailableCopies { get; set; }

        public ICollection<Loan> Loans { get; set; } = new List<Loan>();
    }
}
