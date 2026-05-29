using Library.BLL.Models;
using Library.DAL.Entities;

namespace Library.PL.Models.ViewModels
{
    public class MemberViewModel
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public ICollection<Loan> Loans { get; set; } = new List<Loan>();
    }
}
