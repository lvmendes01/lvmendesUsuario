using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using lvmendes.Entidades;
using lvmendes.Servicos.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ApiLogin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SistemaController : ControllerBase
    {

        ISistemaServico servico;

        public SistemaController(ISistemaServico _servico)
        {
            servico = _servico;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Sistema>> Get()
        {
            return servico.Listar().ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
            try
            {
                servico.Salvar(new Sistema { Nome = "SISTEMA" });
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
