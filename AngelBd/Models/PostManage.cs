using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AngelBd.Models
{
    public class PostManage
    {
      
    
        public int Id { get; set; }
        public string PostTitle { get; set; }
        public string PostContent { get; set; }



    }

    public class PostManageDBContext : DbContext

    {
        public DbSet<PostManage> PostManages { get; set; }  
    }
    
}