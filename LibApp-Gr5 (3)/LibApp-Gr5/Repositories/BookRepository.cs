

using LibApp.Interfaces;
using LibApp.Data;
using System.Collections.Generic;
using LibApp.Models;
namespace LibApp.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly ApplicationDbContext _context;


        public BookRepository(ApplicationDbContext context)
        {
            _context = context;

        }
        public IEnumerable<BookRepository> GetBooks()
        {
            return _context.Books;

        }


        Book GetBookById(int id)=> _context.Books.Find(id);

        void AddBook(Book book)=> _context.Books.Add(book);

       
        void DeleteBook(int id)=> _context.Books.Remove(GetBookById(id));

         void UpdateBook(Book book)=>  _context.Books.Update(book);

        void Save() => _context.SaveChanges();


    }
}