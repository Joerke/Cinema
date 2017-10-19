using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApp18102017.Models
{
    [Table("TbSessao")]
    public class Sessao
    {
        [Key]
        public int Codigo{ get; set; }

        [Required]
        public int DataHoraInicio { get; set; }

        [Required]
        public int DataHotaFim { get; set; }

        [Required]
        public int ValorInteira { get; set; }

        [Required]
        public int ValorMeia { get; set; }

        [Required]
        public bool Encerrada { get; set; }


    }
}