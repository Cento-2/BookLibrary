namespace Library.PL.Models.ViewModels
{
    public class BookViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Location { get; set; }
        public DateTime BookDate { get; set; }
        public int AvailableCopies { get; set; }
    }
}
