using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using lvmendes.Entidades;
using lvmendes.Servicos.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LoginApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        IUsuarioServico servico;

        public UsuarioController(IUsuarioServico _servico)
        {
            servico = _servico;
        }

        /// <summary>
        /// Lista de Usuarios Disponivel
        /// </summary>
        [HttpGet]
        [Route("Listar")]
        public IEnumerable<Usuario> Listar()
        {
            return servico.Listar();
        }
        /// <summary>
        /// Salvar Usuarios
        /// </summary>
        [HttpPost]
        [Route("Salvar")]
        public ActionResult Salvar([FromBody]Usuario value)
        {
            return Ok(servico.Salvar(value));

        }
        /// <summary>
        /// Carregar Usuario
        /// </summary>
        [HttpPost]
        [Route("Carregar")]
        public ActionResult Carregar([FromBody]long id)
        {
            return Ok(servico.Carregar(id));
        }
        /// <summary>
        /// Atualizar Usuario
        /// </summary>
        [HttpPost]
        [Route("Atualizar")]
        public ActionResult Atualizar([FromBody]Usuario objeto)
        {
            return Ok(servico.Atualizar(objeto));

        }
        /// <summary>
        /// Deletar Usuario
        /// </summary>
        [HttpPost]
        [Route("Delete")]
        public ActionResult Delete([FromBody]Usuario objeto)
        {
            return Ok(servico.Delete(objeto));

        }
    }
}