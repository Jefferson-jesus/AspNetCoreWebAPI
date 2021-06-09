using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SmartSchool.WebAPI.Models;

namespace SmartSchool.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController : ControllerBase
    {
        public List<Aluno> Alunos = new List<Aluno>(){
            new Aluno() {
                id =1,
                Nome = "Jefferson",
                Telefone = "11 97979-5088",
                Sobrenome = "de Jesus Oliveira"
            },
            new Aluno() {
                id =2,
                Nome = "Keith",
                Telefone = "11 97979-5066",
                Sobrenome = "Gonçalves Farias"
            },
            new Aluno() {
                id =3,
                Nome = "Gabrielly",
                Telefone = "11 97979-5077",
                Sobrenome = "Farias Jesus de Oliveira"
            },
            new Aluno() {
                id =4,
                Nome = "Maria Clara",
                Telefone = "11 97979-5077",
                Sobrenome = "Farias"
            }
        };

        public AlunoController() {}

        // api/aluno/byid
        [HttpGet("byId")]
        public IActionResult Get()
        {
            return Ok(Alunos);
        }

        [HttpGet("byId/{id}")]
        public IActionResult GetById()
        {
            return Ok(Alunos);
        }

         [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            var aluno = Alunos.FirstOrDefault(a => a.id == id);

            if (aluno == null) return BadRequest("Erro ao tentar processar sua solicitação!");

            return Ok(aluno);
        }

        [HttpGet("ByName")]
        public IActionResult GetByName(string nome, string sobrenome)
        {
            var aluno = Alunos.FirstOrDefault(a => 
                a.Nome.Contains(nome) && a.Sobrenome.Contains(sobrenome)
            );

            if (aluno == null) return BadRequest("Erro ao tentar processar sua solicitação!");

            return Ok(aluno);
        }


        [HttpPost]
        public IActionResult Post(Aluno aluno)
        {
            return Ok(aluno);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Aluno aluno)
        {
            return Ok(aluno);
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Aluno aluno)
        {
            return Ok(aluno);
        }

         [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok();
        }

    }
}