using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace lvmendes.Entidades
{
    [Table("Usuario", Schema = "dbo")]
    public class Usuario 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public List<Autorizacoes> Autorizacoes { get; set; }
    }
}
