using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace dipendenti_management.Models
{
    [Table("amministatori")]
    public class Amministratore
    {
        [Key]
        [Column("amm_id")]
        public int Id { get; set; }

        [Column("amm_username")]
        public String username { get; set; }

        [Column("amm_password")]
        public String password { get; set; }

    }
}