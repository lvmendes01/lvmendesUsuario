using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using lvmendes.Servicos.Interfaces;
using Lvmendes.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lvmendes.UploadApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArquivoController : ControllerBase
    {
        IArquivoServico servico;

        public ArquivoController(IArquivoServico _servico)
        {
            servico = _servico;
        }

        /// <summary>
        /// Lista de Perfils Disponivel
        /// </summary>
        [HttpGet]
        [Route("Listar")]
        public IEnumerable<Arquivo> ListarArquivo()
        {
            return servico.Listar();
        }
        /// <summary>
        /// Salvar Perfils
        /// </summary>
        [HttpPost]
        [Route("Salvar")]
        public ActionResult Salvar([FromBody]Arquivo value)
        {
            var retorno = servico.Salvar(value);

            return Ok(new { response = retorno });

        }
        /// <summary>
        /// Carregar Perfil
        /// </summary>
        [HttpPost]
        [Route("Carregar")]
        public ActionResult CarregarEstado([FromBody]long id)
        {
            return Ok(servico.Carregar(id));
        }
        /// <summary>
        /// Atualizar Perfil
        /// </summary>
        [HttpPost]
        [Route("Atualizar")]
        public ActionResult Atualizar([FromBody]Arquivo objeto)
        {
            var retorno = servico.Atualizar(objeto);

            return Ok(new { response = retorno });

        }
        /// <summary>
        /// Deletar Perfil
        /// </summary>
        [HttpPost]
        [Route("Delete")]
        public ActionResult Delete([FromBody]Arquivo objeto)
        {
            return Ok(servico.Delete(objeto));

        }
    }
}