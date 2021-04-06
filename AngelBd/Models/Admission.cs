using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AngelBd.Models
{ 
    
    public class Admission
  {
    public int ID { get; set; }
    public string StudentName { get; set; }
    public Gender1 Gender { get; set; }


        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime DateOfBirth { get; set; }
    public string Nationality { get; set; }
    public string Religion { get; set; }
    public string FatherName { get; set; }
    public string FatherOccupation { get; set; }
    public string MotherName { get; set; }
    public string MotherOccupation { get; set; }
    public string PresentAddress { get; set; }
    public string ParmanentAddress { get; set; }
    public string TypesOfAutism { get; set; }
    public string Describe { get; set; }
    public decimal Mobile { get; set; }
    
    public string UploadImage { get; set; }
    public ContactStatus Status { get; set; }

        public enum ContactStatus
        {
            Submitted,
            Approved,
            Rejected
        }
        public enum Gender1 { Male,Female }



    }

    public class AdmissionDBContext : DbContext

    {
        public DbSet<Admission> Admissions { get; set; }
    }

}