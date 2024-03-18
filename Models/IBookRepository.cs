namespace Mission11_Winn.Models
{
    public interface IBookRepository
    {
        public IQueryable<Book> Books { get; }
    }
}
