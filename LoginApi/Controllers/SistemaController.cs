using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using lvmendes.Entidades;
using lvmendes.Servicos.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LoginApi.Controllers
{
    public class SistemaController : Controller
    {

        ISistemaServico servico;

        public SistemaController(ISistemaServico _servico)
        {
            this.servico = _servico;
        }


    }
}