using System.Collections.Generic;

namespace lvmendes.Entidades
{
    public class Autorizacoes : Identificacao
    {

        public List<Perfil> Perfils { get; set; }
    }
}