using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using lvmendes.Entidades;
using lvmendes.Servicos.Interfaces;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LoginApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
   
    public class PerfilController : ControllerBase
    {
        IPerfilServico servico;

        public PerfilController(IPerfilServico _servico)
        {
            servico = _servico;
        }

        /// <summary>
        /// Lista de Perfils Disponivel
        /// </summary>
        [HttpGet]
        [Route("Listar")]
        public IEnumerable<Perfil> Listar()
        {
            return servico.Listar();
        }
        /// <summary>
        /// Salvar Perfils
        /// </summary>
        [HttpPost]
        [Route("Salvar")]
        public ActionResult Salvar([FromBody]Perfil value)
        {
            var retorno = servico.Salvar(value);

            return Ok(new { response = retorno });

        }
        /// <summary>
        /// Carregar Perfil
        /// </summary>
        [HttpPost]
        [Route("Carregar")]
        public ActionResult Carregar([FromBody]long id)
        {
            return Ok(servico.Carregar(id));
        }
        /// <summary>
        /// Atualizar Perfil
        /// </summary>
        [HttpPost]
        [Route("Atualizar")]
        public ActionResult Atualizar([FromBody]Perfil objeto)
        {
            var retorno = servico.Atualizar(objeto);

            return Ok(new { response = retorno });

        }
        /// <summary>
        /// Deletar Perfil
        /// </summary>
        [HttpPost]
        [Route("Delete")]
        public ActionResult Delete([FromBody]Perfil objeto)
        {
            return Ok(servico.Delete(objeto));

        }
    }
}