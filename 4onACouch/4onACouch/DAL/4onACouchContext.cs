using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using _4onACouch.Models;

namespace _4onACouch.DAL
{
    public class _4onACouchContext : DbContext
    {
        public _4onACouchContext()
                : base("_4onACouch")
        {

        }
        
        DbSet<Player> Players { get; set; }

        public System.Data.Entity.DbSet<_4onACouch.Models.Game> Games { get; set; }
    }
}