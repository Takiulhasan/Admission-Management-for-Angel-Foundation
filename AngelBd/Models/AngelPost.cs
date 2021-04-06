using System;
using System.Collections.Generic;

using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AngelBd.Models
{
    public class AngelPost
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public string Post { get; set; }
    }

    public class AngelPostDBContext : DbContext

    {
        public DbSet<AngelPost> AngelPosts { get; set; }
    }
}