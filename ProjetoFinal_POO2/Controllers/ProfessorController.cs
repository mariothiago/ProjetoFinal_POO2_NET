using Microsoft.AspNetCore.Mvc;
using ProjetoFinal_POO2.Models;
using ProjetoFinal_POO2.Services.Interfaces;
using System.Threading.Tasks;

namespace ProjetoFinal_POO2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfessorController : Controller
    {
        private IProfessorService _service { get; set; }
        public ProfessorController(IProfessorService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("cadastro")]
        public async Task<IActionResult> CreateProfessor([FromForm] Professor professor)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var data = await _service.CreateProfessor(professor);

            if (data > 0)
                return Redirect("/Sucesso");
            else
                return BadRequest();

        }
    }
}
