using Microsoft.AspNetCore.Mvc;
using ProjetoFinal_POO2.Models;
using ProjetoFinal_POO2.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
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

        //[HttpPost("cadastro")]
        //public async Task<IActionResult> CreateAluno([FromForm] Professor professor)
        //{
        //    if (!ModelState.IsValid)
        //        return BadRequest(ModelState);

        //    var data = await _service.CadastroAlunos(aluno);

        //    if (data > 0)
        //        return Redirect("/");
        //    else
        //        return BadRequest();

        //}
    }
}
