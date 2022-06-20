using Microsoft.AspNetCore.Mvc;
using ProjetoFinal_POO2.Models;
using ProjetoFinal_POO2.Services.Interfaces;
using System;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace ProjetoFinal_POO2.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : Controller
    {
        private IAlunoService _service { get; set; }
        public AlunoController(IAlunoService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("get-alunos")]
        public async Task<IActionResult> GetAlunos()
        {
            try
            {
                var data = await _service.GetAllAlunos();

                if (data.Count() > 0)
                    return Ok(data);
                else
                    return BadRequest();
            }
            catch(Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPost("cadastro")]
        public async Task<IActionResult> CreateAluno([FromForm] Aluno aluno)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var data = await _service.CadastroAlunos(aluno);

            if (data > 0)
                return Redirect("/");
            else
                return BadRequest();

        }
    }
}
