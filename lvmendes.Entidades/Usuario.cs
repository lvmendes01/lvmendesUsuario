using System;
using System.Collections.Generic;
using System.Text;

namespace lvmendes.Entidades
{
    public class Usuario : Identificacao
    {
        public string Email { get; set; }
        public string Senha { get; set; }
        public Autorizacoes Autorizacoes { get; set; }
    }
}
