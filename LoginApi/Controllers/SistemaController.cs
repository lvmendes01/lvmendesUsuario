﻿using System;
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
    public class SistemaController : ControllerBase
    {
        ISistemaServico servico;

        public SistemaController(ISistemaServico _servico)
        {
            servico = _servico;
        }

        /// <summary>
        /// Lista de Sistemas Disponivel
        /// </summary>
        [HttpGet]
        [Route("Listar")]
        public IEnumerable<Sistema> Listar()
        {
            return servico.Listar();
        }
        /// <summary>
        /// Salvar sistemas
        /// </summary>
        [HttpPost]
        [Route("Salvar")]
        public ActionResult Salvar([FromBody]Sistema value)
        {
           return Ok(servico.Salvar(value));

        }
        /// <summary>
        /// Carregar Sistema
        /// </summary>
        [HttpPost]
        [Route("Carregar")]
        public ActionResult Carregar([FromBody]long id)
        {
            return Ok(servico.Carregar(id));
        }
        /// <summary>
        /// Atualizar Sistema
        /// </summary>
        [HttpPost]
        [Route("Atualizar")]
        public ActionResult Atualizar([FromBody]Sistema objeto)
        {
            return Ok(servico.Atualizar(objeto));

        }
        /// <summary>
        /// Deletar Sistema
        /// </summary>
        [HttpPost]
        [Route("Delete")]
        public ActionResult Delete([FromBody]Sistema objeto)
        {
            return Ok(servico.Delete(objeto));

        }
    }
}
