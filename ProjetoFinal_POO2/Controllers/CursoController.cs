using Microsoft.AspNetCore.Mvc;
using ProjetoFinal_POO2.Models;
using ProjetoFinal_POO2.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoFinal_POO2.Controllers
{
    public class CursoController : Controller
    {
        private readonly ICursoService _service;
        public CursoController(ICursoService service)
        {
            _service = service;
        }

        [HttpGet("get-cursos")]
        public async Task<IActionResult> GetCursos()
        {
            try
            {
                var data = await _service.GetAllCursos();

                if (data.Count() > 0)
                    return Ok(data);
                else
                    return BadRequest();
            }
            catch
            {
                return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
            }
        }

        [HttpPost("criar-curso")]
        public async Task<IActionResult> CreateCursos(Curso curso)
        {
            try
            {
                var data = await _service.CreateCurso(curso);

                if (data > 0)
                    return Ok(data);
                else
                    return BadRequest();
            }
            catch
            {
                return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
            }
        }
    }
}
