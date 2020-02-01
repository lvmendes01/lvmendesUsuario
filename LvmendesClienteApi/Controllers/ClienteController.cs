using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lvmendes.Cliente.Entidades;
using Lvmendes.Cliente.Servico.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LvmendesClienteApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        IPessoaFisicaServico servico;

        public ClienteController(IPessoaFisicaServico _servico)
        {
            servico = _servico;
        }

        /// <summary>
        /// Lista de Perfils Disponivel
        /// </summary>
        [HttpGet]
        [Route("Listar")]
        public IEnumerable<PessoaFisica> ListarPessoaFisica()
        {
            return servico.Listar();
        }
        /// <summary>
        /// Salvar Perfils
        /// </summary>
        [HttpPost]
        [Route("Salvar")]
        public ActionResult Salvar([FromBody]PessoaFisica value)
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
        public ActionResult Atualizar([FromBody]PessoaFisica objeto)
        {
            var retorno = servico.Atualizar(objeto);

            return Ok(new { response = retorno });

        }
        /// <summary>
        /// Deletar Perfil
        /// </summary>
        [HttpPost]
        [Route("Delete")]
        public ActionResult Delete([FromBody]PessoaFisica objeto)
        {
            return Ok(servico.Delete(objeto));

        }
    }
}