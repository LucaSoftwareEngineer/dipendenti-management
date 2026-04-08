using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace dipendenti_management.Models
{
    [Table("dipendenti")]
    public class Dipendente
    {
        [Key]
        [Column("dip_id")]
        public int Id { get; set; }

        [Column("dip_nome")]
        public string Nome { get; set; }

        [Column("dip_cognome")]
        public string Cognome { get; set; }

        [Column("dip_data_nascita")]
        public DateTime DataNascita { get; set; }

        [Column("dip_luogo_nascita")]
        public string LuogoNascita { get; set; }
    }
}