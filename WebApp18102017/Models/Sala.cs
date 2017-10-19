using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApp18102017.Models
{
    public class Sala
    {
        // [Required]
        public int SalaId { get; set; }
        //  [Required]
        public int Numero { get; set; }

        //[Required]
        public int Capacidade { get; set; }

        // [Required]
        public string Descricao { get; set; }

        public List<Sessao> Sessoes { get; set; }

        public string  ChaveAcesso { get; set; }
    }
}