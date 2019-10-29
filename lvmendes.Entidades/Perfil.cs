using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lvmendes.Entidades
{
    [Table("Perfil", Schema = "dbo")]
    public class Perfil

    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 Id { get; set; }

        public Sistema Sistema { get; set; }
    }
}