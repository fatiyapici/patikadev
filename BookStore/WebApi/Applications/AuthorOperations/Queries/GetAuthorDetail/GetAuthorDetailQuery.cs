using System;
using System.Linq;
using AutoMapper;
using WebApi.DbOperations;

namespace WebApi.Applications.AuthorOperations.GetAuthorDetail
{
    public class GetAuthorDetailQuery
    {
        public int AuthorId { get; set; }
        public readonly BookStoreDbContext _context;
        public readonly IMapper _mapper;

        public GetAuthorDetailQuery(BookStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public AuthorDetailViewModel Handle()
        {
            var author = _context.Authors.SingleOrDefault(x => x.Id == AuthorId);
            if (author is null)
            {
                throw new InvalidOperationException("Yazar bulunamadi.");
            }
            return _mapper.Map<AuthorDetailViewModel>(author);
        }
    }
    public class AuthorDetailViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }
    }
}