using Microsoft.AspNetCore.Mvc;
using PersonalAdressBook.WebApp.Models;
using PersonalAdressBook.WebApp.Repository.Interfaces;

namespace PersonalAdressBook.WebApp.Controllers;

public class PersonController : Controller
{
	private readonly IPersonRepository _personRepository;
    public PersonController(IPersonRepository personRepository)
    {
        _personRepository = personRepository;
    }
    public IActionResult GetAll()
	{
		var persons = _personRepository.GetAll();
		return View(persons);
	}
	public IActionResult Add()
	{
		return View();
	}
	[HttpPost]
	public IActionResult Add(Person person)
	{
		 _personRepository.Add(person);
		return RedirectToAction("Add");
	}
	public IActionResult Update(int id)
	{
		var personId = _personRepository.GetById(id);
		return View(personId);
	}
	[HttpPost]
	public IActionResult Update(Person person)
	{
		_personRepository.Update(person);
		return RedirectToAction("GetAll");
	}
	public IActionResult Delete(int id)
	{
		_personRepository.Delete(id);
		return View("GetAll");
	}


}
