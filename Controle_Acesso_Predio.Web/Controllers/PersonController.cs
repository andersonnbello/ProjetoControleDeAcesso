using Controle_Acesso_Predio.Application.DTO_s;
using Controle_Acesso_Predio.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Controle_Acesso_Predio.Web.Controllers
{
    public class PersonController : Controller
    {
        private readonly IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        public async Task<ActionResult> Index()
        {
            var person = await _personService.GetAllAsync();

            return View(person);
        }

        public IActionResult Create()
        { 
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PersonDTO personDTO)
        {
            if(personDTO != null)
            {
                await _personService.CreateAsync(personDTO);

                return RedirectToAction("Index");
            }

            return View();
        }
    }
}
