﻿using System;
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
    public class SistemaController : ControllerBase
    {
        ISistemaServico servico;

        public SistemaController(ISistemaServico _servico)
        {
            servico = _servico;
        }

        // GET: api/Sistema
        [HttpGet]
        public IEnumerable<Sistema> Get()
        {
            return servico.Listar().ToList();
        }

        // GET: api/Sistema/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Sistema
        [HttpPost]
        public void Post([FromBody] Sistema value)
        {
            try
            {
                servico.Salvar(value);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        // PUT: api/Sistema/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
