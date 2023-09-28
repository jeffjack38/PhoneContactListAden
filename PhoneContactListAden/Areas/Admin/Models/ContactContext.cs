using Microsoft.EntityFrameworkCore;

namespace PhoneContactListAden.Models
{
    public class ContactContext : DbContext
    {
        public ContactContext(DbContextOptions<ContactContext> options)
            : base(options)
        { }

        public DbSet<Contact> Contacts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>().HasData(
                new Contact
                {
                    ContactId = 1,
                    Name = "Frank",
                    PhoneNumber = "123-456-7890",
                    Address = "123 Mulberry Street",
                    Note = "Frankenstein"
                },

                new Contact
                {
                    ContactId = 2, 
                    Name = "Billy",
                    PhoneNumber = "123-456-7891",
                    Address = "234 Mulberry Street",
                    Note = "Neighbor"
                }
                );
        }
    }
}
