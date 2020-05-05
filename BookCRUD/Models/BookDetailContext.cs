using System;
using Microsoft.EntityFrameworkCore;

namespace BookCRUD.Models
{
    public class BookDetailContext : DbContext
    {
        public BookDetailContext(DbContextOptions<BookDetailContext> options) : base(options)   
        {

        }

        public DbSet<BookDetail> BookDetails { get; set; }
    }
}
