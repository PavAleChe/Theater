using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Theater.Models
{
    public class NewsContext : DbContext
    {
        //DbSet<News> Newses { get; set; }

        public System.Data.Entity.DbSet<Theater.Models.News> News { get; set; }
    }
}