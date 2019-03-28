using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace _4onACouch.Models
{
    [Table("Game")]
    public class Game
    {
        [Key]
        public int GameID { get; set; }
    }
}