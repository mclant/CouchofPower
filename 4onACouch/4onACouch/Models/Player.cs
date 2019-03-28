using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace _4onACouch.Models
{
    [Table("Player")]
    public class Player
    {
        [Key]
        public int PlayerID { get; set; }
        public string PlayerName { get; set; }
        public int GameID { get; set; }

    }
}