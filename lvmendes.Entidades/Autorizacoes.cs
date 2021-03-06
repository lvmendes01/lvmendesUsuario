﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lvmendes.Entidades
{
    [Table("Autorizacao", Schema = "dbo")]
    public class Autorizacoes 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 Id { get; set; }

        public Int64 Perfil { get; set; }
        public Int64 Sistema { get; set; }
    }
}