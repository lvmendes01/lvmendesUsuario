using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lvmendes.Entidades
{
    [Table("Sistema", Schema = "dbo")]
    public class Sistema
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 Id { get; set; }
        public string Nome { get; set; }
    }
}