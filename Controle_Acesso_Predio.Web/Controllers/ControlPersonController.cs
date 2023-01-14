using Controle_Acesso_Predio.Application.DTO_s;
using Controle_Acesso_Predio.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Controle_Acesso_Predio.Web.Controllers
{
    public class ControlPersonController : Controller
    {
        private readonly IControlPersonService _controlPersonService;

        public ControlPersonController(IControlPersonService controlPersonService)
        {
            _controlPersonService = controlPersonService;
        }

        public async Task<IActionResult> Index()
        {
            var result = await _controlPersonService.GetAllAsync();

            return View(result);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create(ControlPersonDTO controlPersonDTO)
        {
            if(controlPersonDTO != null)
            {
                var result = await _controlPersonService.CreateAsync(controlPersonDTO);

                return RedirectToAction("Index");
            }

            return View();
        }
    }
}
