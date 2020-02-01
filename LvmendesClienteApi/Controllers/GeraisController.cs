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
    public class GeraisController : ControllerBase
    {
        IGeralServico servico;

        public GeraisController(IGeralServico _servico)
        {
            servico = _servico;
        }

        /// <summary>
        /// Lista de Perfils Disponivel
        /// </summary>
        [HttpGet]
        [Route("ListarEstado")]
        public IEnumerable<Estado> ListarEstado()
        {
            return servico.ListaEstados();
        }
        /// <summary>
        /// Salvar Perfils
        /// </summary>
        [HttpPost]
        [Route("SalvarEstado")]
        public ActionResult SalvarEstado([FromBody]Estado value)
        {
            var retorno = servico.SalvarEstado(value);

            return Ok(new { response = retorno });

        }
        /// <summary>
        /// Carregar Perfil
        /// </summary>
        [HttpPost]
        [Route("CarregarEstado")]
        public ActionResult CarregarEstado([FromBody]long id)
        {
            return Ok(servico.CarregarEstado(id));
        }


        /// <summary>
        /// Lista de Perfils Disponivel
        /// </summary>
        [HttpGet]
        [Route("ListarCidade/{idEstado}")]
        public IEnumerable<Cidade> ListarCidade(Int64 idEstado)
        {
            return servico.CidadesPorEstado(idEstado);
        }
        /// <summary>
        /// Salvar Perfils
        /// </summary>
        [HttpPost]
        [Route("SalvarCidade")]
        public ActionResult SalvarCidade([FromBody]Cidade value)
        {
            var retorno = servico.SalvarCidade(value);

            return Ok(new { response = retorno });

        }
        /// <summary>
        /// Carregar Perfil
        /// </summary>
        [HttpPost]
        [Route("CarregarCidade")]
        public ActionResult CarregarCidade([FromBody]long id)
        {
            return Ok(servico.CarregarCidade(id));
        }


    }
}