using Microsoft.EntityFrameworkCore;
namespace MyContacts.Models
{
    public class ContactContext : DbContext
    {
        public ContactContext(DbContextOptions<ContactContext> options) : base(options)
        {
        }

        public DbSet<Contact> Contacts { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
              new Category { CategoryId = 1, Name = "Aile" },
              new Category { CategoryId = 2, Name = "Arkadaş" },
              new Category { CategoryId = 3, Name = "İş" }
            );

            modelBuilder.Entity<Contact>().HasData(
              new Contact
              {
                  ContactId = 1,
                  FirstName = "Nadir",
                  LastName = "Payam",
                  PhoneNumber = "050711111100",
                  Email = "np@gmail.com",
                  CategoryId = 1,
              },
              new Contact
              {
                  ContactId = 2,
                  FirstName = "Yusuf",
                  LastName = "Yılmaz",
                  PhoneNumber = "050711111100",
                  Email = "yy@gmail.com",
                  CategoryId = 1,
              },
              new Contact
              {
                  ContactId = 3,
                  FirstName = "Mert",
                  LastName = "Boyer",
                  PhoneNumber = "050711111100",
                  Email = "mb@gmail.com",
                  CategoryId = 2,
              }
         );
        }
        
    }
}
