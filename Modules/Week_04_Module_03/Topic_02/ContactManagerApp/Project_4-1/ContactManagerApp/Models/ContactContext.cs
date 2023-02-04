using Microsoft.EntityFrameworkCore;

namespace ContactManagerApp.Models
{
    public class ContactContext : DbContext
    {
        public ContactContext(DbContextOptions<ContactContext> options) : base(options) { }

        public DbSet<Contact> Contacts { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;


        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            // seed the categories
            modelbuilder.Entity<Category>().HasData(
                    new Category
                    {
                        CategoryId = 1,
                        Name = "Family"
                    },
                    new Category
                    {
                        CategoryId = 2,
                        Name = "Friend"
                    },
                    new Category
                    {
                        CategoryId = 3,
                        Name = "Work"
                    },
                    new Category
                    {
                        CategoryId = 4,
                        Name = "Other"
                    }
                );

            // seed some contacts
            modelbuilder.Entity<Contact>().HasData(
                    new Contact
                    {
                        ContactId = 1,
                        FirstName = "Bill (William)",
                        LastName = "O'Henry",
                        Phone = "555-555-1111",
                        Email = "bill@fake.com",
                        CategoryId = 1,
                        DateAdded = DateTime.Now
                    },
                    new Contact
                    {
                        ContactId = 2,
                        FirstName = "Tamera",
                        LastName = "Balantzian",
                        Phone = "555-555-2222",
                        Email = "tamera@fake.com",
                        CategoryId = 2,
                        DateAdded = DateTime.Now
                    },
                    new Contact
                    {
                        ContactId = 3,
                        FirstName = "Kevin",
                        LastName = "Rodgers",
                        Phone = "555-555-3333",
                        Email = "kevin@fake.com",
                        CategoryId = 3,
                        DateAdded = DateTime.Now
                    },
                    new Contact
                    {
                        ContactId = 4,
                        FirstName = "Sarah",
                        LastName = "Smiles",
                        Phone = "555-555-4444",
                        Email = "sarah@fake.com",
                        CategoryId = 4,
                        DateAdded = DateTime.Now
                    }
                );

        }
    }
}
