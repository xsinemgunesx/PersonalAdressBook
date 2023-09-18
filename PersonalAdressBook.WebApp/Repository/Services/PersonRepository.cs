using PersonalAdressBook.WebApp.Models;
using PersonalAdressBook.WebApp.Repository.Interfaces;

namespace PersonalAdressBook.WebApp.Repository.Services;

public class PersonRepository:IPersonRepository
{
	private readonly DatabaseContext _databaseContext;

	public PersonRepository(DatabaseContext databaseContext)
	{
		_databaseContext = databaseContext;
	}
	public void Add(Person model)
	{
		_databaseContext.Add(model);
		_databaseContext.SaveChanges();
	}
	public Person GetById(int id)
	{
		return _databaseContext.Persons.Find(id);
	}
	public void Update(Person model)
	{
		_databaseContext.Update(model);
		_databaseContext.SaveChanges();
	}
	public void Delete(int id) 
	{
		var person = _databaseContext.Persons.FirstOrDefault(p => p.Id == id);
		_databaseContext.Remove(person);
		_databaseContext.SaveChanges();

	}
	public IEnumerable<Person> GetAll() 
	{ 
		return _databaseContext.Persons.ToList();
	}
}
