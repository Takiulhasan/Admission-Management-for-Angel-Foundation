using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AngelBd.Models
{
    public class GalleryManagement
    {
        public int ID { get; set; }

        public string Photo { get; set; }
        [NotMapped]
        public HttpPostedFileBase ImageFile { get; set; }

    }

    public class GalleryManagementDBContext : DbContext
        {
            public DbSet<GalleryManagement> GalleryManagements { get; set; } 
        }



}