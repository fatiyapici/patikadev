using System;
using System.Linq;
using WebApi.DbOperations;

namespace WebApi.Applications.AuthorOperations.DeleteAuthor
{
    public class DeleteAuthorCommand
    {
        public int AuthorId { get; set; }
        private readonly BookStoreDbContext _context;

        public DeleteAuthorCommand(BookStoreDbContext context)
        {
            _context = context;
        }

        public void Handle()
        {
            var author = _context.Authors.SingleOrDefault(x => x.Id == AuthorId);
            if (author is null)
                throw new InvalidOperationException("Silinecek yazar bulunamadi.");
            else
            {
                var authorBook = _context.Books.FirstOrDefault(x => x.AuthorId == AuthorId);
                if (authorBook != null)
                    throw new InvalidOperationException("Bu yazarin kitabi mevcut.");
                else
                {
                    _context.Authors.Remove(author);
                    _context.SaveChanges();
                }
            }
        }
    }
}