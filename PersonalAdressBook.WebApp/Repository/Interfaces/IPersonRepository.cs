using PersonalAdressBook.WebApp.Models;

namespace PersonalAdressBook.WebApp.Repository.Interfaces;

public interface IPersonRepository
{
	void Add(Person person);
	void Update(Person person);
	void Delete(int id);
	Person GetById(int id);
	IEnumerable<Person> GetAll();
}
