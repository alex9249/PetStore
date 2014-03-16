using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace Pet_Store.Models
{
    public class Pet
    {
        public int ID { get; set; }
        public string Name { get; set; }

        [Display(Name = "Short Description")]
        public string Short_Description { get; set; }

        [Display(Name = "Long Description")]
        public string Long_Description { get; set; }

        [Display(Name = "Date Recieved")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Date_Recieved { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
    public class PetDBContext : DbContext
    {
        public DbSet<Pet> Pets { get; set; }
    }
}