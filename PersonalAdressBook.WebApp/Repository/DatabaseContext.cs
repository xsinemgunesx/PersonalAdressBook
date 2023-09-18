using Microsoft.EntityFrameworkCore;
using PersonalAdressBook.WebApp.Models;

namespace PersonalAdressBook.WebApp.Repository;

public class DatabaseContext: DbContext
{
    public DatabaseContext(DbContextOptions options) : base(options) { }
	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB; Database=Personal_Address_Book_Db; Trusted_Connection=true");

	}
	public DbSet<Person> Persons { get; set; }

}
